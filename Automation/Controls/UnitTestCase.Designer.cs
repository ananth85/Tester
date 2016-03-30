namespace Automation.Controls
{
    partial class UnitTestCase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitTestCase));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ParenttabControl = new System.Windows.Forms.TabControl();
            this.TabAuto = new System.Windows.Forms.TabPage();
            this.StepGenerator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.TabManual = new System.Windows.Forms.TabPage();
            this.TabGroup = new System.Windows.Forms.TabPage();
            this.sqlManager1 = new Automation.Controls.SqlManager();
            this.tableLayoutPanel1.SuspendLayout();
            this.ParenttabControl.SuspendLayout();
            this.TabAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepGenerator)).BeginInit();
            this.TabGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ParenttabControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(989, 363);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ParenttabControl
            // 
            this.ParenttabControl.Controls.Add(this.TabAuto);
            this.ParenttabControl.Controls.Add(this.TabManual);
            this.ParenttabControl.Controls.Add(this.TabGroup);
            this.ParenttabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParenttabControl.Location = new System.Drawing.Point(3, 63);
            this.ParenttabControl.Name = "ParenttabControl";
            this.ParenttabControl.SelectedIndex = 0;
            this.ParenttabControl.Size = new System.Drawing.Size(983, 297);
            this.ParenttabControl.TabIndex = 0;
            // 
            // TabAuto
            // 
            this.TabAuto.Controls.Add(this.StepGenerator);
            this.TabAuto.Location = new System.Drawing.Point(4, 22);
            this.TabAuto.Name = "TabAuto";
            this.TabAuto.Padding = new System.Windows.Forms.Padding(3);
            this.TabAuto.Size = new System.Drawing.Size(975, 271);
            this.TabAuto.TabIndex = 0;
            this.TabAuto.Text = "Auto";
            this.TabAuto.UseVisualStyleBackColor = true;
            // 
            // StepGenerator
            // 
            this.StepGenerator.AutoCompleteBracketsList = new char[] {
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
            this.StepGenerator.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.StepGenerator.BackBrush = null;
            this.StepGenerator.CharHeight = 14;
            this.StepGenerator.CharWidth = 8;
            this.StepGenerator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StepGenerator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.StepGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StepGenerator.IsReplaceMode = false;
            this.StepGenerator.Location = new System.Drawing.Point(3, 3);
            this.StepGenerator.Name = "StepGenerator";
            this.StepGenerator.Paddings = new System.Windows.Forms.Padding(0);
            this.StepGenerator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.StepGenerator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("StepGenerator.ServiceColors")));
            this.StepGenerator.Size = new System.Drawing.Size(969, 265);
            this.StepGenerator.TabIndex = 0;
            this.StepGenerator.Zoom = 100;
            this.StepGenerator.Load += new System.EventHandler(this.StepGenerator_Load);
            this.StepGenerator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StepGenerator_KeyDown);
            // 
            // TabManual
            // 
            this.TabManual.Location = new System.Drawing.Point(4, 22);
            this.TabManual.Name = "TabManual";
            this.TabManual.Padding = new System.Windows.Forms.Padding(3);
            this.TabManual.Size = new System.Drawing.Size(975, 271);
            this.TabManual.TabIndex = 1;
            this.TabManual.Text = "TabManual";
            this.TabManual.UseVisualStyleBackColor = true;
            // 
            // TabGroup
            // 
            this.TabGroup.Controls.Add(this.sqlManager1);
            this.TabGroup.Location = new System.Drawing.Point(4, 22);
            this.TabGroup.Name = "TabGroup";
            this.TabGroup.Padding = new System.Windows.Forms.Padding(3);
            this.TabGroup.Size = new System.Drawing.Size(975, 271);
            this.TabGroup.TabIndex = 2;
            this.TabGroup.Text = "Group";
            this.TabGroup.UseVisualStyleBackColor = true;
            // 
            // sqlManager1
            // 
            this.sqlManager1.DBFilePath = null;
            this.sqlManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlManager1.Location = new System.Drawing.Point(3, 3);
            this.sqlManager1.Name = "sqlManager1";
            this.sqlManager1.Size = new System.Drawing.Size(969, 265);
            this.sqlManager1.TabIndex = 0;
            // 
            // UnitTestCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UnitTestCase";
            this.Size = new System.Drawing.Size(989, 363);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ParenttabControl.ResumeLayout(false);
            this.TabAuto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StepGenerator)).EndInit();
            this.TabGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl ParenttabControl;
        private System.Windows.Forms.TabPage TabAuto;
        private FastColoredTextBoxNS.FastColoredTextBox StepGenerator;
        private System.Windows.Forms.TabPage TabManual;
        private System.Windows.Forms.TabPage TabGroup;
        private SqlManager sqlManager1;
    }
}
