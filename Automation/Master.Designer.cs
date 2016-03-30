namespace Automation
{
    partial class Master
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.unitTestCase1 = new Automation.Controls.UnitTestCase();
            this.SuspendLayout();
            // 
            // unitTestCase1
            // 
            this.unitTestCase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitTestCase1.Location = new System.Drawing.Point(0, 0);
            this.unitTestCase1.Name = "unitTestCase1";
            this.unitTestCase1.Size = new System.Drawing.Size(809, 400);
            this.unitTestCase1.TabIndex = 0;
            this.unitTestCase1.Load += new System.EventHandler(this.unitTestCase1_Load);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 400);
            this.Controls.Add(this.unitTestCase1);
            this.Name = "Master";
            this.Text = "Automation";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UnitTestCase unitTestCase1;
    }
}

