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
            this.T_ExecuteQuery = new System.Windows.Forms.ToolStripButton();
            this.T_CreateFile = new System.Windows.Forms.ToolStripButton();
            this.QueryPannel = new FastColoredTextBoxNS.FastColoredTextBox();
            this.T_LoadFile = new System.Windows.Forms.ToolStripButton();
            this.T_SaveQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryPannel)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.T_CreateFile,
            this.T_LoadFile,
            this.T_ExecuteQuery,
            this.T_SaveQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(451, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // T_ExecuteQuery
            // 
            this.T_ExecuteQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.T_ExecuteQuery.Image = ((System.Drawing.Image)(resources.GetObject("T_ExecuteQuery.Image")));
            this.T_ExecuteQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.T_ExecuteQuery.Name = "T_ExecuteQuery";
            this.T_ExecuteQuery.Size = new System.Drawing.Size(23, 22);
            this.T_ExecuteQuery.Text = "Run";
            this.T_ExecuteQuery.Click += new System.EventHandler(this.T_ExecuteQuery_Click);
            // 
            // T_CreateFile
            // 
            this.T_CreateFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.T_CreateFile.Image = ((System.Drawing.Image)(resources.GetObject("T_CreateFile.Image")));
            this.T_CreateFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.T_CreateFile.Name = "T_CreateFile";
            this.T_CreateFile.Size = new System.Drawing.Size(23, 22);
            this.T_CreateFile.Text = "Create";
            this.T_CreateFile.Click += new System.EventHandler(this.T_CreateFile_Click);
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
            this.QueryPannel.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.QueryPannel.BackBrush = null;
            this.QueryPannel.CharHeight = 14;
            this.QueryPannel.CharWidth = 8;
            this.QueryPannel.CommentPrefix = "--";
            this.QueryPannel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QueryPannel.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.QueryPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryPannel.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.QueryPannel.IsReplaceMode = false;
            this.QueryPannel.Language = FastColoredTextBoxNS.Language.SQL;
            this.QueryPannel.LeftBracket = '(';
            this.QueryPannel.Location = new System.Drawing.Point(0, 25);
            this.QueryPannel.Name = "QueryPannel";
            this.QueryPannel.Paddings = new System.Windows.Forms.Padding(0);
            this.QueryPannel.RightBracket = ')';
            this.QueryPannel.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.QueryPannel.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("QueryPannel.ServiceColors")));
            this.QueryPannel.Size = new System.Drawing.Size(451, 195);
            this.QueryPannel.TabIndex = 1;
            this.QueryPannel.Zoom = 100;
            // 
            // T_LoadFile
            // 
            this.T_LoadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.T_LoadFile.Image = ((System.Drawing.Image)(resources.GetObject("T_LoadFile.Image")));
            this.T_LoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.T_LoadFile.Name = "T_LoadFile";
            this.T_LoadFile.Size = new System.Drawing.Size(23, 22);
            this.T_LoadFile.Text = "Open";
            // 
            // T_SaveQuery
            // 
            this.T_SaveQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.T_SaveQuery.Image = ((System.Drawing.Image)(resources.GetObject("T_SaveQuery.Image")));
            this.T_SaveQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.T_SaveQuery.Name = "T_SaveQuery";
            this.T_SaveQuery.Size = new System.Drawing.Size(23, 22);
            this.T_SaveQuery.Text = "Save Query";
            this.T_SaveQuery.Click += new System.EventHandler(this.T_SaveQuery_Click);
            // 
            // SqlManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QueryPannel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SqlManager";
            this.Size = new System.Drawing.Size(451, 220);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryPannel)).EndInit();
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
    }
}
