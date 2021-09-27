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

        private void mnMigration_Click(object sender, EventArgs e)
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

                //for (int i = 0; i < oArr.Length; i++)
                //    dbGrid.Rows[rowIdx].Cells[i].Value = oArr[i];

                oneLine = sr.ReadLine(); rowIdx++;
            }

            //dbGrid.Rows.RemoveAt(j-1);

            //dbGrid.Rows[1].Cells[5].Value = ""; //아무 값이나 대입 가능
            //dbGrid.Rows[1].Cells[5].Value.ToString(); //Object 타입이라 형변환 해야지 반환 가능
            sr.Close(); //파일 종료
        }

        // C# 신기능:
        // \r과 같은 esc sequence를 무시하는 경로문자열: @""  보간문자열: $""
        SqlConnection sqlConn = new SqlConnection(); // app - db connection
        SqlCommand sqlCmd = new SqlCommand(); // 위 커넥션 기반으로 명령어 전달
        string ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phantasmist\source\repos\myDataBase.mdf;Integrated Security=True;Connect Timeout=30";

        private void mnOpenF_Click(object sender, EventArgs e)
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
                ////컬럼 세팅
                //dbGrid.Rows.Clear();
                //dbGrid.Columns.Clear();
                //for (int i = 0; i < sdr.FieldCount; i++)
                //{
                //    string s = sdr.GetName(i); //get name of ith field
                //    dbGrid.Columns.Add(s, s);
                //}
                ////라인단위 처리
                //for (int i = 0; sdr.Read(); i++)
                //{
                //    int rIdx = dbGrid.Rows.Add(); //한줄 추가 + Row 번호 int로 반환
                //    for (int j = 0; j < sdr.FieldCount; j++)
                //    {
                //        object obj = sdr.GetValue(j);
                //        dbGrid.Rows[rIdx].Cells[j].Value = obj;
                //    }
                //}
                sdr.Close();
            }

            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            finally
            {
                openFileDialog.ValidateNames = true;
                openFileDialog.FilterIndex = 1;
            }

        }

        private void sbLabel2_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            sbLabel2.Text = e.ClickedItem.Text; //
        }
    }
}
