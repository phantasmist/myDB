using myLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//데이터 소스 경로 + 설정
//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phantasmist\source\repos\myDataBase.mdf;Integrated Security=True;Connect Timeout=30
namespace myDB
{
    public partial class frmDBManager : Form
    {
        public frmDBManager()
        {
            InitializeComponent();
        }
        

        private void mnAddColumn_Click(object sender, EventArgs e)
        {
            string str = mylib.GetInput("Column Name");
            dbGrid.Columns.Add(str, str);
        }

        private void mnAddRow_Click(object sender, EventArgs e)
        {
            if (dbGrid.Columns.Count > 0)
                dbGrid.Rows.Add(); // 1줄만 추가, 열이 없으면 행 더할수 없다
            //dbGrid.Rows[1].Cells[5].Value = ""; //아무 값이나 대입 가능
            //dbGrid.Rows[1].Cells[5].Value.ToString(); //Object 타입이라 형변환 해야지 반환 가능
        }

        private void pmnAddColumn_Click(object sender, EventArgs e)
        {
            mnAddColumn_Click(sender, e); 
        }

        //중간에 메뉴가 날라가서 다시 만든 코드..
        private void mnAddRow_Click_1(object sender, EventArgs e)
        {
            mnAddRow_Click(sender, e);
        }

        private void mnAddColumn_Click_1(object sender, EventArgs e)
        {
            mnAddColumn_Click(sender, e);
        }


        iniClass ini = new iniClass(".\\myDB.ini");

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = int.Parse(ini.GetPString("Position", "LocationX", "0"));
            int y = int.Parse(ini.GetPString("Position", "LocationY", "0"));
            Location = new Point(x, y);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ini.WritePString("Position", "LocationX", $"{Location.X}");
            ini.WritePString("Position", "LocationY", $"{Location.Y}");
        }

        private void pmnAddRow_Click(object sender, EventArgs e)
        {
            mnAddRow_Click(sender, e);
        }


        private void sbLabel2_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            sbLabel2.Text = e.ClickedItem.Text; 
            string sql = $"select * from {e.ClickedItem.Text}";
            RunSql(sql);
            
        }

        char[] wsArr = { ' ', '\t', '\r', '\n' }; //whitespace array
        public int RunSql(string sql) // SQL 명령어 처리기
        {
            try
            {
                sqlCmd.CommandText = sql;
                //string.Trim()으로 string 전후의 whitespace 제거
                string sCmd = sql.Trim().Substring(0, 6);
                //case sensitivity 
                if (sCmd.ToLower() == "select")
                {
                    //sbLabel 에 Table 표기
                    int n1 = sql.ToLower().IndexOf("from"); //from의 위치
                    string s1 = sql.Substring(n1 + 4).Trim(); //from 이후 substring
                    currTable = s1.Split(wsArr)[0];
                    sbLabel2.Text = currTable;
                    
                    //sql.ToLower().
                    SqlDataReader sdr = sqlCmd.ExecuteReader(); //모든 명령어 처리는 불가능함
                    //클리어
                    dbGrid.Rows.Clear(); dbGrid.Columns.Clear();
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        string s = sdr.GetName(i); //get name of ith field
                        dbGrid.Columns.Add(s, s);
                    }
                    //라인단위 처리
                    for (int i = 0; sdr.Read(); i++)
                    {
                        int rIdx = dbGrid.Rows.Add(); //한줄 추가 + Row 번호 int로 반환
                        for (int j = 0; j < sdr.FieldCount; j++)
                        {
                            object obj = sdr.GetValue(j);
                            dbGrid.Rows[rIdx].Cells[j].Value = obj;
                        }
                    }
                    sdr.Close();
                    return 0;
                }
                else
                {
                    return sqlCmd.ExecuteNonQuery();

                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
                return -1; // 이게 에러의 관례인가?
            }
            
        }

        public string RunSql_noEcho(string sql)
        {  // SQL 명령어 처리: 조회 결과 문자열로 반환
            sqlCmd.CommandText = sql;

            try
            {
                string sCmd = sql.Trim().Substring(0, 6); //mylib.GetToken(0, sql.Trim(), ' ');
                if (sCmd.ToLower() == "select")
                {
                    int n1 = sql.ToLower().IndexOf("from");
                    string s1 = sql.Substring(n1 + 4).Trim();    //student  where code < 4 
                    currTable = s1.Split(wsArr)[0];
                    sbLabel2.Text = currTable;
                    //CurrentTable = sql.Substring(sql.ToLower().IndexOf("from") + 4).Trim().Split(ca)[0];

                    SqlDataReader sdr = sqlCmd.ExecuteReader();

                    string sRet = sdr.GetName(0);
                    for (int i = 1; i < sdr.FieldCount; i++)
                    {
                        sRet += $",{sdr.GetName(i)}";
                    }
                    sRet += "\r\n";

                    for (int i = 0; sdr.Read(); i++)
                    {
                        sRet += sdr.GetValue(0);
                        for (int j = 1; j < sdr.FieldCount; j++)
                        {
                            sRet += $",{sdr.GetValue(j)}";
                        }
                        sRet += "\r\n";
                    }
                    sdr.Close();
                    return sRet;
                }
                else
                {
                    return $"{sqlCmd.ExecuteNonQuery()}";
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message); return e1.Message;
            }
        }


        // C# 신기능:
        // \r과 같은 esc sequence를 무시하는 경로문자열: @""  보간문자열: $""
        SqlConnection sqlConn = new SqlConnection(); // app - db connection
        SqlCommand sqlCmd = new SqlCommand(); // 위 커넥션 기반으로 명령어 전달
        string ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phantasmist\source\repos\myDataBase.mdf;Integrated Security=True;Connect Timeout=30";
        string currTable = "";

        private void mnOpenF_Click_1(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.FilterIndex = 2; //DB파일(*.mdf)
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

                ConnString =
                    $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="
                    + openFileDialog.FileName +
                    $";Integrated Security=True;Connect Timeout=30";

                //db open process
                sqlConn.ConnectionString = ConnString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                //sbLabel 수정
                sbLabel1.Text = openFileDialog.SafeFileName; // 경로 없이 이름만 반환
                sbLabel1.BackColor = Color.Green;


                DataTable dt = sqlConn.GetSchema("Tables");
                for (int i = 0; i < dt.Rows.Count; i++)
                    sbLabel2.DropDownItems.Add(dt.Rows[i].ItemArray[2].ToString());
                sbLabel2.Text = "dbTables";
                //sqlCmd로 SQL 명령문 전달/처리 수행
                sqlCmd.CommandText = "select * from student";
                SqlDataReader sdr = sqlCmd.ExecuteReader();

                sdr.Close();
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            finally
            {
                openFileDialog.ValidateNames = true;
                openFileDialog.FilterIndex = 1;
            }
        }

        private void mnMigration_Click_1(object sender, EventArgs e)
        {
            openFileDialog.FilterIndex = 1; //모든 파일(*.*)
            //이런식으로 쓰면 중괄호 방지 가능
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            // Encoding.Default -> ANSI
            Encoding ec = (mnUTF8.Checked == true) ? Encoding.UTF8: Encoding.Default;
            StreamReader sr = new StreamReader(openFileDialog.FileName, ec, true);
            //filePath = openFileDialog.FileName;
            string firstLine = sr.ReadLine();
            string[] fArr = firstLine.Split(',');
            foreach (string str in fArr)
                dbGrid.Columns.Add(str, str);
            //tbInput.Text = oneline;
            string oneLine = sr.ReadLine();
            int rowIdx = 0;
            while (oneLine != null)
            {
                string[] oArr = oneLine.Split(',');
                dbGrid.Rows.Add(oArr); //array를 입력값으로 받을 수 있음
                oneLine = sr.ReadLine(); rowIdx++;
            }
            sr.Close(); //파일 종료
        }

        private void mnSqlExecute_Click(object sender, EventArgs e)
        {
            if (mnEchoGrid.Checked) RunSql(tbInput.Text);
            else RunSql_noEcho(tbInput.Text);
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                if (mnEchoGrid.Checked) RunSql(tbInput.Text);
                else RunSql_noEcho(tbInput.Text);
            }
            // PopUp menu로 하일라이트된 문장만 실행
            // tbInput.SelectedText;
        }


        private void executeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = tbInput.SelectedText;
            RunSql(sql);
        }


        private void pmndbInsert_Click(object sender, EventArgs e)
        {   // 1. insert into [table] values [value]
            // 2. insert into [Table] (field1, field2,,,) values (val1,val2,,)
            try
            {
                string s1 = "(";
                string s2 = "(";
                for (int i = 0; i < dbGrid.ColumnCount; i++)
                {
                    if (i != 0)
                    {
                        s1 += ","; s2 += ",";
                    }
                    s1 += $"{dbGrid.Columns[i].HeaderText}";
                    s2 += $"'{dbGrid.SelectedRows[0].Cells[i].Value}'";
                }
                s1 += ")"; s2 += ")";

                string sql = $"insert into {currTable} {s1} values {s2}";

                RunSql(sql);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void pmndbUpdate_Click(object sender, EventArgs e)
        { //update facility set field_name = sth where id = 0001
            //선택된 첫번째 셀의 (x, y) 좌표값
            int x = dbGrid.SelectedCells[0].ColumnIndex;
            int y = dbGrid.SelectedCells[0].RowIndex;
            string s1 = dbGrid.Columns[x].HeaderText; //Field 명
            object s2 = dbGrid.SelectedCells[0].Value; //값
            string o1 = dbGrid.Columns[0].HeaderText; //Field 명
            object o2 = dbGrid.Rows[y].Cells[0].Value; //값
            string sq1 = $"update {currTable} set {s1}={s2} where {o1}={o2}";
            RunSql(sq1);
        }

        
        private void pmndbDelete_Click(object sender, EventArgs e)
        {   // DELETE student WHERE code=4 AND name=‘사번’ AND kor=50
            string sql = $"DELETE {currTable} WHERE ";
            try
            {
                for (int i = 0; i < dbGrid.ColumnCount; i++)
                {
                    if (dbGrid.SelectedRows[0].Cells[i].Value == null ||
                       dbGrid.SelectedRows[0].Cells[i].Value.ToString() == "") continue;
                    if (i != 0) sql += " AND ";
                    sql += $"{dbGrid.Columns[i].HeaderText}='{dbGrid.SelectedRows[0].Cells[i].Value}'";
                }
                RunSql(sql);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void mnUTF8_Click(object sender, EventArgs e)
        {
            mnANSI.Checked = false;
            mnUTF8.Checked = true;
        }

        private void mnANSI_Click(object sender, EventArgs e)
        {
            mnUTF8.Checked = false;
            mnANSI.Checked = true;
        }

        private void mnMigImport_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Encoding enc;
                if (mnUTF8.Checked) enc = Encoding.UTF8;
                else enc = Encoding.Default; //ANSI

                byte[] bArrRaw = File.ReadAllBytes(openFileDialog.FileName); // Raw data
                byte[] bArr = Encoding.Convert(enc, Encoding.Default, bArrRaw);
                string str = Encoding.Default.GetString(bArr);
                string[] sArr = str.Split('\n');
                string[] sa1 = sArr[0].Trim().Split(',');
                //클리어
                dbGrid.Rows.Clear(); dbGrid.Columns.Clear();
                for (int i = 0; i < sa1.Length; i++)
                {
                    dbGrid.Columns.Add(sa1[i], sa1[i]);
                }
                for (int k = 1; k < sArr.Length; k++)
                {
                    sa1 = sArr[k].Trim().Split(',');
                    dbGrid.Rows.Add(sa1);
                    //int n = dbGrid.Rows.Add();
                    //for (int i = 0; i < sa1.Length; i++)
                    //{
                    //    dbGrid.Rows[n].Cells[i].Value = sa1[i];
                    //}
                }
            }
        }

        private void pmnDeleteColumn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret = MessageBox.Show("정말요?", "컬럼 삭제", MessageBoxButtons.OKCancel);
                if (ret == DialogResult.OK)
                    dbGrid.Columns.RemoveAt(dbGrid.SelectedCells[0].ColumnIndex);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void pmnDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret = MessageBox.Show("정말요?", "레코드 삭제", MessageBoxButtons.OKCancel);
                if (ret == DialogResult.OK)
                    dbGrid.Rows.Remove(dbGrid.SelectedRows[0]);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void mnMigExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sd.FileName);
                string sbuf = "";
                for (int i = 0; i < dbGrid.ColumnCount; i++)
                {
                    if (i != 0) sbuf += ",";
                    sbuf += dbGrid.Columns[i].HeaderText;
                }
                sw.WriteLine(sbuf);
                for (int k = 0; k < dbGrid.RowCount - 1; k++)
                {
                    sbuf = "";
                    for (int i = 0; i < dbGrid.ColumnCount; i++)
                    {
                        if (i != 0) sbuf += ",";
                        string s1 = "";
                        if (dbGrid.Rows[k].Cells[i].Value != null)
                            s1 = dbGrid.Rows[k].Cells[i].Value.ToString().Trim();
                        sbuf += s1;
                    }
                    sw.WriteLine(sbuf);
                }
                sw.Close();
            }
        }

        private void mnCreateTable_Click(object sender, EventArgs e)
        {
            // create table [Table] ( [field] [type] [not null] ,,, )
            // create table Test_table (Code varchar(10) not null, Name varchar(10),,, ) 
            string s1 = mylib.GetInput("Field Name");
            if (s1 == "") return;

            string sql = $"CREATE TABLE {s1} (";
            for (int i = 0; i < dbGrid.ColumnCount; i++)
            {
                if (i != 0) sql += ",";
                sql += dbGrid.Columns[i].HeaderText;
                sql += " varchar(10) ";
                if (i == 0) sql += " not null ";
            }
            sql += ")";
            RunSql(sql);
            currTable = s1;

            for (int i = 0; i < dbGrid.RowCount; i++)
            {
                Insert_Proc(i);
            }
        }

        public void Insert_Proc(int nRow)
        {   // 1 : insert into [Table] values (value,,,)
            // 2 : insert into [Table] (field1, field2,,,) values (val1,val2,,)
            try
            {
                string s1 = "(";
                string s2 = "(";
                for (int i = 0; i < dbGrid.ColumnCount; i++)
                {
                    if (i != 0)
                    {
                        s1 += ","; s2 += ",";
                    }
                    s1 += $"{dbGrid.Columns[i].HeaderText}";
                    s2 += $"N'{dbGrid.Rows[nRow].Cells[i].Value}'";
                }
                s1 += ")"; s2 += ")";

                string sql = $"insert into {currTable} {s1} values {s2}";

                ////string sql = $"insert into {CurrentTable} (";
                ////for(int i=0;i<dbGrid.ColumnCount;i++)
                ////{
                ////    if (i != 0) sql += ",";
                ////    sql += $"{dbGrid.Columns[i].HeaderText}";
                ////}
                ////sql += ") values (";
                ////for(int i=0;i<dbGrid.ColumnCount;i++)
                ////{
                ////    if (i != 0) sql += ",";
                ////    sql += $"'{dbGrid.SelectedRows[0].Cells[i].Value}'";
                ////}
                ////sql += ")";
                RunSql(sql);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void pmnColumnInfo_Click(object sender, EventArgs e)
        {
            int nCol = dbGrid.SelectedCells[0].ColumnIndex;
            string sCol = dbGrid.Columns[nCol].HeaderText;

            string str = RunSql_noEcho("select Table_name,column_name,data_type,character_maximum_length,is_nullable " +
                          " from information_schema.columns " +
                          $" where column_name = '{sCol}' and table_name='{currTable}'");
            tbInput.Text += str;
        }

        private void mnEchoText_Click(object sender, EventArgs e)
        {
            mnEchoGrid.Checked = false;
        }

        private void mnEchoGrid_Click(object sender, EventArgs e)
        {
            mnEchoText.Checked = false;
        }

        private void pmnAlterColumn_Click(object sender, EventArgs e)
        {   // ALTER TABLE [table] ALTER COLUMN [column] [datatype] [nullable]
            // 신규 폼 생성: 컬럼 type, Max Length, Nullable 생성
            int nCol = dbGrid.SelectedCells[0].ColumnIndex;
            string sCol = dbGrid.Columns[nCol].HeaderText;
            try
            {
                string str = RunSql_noEcho("select Table_name, column_name, data_type, character_maximum_length, is_nullable" +
                " from information_schema.columns " +
                $" where column_name = '{sCol}' and table_name='{currTable}'");
                string[] sInfo = str.Split('\n')[1].Trim().Split(',');
                frmAlterColumn f2 = new frmAlterColumn(sInfo[1], sInfo[2], int.Parse(sInfo[3]));
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    string sql = $"ALTER TABLE {sInfo[0]} ALTER COLUMN {sInfo[1]} {f2.cbColumnType.Text}({f2.tbMaxLength.Text}) {f2.cbNullable.Text}";
                    RunSql(sql);
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            
        }
    }
}
