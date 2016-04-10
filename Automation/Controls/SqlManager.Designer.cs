namespace Automation.Controls
{
    partial class SqlManager
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.T_CreateFile = new System.Windows.Forms.ToolStripButton();
            this.T_LoadFile = new System.Windows.Forms.ToolStripButton();
            this.T_ExecuteQuery = new System.Windows.Forms.ToolStripButton();
            this.T_SaveQuery = new System.Windows.Forms.ToolStripButton();
            this.QueryPannel = new FastColoredTextBoxNS.FastColoredTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatabaseStructure = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ResultGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryPannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.T_CreateFile,
            this.T_LoadFile,
            this.T_ExecuteQuery,
            this.T_SaveQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // T_CreateFile
            // 
            this.T_CreateFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.T_CreateFile.Image = ((System.Drawing.Image)(resources.GetObject("T_CreateFile.Image")));
            this.T_CreateFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.T_CreateFile.Name = "T_CreateFile";
            this.T_CreateFile.Size = new System.Drawing.Size(24, 24);
            this.T_CreateFile.Text = "Create";
            this.T_CreateFile.Click += new System.EventHandler(this.T_CreateFile_Click);
            // 
            // T_LoadFile
            // 
            this.T_LoadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.T_LoadFile.Image = ((System.Drawing.Image)(resources.GetObject("T_LoadFile.Image")));
            this.T_LoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.T_LoadFile.Name = "T_LoadFile";
            this.T_LoadFile.Size = new System.Drawing.Size(24, 24);
            this.T_LoadFile.Text = "Open";
            this.T_LoadFile.Click += new System.EventHandler(this.T_LoadFile_Click);
            // 
            // T_ExecuteQuery
            // 
            this.T_ExecuteQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.T_ExecuteQuery.Image = ((System.Drawing.Image)(resources.GetObject("T_ExecuteQuery.Image")));
            this.T_ExecuteQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.T_ExecuteQuery.Name = "T_ExecuteQuery";
            this.T_ExecuteQuery.Size = new System.Drawing.Size(24, 24);
            this.T_ExecuteQuery.Text = "Run";
            this.T_ExecuteQuery.Click += new System.EventHandler(this.T_ExecuteQuery_Click);
            // 
            // T_SaveQuery
            // 
            this.T_SaveQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.T_SaveQuery.Image = ((System.Drawing.Image)(resources.GetObject("T_SaveQuery.Image")));
            this.T_SaveQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.T_SaveQuery.Name = "T_SaveQuery";
            this.T_SaveQuery.Size = new System.Drawing.Size(24, 24);
            this.T_SaveQuery.Text = "Save Query";
            this.T_SaveQuery.Click += new System.EventHandler(this.T_SaveQuery_Click);
            // 
            // QueryPannel
            // 
            this.QueryPannel.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.QueryPannel.AutoIndentCharsPatterns = "";
            this.QueryPannel.AutoScrollMinSize = new System.Drawing.Size(35, 22);
            this.QueryPannel.BackBrush = null;
            this.QueryPannel.CharHeight = 22;
            this.QueryPannel.CharWidth = 12;
            this.QueryPannel.CommentPrefix = "--";
            this.QueryPannel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QueryPannel.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.QueryPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryPannel.IsReplaceMode = false;
            this.QueryPannel.Language = FastColoredTextBoxNS.Language.SQL;
            this.QueryPannel.LeftBracket = '(';
            this.QueryPannel.Location = new System.Drawing.Point(0, 0);
            this.QueryPannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QueryPannel.Name = "QueryPannel";
            this.QueryPannel.Paddings = new System.Windows.Forms.Padding(0);
            this.QueryPannel.RightBracket = ')';
            this.QueryPannel.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.QueryPannel.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("QueryPannel.ServiceColors")));
            this.QueryPannel.Size = new System.Drawing.Size(447, 157);
            this.QueryPannel.TabIndex = 1;
            this.QueryPannel.Zoom = 100;
            this.QueryPannel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QueryPannel_KeyDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatabaseStructure);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(676, 312);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // DatabaseStructure
            // 
            this.DatabaseStructure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseStructure.ImageIndex = 0;
            this.DatabaseStructure.ImageList = this.imageList1;
            this.DatabaseStructure.Location = new System.Drawing.Point(0, 0);
            this.DatabaseStructure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatabaseStructure.Name = "DatabaseStructure";
            this.DatabaseStructure.SelectedImageIndex = 0;
            this.DatabaseStructure.Size = new System.Drawing.Size(223, 312);
            this.DatabaseStructure.TabIndex = 0;
            this.DatabaseStructure.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DatabaseStructure_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cloud-2-16.png");
            this.imageList1.Images.SetKeyName(1, "full-folder-16.png");
            this.imageList1.Images.SetKeyName(2, "grid-black-32.png");
            this.imageList1.Images.SetKeyName(3, "Grid-view-32.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.QueryPannel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ResultGridView);
            this.splitContainer2.Size = new System.Drawing.Size(447, 312);
            this.splitContainer2.SplitterDistance = 157;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // ResultGridView
            // 
            this.ResultGridView.AllowUserToAddRows = false;
            this.ResultGridView.AllowUserToOrderColumns = true;
            this.ResultGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultGridView.Location = new System.Drawing.Point(0, 0);
            this.ResultGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultGridView.Name = "ResultGridView";
            this.ResultGridView.ReadOnly = true;
            this.ResultGridView.Size = new System.Drawing.Size(447, 149);
            this.ResultGridView.TabIndex = 0;
            // 
            // SqlManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SqlManager";
            this.Size = new System.Drawing.Size(676, 339);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryPannel)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton T_ExecuteQuery;
        private System.Windows.Forms.ToolStripButton T_CreateFile;
        private FastColoredTextBoxNS.FastColoredTextBox QueryPannel;
        private System.Windows.Forms.ToolStripButton T_LoadFile;
        private System.Windows.Forms.ToolStripButton T_SaveQuery;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView DatabaseStructure;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView ResultGridView;
        private System.Windows.Forms.ImageList imageList1;
    }
}
