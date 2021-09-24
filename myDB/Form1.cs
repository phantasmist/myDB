using myLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void migrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///
            /// 1. csv 파일 열기
            /// 2. column 생성
            /// 3. 한줄씩 Grid에 출력..
            /// 

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
            while(oneLine != null)
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
    }
}
