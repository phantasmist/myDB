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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            dbGrid.Columns.Add(tbInput.Text, tbInput.Text);
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

        char[] wsArr = { ' ', '\t', '\r', '\n' }; //white space array
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
                    string s1 = sql.Substring(n1 + 4).Trim(); //from의 위치 + 4
                    currTable = s1.Split(wsArr)[0];
                    sbLabel2.Text = currTable;
                    

                    //sql.ToLower().
                    SqlDataReader sdr = sqlCmd.ExecuteReader(); //모든 명령어 처리는 불가능함

                    //컬럼 세팅
                    dbGrid.Rows.Clear();
                    dbGrid.Columns.Clear();
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
                return 1;
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
                //sbLabel2.Text = dt.TableName;
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
            //요걸로 중괄호를 방지할 수 있다
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            //StreamReader에 인코딩 박아줘야됨
            StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.Default, true); //new 생성자 호출
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
            string sql = tbInput.Text;
            RunSql(sql);
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            // shift + enter의 조건을 잘 볼 것
            if (e.Shift && e.KeyCode == Keys.Enter)
                mnSqlExecute_Click(sender, e);
            // PopUp menu로 하일라이트된 문장만 실행
            // tbInput.SelectedText;
        }


        private void executeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = tbInput.SelectedText;
            RunSql(sql);
        }


        private void pmndbInsert_Click(object sender, EventArgs e)
        {

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


        
        //add rows, columns 를 
        // insert into table values 000003 


    }
}
