
namespace myDB
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGO = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAddColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPopUp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pmnAddColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.pmnAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPopUp2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.text1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.migrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.mnMain.SuspendLayout();
            this.mnPopUp.SuspendLayout();
            this.mnPopUp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGrid
            // 
            this.dbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.ContextMenuStrip = this.mnPopUp;
            this.dbGrid.Location = new System.Drawing.Point(0, 98);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.RowHeadersWidth = 51;
            this.dbGrid.RowTemplate.Height = 27;
            this.dbGrid.Size = new System.Drawing.Size(800, 250);
            this.dbGrid.TabIndex = 0;
            // 
            // mnMain
            // 
            this.mnMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(800, 28);
            this.mnMain.TabIndex = 1;
            this.mnMain.Text = "mainMenu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.migrationToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.newToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(401, 46);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 2;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // tbInput
            // 
            this.tbInput.ContextMenuStrip = this.mnPopUp2;
            this.tbInput.Location = new System.Drawing.Point(26, 44);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(369, 25);
            this.tbInput.TabIndex = 3;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAddColumn,
            this.mnAddRow});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnAddColumn
            // 
            this.mnAddColumn.Name = "mnAddColumn";
            this.mnAddColumn.Size = new System.Drawing.Size(224, 26);
            this.mnAddColumn.Text = "Add Column";
            this.mnAddColumn.Click += new System.EventHandler(this.mnAddColumn_Click);
            // 
            // mnAddRow
            // 
            this.mnAddRow.Name = "mnAddRow";
            this.mnAddRow.Size = new System.Drawing.Size(224, 26);
            this.mnAddRow.Text = "Add Row";
            this.mnAddRow.Click += new System.EventHandler(this.mnAddRow_Click);
            // 
            // mnPopUp
            // 
            this.mnPopUp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnPopUp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pmnAddColumn,
            this.pmnAddRow});
            this.mnPopUp.Name = "mnPopUp";
            this.mnPopUp.Size = new System.Drawing.Size(166, 52);
            // 
            // pmnAddColumn
            // 
            this.pmnAddColumn.Name = "pmnAddColumn";
            this.pmnAddColumn.Size = new System.Drawing.Size(165, 24);
            this.pmnAddColumn.Text = "Add Column";
            this.pmnAddColumn.Click += new System.EventHandler(this.pmnAddColumn_Click);
            // 
            // pmnAddRow
            // 
            this.pmnAddRow.Name = "pmnAddRow";
            this.pmnAddRow.Size = new System.Drawing.Size(165, 24);
            this.pmnAddRow.Text = "Add Row";
            this.pmnAddRow.Click += new System.EventHandler(this.pmnAddRow_Click);
            // 
            // mnPopUp2
            // 
            this.mnPopUp2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnPopUp2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.text1ToolStripMenuItem,
            this.text2ToolStripMenuItem});
            this.mnPopUp2.Name = "mnPopUp2";
            this.mnPopUp2.Size = new System.Drawing.Size(115, 52);
            // 
            // text1ToolStripMenuItem
            // 
            this.text1ToolStripMenuItem.Name = "text1ToolStripMenuItem";
            this.text1ToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.text1ToolStripMenuItem.Text = "Text1";
            // 
            // text2ToolStripMenuItem
            // 
            this.text2ToolStripMenuItem.Name = "text2ToolStripMenuItem";
            this.text2ToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.text2ToolStripMenuItem.Text = "Text2";
            // 
            // migrationToolStripMenuItem
            // 
            this.migrationToolStripMenuItem.Name = "migrationToolStripMenuItem";
            this.migrationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.migrationToolStripMenuItem.Text = "Migration";
            this.migrationToolStripMenuItem.Click += new System.EventHandler(this.migrationToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.dbGrid);
            this.Controls.Add(this.mnMain);
            this.MainMenuStrip = this.mnMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.mnPopUp.ResumeLayout(false);
            this.mnPopUp2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnAddColumn;
        private System.Windows.Forms.ToolStripMenuItem mnAddRow;
        private System.Windows.Forms.ContextMenuStrip mnPopUp;
        private System.Windows.Forms.ToolStripMenuItem pmnAddColumn;
        private System.Windows.Forms.ToolStripMenuItem pmnAddRow;
        private System.Windows.Forms.ContextMenuStrip mnPopUp2;
        private System.Windows.Forms.ToolStripMenuItem text1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem migrationToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

