using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myDB
{
    public partial class frmAlterColumn : Form
    {
        string colName, strDT;
        int maxSize;
        public frmAlterColumn(string cName, string str="", int size = 10)
        {
            InitializeComponent();
            colName = cName;
            strDT = str;
            maxSize = size;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //this.DialogResult.OK = true;
            //varchar(10) : ASCII(7bit) since MSB is 0 영어, 숫자
            //nvarchar(10) : unicode(2byte char) dynamic size 
            //nchar(10) : fixed size: 홍길동...... 처럼  .이 공간을 차지함
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //DialogResult.Cancel = true;
        }

        private void frmAlterColumn_Load(object sender, EventArgs e)
        {   // 여기서 콤보박스 설정해도 됨
            //cbColumnType.Items.Add("");
        }
    }
}
