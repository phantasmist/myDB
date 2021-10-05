
namespace myDB
{
    partial class frmDBManager
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
            this.mnPopUpGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pmndbUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.pmndbInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.pmndbDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.pmnColumnInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pmnDeleteColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.pmnDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.pmnAlterColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.mnPopUpSQL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnOpenF = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMigration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMigImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMigExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateTable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnCreateTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAddColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSqlExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnANSI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUTF8 = new System.Windows.Forms.ToolStripMenuItem();
            this.echoGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEchoText = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEchoGrid = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.mnPopUpGrid.SuspendLayout();
            this.mnPopUpSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGrid
            // 
            this.dbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.ContextMenuStrip = this.mnPopUpGrid;
            this.dbGrid.Location = new System.Drawing.Point(0, 4);
            this.dbGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.RowHeadersWidth = 51;
            this.dbGrid.RowTemplate.Height = 27;
            this.dbGrid.Size = new System.Drawing.Size(765, 203);
            this.dbGrid.TabIndex = 0;
            // 
            // mnPopUpGrid
            // 
            this.mnPopUpGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnPopUpGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.pmndbUpdate,
            this.pmndbInsert,
            this.pmndbDelete,
            this.toolStripSeparator5,
            this.pmnColumnInfo,
            this.addRowToolStripMenuItem,
            this.addColumnToolStripMenuItem,
            this.toolStripSeparator4,
            this.pmnDeleteColumn,
            this.pmnDeleteRow,
            this.pmnAlterColumn});
            this.mnPopUpGrid.Name = "mnPopUp";
            this.mnPopUpGrid.Size = new System.Drawing.Size(182, 238);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // pmndbUpdate
            // 
            this.pmndbUpdate.Name = "pmndbUpdate";
            this.pmndbUpdate.Size = new System.Drawing.Size(181, 24);
            this.pmndbUpdate.Text = "DB Update";
            this.pmndbUpdate.Click += new System.EventHandler(this.pmndbUpdate_Click);
            // 
            // pmndbInsert
            // 
            this.pmndbInsert.Name = "pmndbInsert";
            this.pmndbInsert.Size = new System.Drawing.Size(181, 24);
            this.pmndbInsert.Text = "DB Insert";
            this.pmndbInsert.Click += new System.EventHandler(this.pmndbInsert_Click);
            // 
            // pmndbDelete
            // 
            this.pmndbDelete.Name = "pmndbDelete";
            this.pmndbDelete.Size = new System.Drawing.Size(181, 24);
            this.pmndbDelete.Text = "Delete Record";
            this.pmndbDelete.Click += new System.EventHandler(this.pmndbDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(178, 6);
            // 
            // pmnColumnInfo
            // 
            this.pmnColumnInfo.Name = "pmnColumnInfo";
            this.pmnColumnInfo.Size = new System.Drawing.Size(181, 24);
            this.pmnColumnInfo.Text = "Column Info";
            this.pmnColumnInfo.Click += new System.EventHandler(this.pmnColumnInfo_Click);
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.addRowToolStripMenuItem.Text = "Add Row";
            // 
            // addColumnToolStripMenuItem
            // 
            this.addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            this.addColumnToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.addColumnToolStripMenuItem.Text = "Add Column";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // pmnDeleteColumn
            // 
            this.pmnDeleteColumn.Name = "pmnDeleteColumn";
            this.pmnDeleteColumn.Size = new System.Drawing.Size(181, 24);
            this.pmnDeleteColumn.Text = "Delete Column";
            this.pmnDeleteColumn.Click += new System.EventHandler(this.pmnDeleteColumn_Click);
            // 
            // pmnDeleteRow
            // 
            this.pmnDeleteRow.Name = "pmnDeleteRow";
            this.pmnDeleteRow.Size = new System.Drawing.Size(181, 24);
            this.pmnDeleteRow.Text = "Delete Row";
            this.pmnDeleteRow.Click += new System.EventHandler(this.pmnDeleteRow_Click);
            // 
            // pmnAlterColumn
            // 
            this.pmnAlterColumn.Name = "pmnAlterColumn";
            this.pmnAlterColumn.Size = new System.Drawing.Size(181, 24);
            this.pmnAlterColumn.Text = "Alter Column";
            this.pmnAlterColumn.Click += new System.EventHandler(this.pmnAlterColumn_Click);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.ContextMenuStrip = this.mnPopUpSQL;
            this.tbInput.Location = new System.Drawing.Point(0, 0);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(772, 117);
            this.tbInput.TabIndex = 3;
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // mnPopUpSQL
            // 
            this.mnPopUpSQL.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnPopUpSQL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeSelectedToolStripMenuItem});
            this.mnPopUpSQL.Name = "mnPopUp2";
            this.mnPopUpSQL.Size = new System.Drawing.Size(131, 28);
            // 
            // executeSelectedToolStripMenuItem
            // 
            this.executeSelectedToolStripMenuItem.Name = "executeSelectedToolStripMenuItem";
            this.executeSelectedToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.executeSelectedToolStripMenuItem.Text = "Execute";
            this.executeSelectedToolStripMenuItem.Click += new System.EventHandler(this.executeSelectedToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "모든파일|*.*|DB파일|*.mdf";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 45);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dbGrid);
            this.splitContainer1.Size = new System.Drawing.Size(773, 377);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1,
            this.sbLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 222);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(773, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(68, 20);
            this.sbLabel1.Text = "sbLabel1";
            // 
            // sbLabel2
            // 
            this.sbLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbLabel2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbLabel2.Name = "sbLabel2";
            this.sbLabel2.Size = new System.Drawing.Size(82, 24);
            this.sbLabel2.Text = "sbLabel2";
            this.sbLabel2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sbLabel2.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.sbLabel2_DropDownItemClicked);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.configToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.mainMenu.Size = new System.Drawing.Size(774, 30);
            this.mainMenu.TabIndex = 5;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNew,
            this.toolStripSeparator2,
            this.mnOpenF,
            this.mnMigration,
            this.mnUpdateTable,
            this.toolStripSeparator1,
            this.mnCreateTable,
            this.mnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnNew
            // 
            this.mnNew.Name = "mnNew";
            this.mnNew.Size = new System.Drawing.Size(192, 26);
            this.mnNew.Text = "New";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // mnOpenF
            // 
            this.mnOpenF.Name = "mnOpenF";
            this.mnOpenF.Size = new System.Drawing.Size(192, 26);
            this.mnOpenF.Text = "Open";
            this.mnOpenF.Click += new System.EventHandler(this.mnOpenF_Click_1);
            // 
            // mnMigration
            // 
            this.mnMigration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMigImport,
            this.mnMigExport});
            this.mnMigration.Name = "mnMigration";
            this.mnMigration.Size = new System.Drawing.Size(192, 26);
            this.mnMigration.Text = "Migration(.csv)";
            this.mnMigration.Click += new System.EventHandler(this.mnMigration_Click_1);
            // 
            // mnMigImport
            // 
            this.mnMigImport.Name = "mnMigImport";
            this.mnMigImport.Size = new System.Drawing.Size(137, 26);
            this.mnMigImport.Text = "Import";
            this.mnMigImport.Click += new System.EventHandler(this.mnMigImport_Click);
            // 
            // mnMigExport
            // 
            this.mnMigExport.Name = "mnMigExport";
            this.mnMigExport.Size = new System.Drawing.Size(137, 26);
            this.mnMigExport.Text = "Export";
            this.mnMigExport.Click += new System.EventHandler(this.mnMigExport_Click);
            // 
            // mnUpdateTable
            // 
            this.mnUpdateTable.Name = "mnUpdateTable";
            this.mnUpdateTable.Size = new System.Drawing.Size(192, 26);
            this.mnUpdateTable.Text = "Update Table";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // mnCreateTable
            // 
            this.mnCreateTable.Name = "mnCreateTable";
            this.mnCreateTable.Size = new System.Drawing.Size(192, 26);
            this.mnCreateTable.Text = "Create Table";
            this.mnCreateTable.Click += new System.EventHandler(this.mnCreateTable_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(192, 26);
            this.mnExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAddRow,
            this.mnAddColumn});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnAddRow
            // 
            this.mnAddRow.Name = "mnAddRow";
            this.mnAddRow.Size = new System.Drawing.Size(179, 26);
            this.mnAddRow.Text = "Add Row";
            this.mnAddRow.Click += new System.EventHandler(this.mnAddRow_Click_1);
            // 
            // mnAddColumn
            // 
            this.mnAddColumn.Name = "mnAddColumn";
            this.mnAddColumn.Size = new System.Drawing.Size(179, 26);
            this.mnAddColumn.Text = "Add Column";
            this.mnAddColumn.Click += new System.EventHandler(this.mnAddColumn_Click_1);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSqlExecute});
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.sQLToolStripMenuItem.Text = "SQL";
            // 
            // mnSqlExecute
            // 
            this.mnSqlExecute.Name = "mnSqlExecute";
            this.mnSqlExecute.Size = new System.Drawing.Size(144, 26);
            this.mnSqlExecute.Text = "Execute";
            this.mnSqlExecute.Click += new System.EventHandler(this.mnSqlExecute_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFileToolStripMenuItem,
            this.echoGridToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnANSI,
            this.mnUTF8});
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.textFileToolStripMenuItem.Text = "Text Encoding";
            // 
            // mnANSI
            // 
            this.mnANSI.Name = "mnANSI";
            this.mnANSI.Size = new System.Drawing.Size(132, 26);
            this.mnANSI.Text = "ANSI";
            this.mnANSI.Click += new System.EventHandler(this.mnANSI_Click);
            // 
            // mnUTF8
            // 
            this.mnUTF8.Checked = true;
            this.mnUTF8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnUTF8.Name = "mnUTF8";
            this.mnUTF8.Size = new System.Drawing.Size(132, 26);
            this.mnUTF8.Text = "UTF-8";
            this.mnUTF8.Click += new System.EventHandler(this.mnUTF8_Click);
            // 
            // echoGridToolStripMenuItem
            // 
            this.echoGridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEchoText,
            this.mnEchoGrid});
            this.echoGridToolStripMenuItem.Name = "echoGridToolStripMenuItem";
            this.echoGridToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.echoGridToolStripMenuItem.Text = "Echo Grid";
            // 
            // mnEchoText
            // 
            this.mnEchoText.CheckOnClick = true;
            this.mnEchoText.Name = "mnEchoText";
            this.mnEchoText.Size = new System.Drawing.Size(121, 26);
            this.mnEchoText.Text = "Text";
            this.mnEchoText.Click += new System.EventHandler(this.mnEchoText_Click);
            // 
            // mnEchoGrid
            // 
            this.mnEchoGrid.Checked = true;
            this.mnEchoGrid.CheckOnClick = true;
            this.mnEchoGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnEchoGrid.Name = "mnEchoGrid";
            this.mnEchoGrid.Size = new System.Drawing.Size(121, 26);
            this.mnEchoGrid.Text = "Grid";
            this.mnEchoGrid.Click += new System.EventHandler(this.mnEchoGrid_Click);
            // 
            // frmDBManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 424);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDBManager";
            this.Text = "DB Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.mnPopUpGrid.ResumeLayout(false);
            this.mnPopUpSQL.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ContextMenuStrip mnPopUpGrid;
        private System.Windows.Forms.ContextMenuStrip mnPopUpSQL;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.ToolStripDropDownButton sbLabel2;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnNew;
        private System.Windows.Forms.ToolStripMenuItem mnOpenF;
        private System.Windows.Forms.ToolStripMenuItem mnMigration;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateTable;
        private System.Windows.Forms.ToolStripMenuItem mnCreateTable;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSqlExecute;
        private System.Windows.Forms.ToolStripMenuItem executeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pmndbUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnAddRow;
        private System.Windows.Forms.ToolStripMenuItem mnAddColumn;
        private System.Windows.Forms.ToolStripMenuItem pmndbInsert;
        private System.Windows.Forms.ToolStripMenuItem pmndbDelete;
        private System.Windows.Forms.ToolStripMenuItem mnMigImport;
        private System.Windows.Forms.ToolStripMenuItem mnMigExport;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnANSI;
        private System.Windows.Forms.ToolStripMenuItem mnUTF8;
        private System.Windows.Forms.ToolStripMenuItem pmnDeleteColumn;
        private System.Windows.Forms.ToolStripMenuItem pmnDeleteRow;
        private System.Windows.Forms.ToolStripMenuItem pmnColumnInfo;
        private System.Windows.Forms.ToolStripMenuItem echoGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnEchoText;
        private System.Windows.Forms.ToolStripMenuItem mnEchoGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem pmnAlterColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

