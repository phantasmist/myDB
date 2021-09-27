
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
            this.mnPopUp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pmnAddColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.pmnAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAddColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.mnPopUp2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.text1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenF = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMigration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sbLabel2 = new System.Windows.Forms.ToolStripDropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.mnPopUp.SuspendLayout();
            this.mnMain.SuspendLayout();
            this.mnPopUp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGrid
            // 
            this.dbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.ContextMenuStrip = this.mnPopUp;
            this.dbGrid.Location = new System.Drawing.Point(3, 3);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.RowHeadersWidth = 51;
            this.dbGrid.RowTemplate.Height = 27;
            this.dbGrid.Size = new System.Drawing.Size(722, 191);
            this.dbGrid.TabIndex = 0;
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
            // mnMain
            // 
            this.mnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mnMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mnMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(103, 28);
            this.mnMain.TabIndex = 1;
            this.mnMain.Text = "mainMenu";
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
            this.mnAddColumn.Size = new System.Drawing.Size(179, 26);
            this.mnAddColumn.Text = "Add Column";
            this.mnAddColumn.Click += new System.EventHandler(this.mnAddColumn_Click);
            // 
            // mnAddRow
            // 
            this.mnAddRow.Name = "mnAddRow";
            this.mnAddRow.Size = new System.Drawing.Size(179, 26);
            this.mnAddRow.Text = "Add Row";
            this.mnAddRow.Click += new System.EventHandler(this.mnAddRow_Click);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.ContextMenuStrip = this.mnPopUp2;
            this.tbInput.Location = new System.Drawing.Point(3, 3);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(722, 178);
            this.tbInput.TabIndex = 3;
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
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
            this.splitContainer1.Size = new System.Drawing.Size(728, 407);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1,
            this.sbLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 193);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(728, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(68, 20);
            this.sbLabel1.Text = "sbLabel1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNew,
            this.mnOpenF,
            this.mnMigration,
            this.mnSave,
            this.mnSaveAs,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnNew
            // 
            this.mnNew.Name = "mnNew";
            this.mnNew.Size = new System.Drawing.Size(224, 26);
            this.mnNew.Text = "New";
            // 
            // mnOpenF
            // 
            this.mnOpenF.Name = "mnOpenF";
            this.mnOpenF.Size = new System.Drawing.Size(224, 26);
            this.mnOpenF.Text = "Open";
            this.mnOpenF.Click += new System.EventHandler(this.mnOpenF_Click);
            // 
            // mnMigration
            // 
            this.mnMigration.Name = "mnMigration";
            this.mnMigration.Size = new System.Drawing.Size(224, 26);
            this.mnMigration.Text = "Migration";
            this.mnMigration.Click += new System.EventHandler(this.mnMigration_Click);
            // 
            // mnSave
            // 
            this.mnSave.Name = "mnSave";
            this.mnSave.Size = new System.Drawing.Size(224, 26);
            this.mnSave.Text = "Save";
            // 
            // mnSaveAs
            // 
            this.mnSaveAs.Name = "mnSaveAs";
            this.mnSaveAs.Size = new System.Drawing.Size(224, 26);
            this.mnSaveAs.Text = "Save As ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 439);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mnMain);
            this.MainMenuStrip = this.mnMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.mnPopUp.ResumeLayout(false);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.mnPopUp2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.MenuStrip mnMain;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnNew;
        private System.Windows.Forms.ToolStripMenuItem mnOpenF;
        private System.Windows.Forms.ToolStripMenuItem mnMigration;
        private System.Windows.Forms.ToolStripMenuItem mnSave;
        private System.Windows.Forms.ToolStripMenuItem mnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton sbLabel2;
    }
}

