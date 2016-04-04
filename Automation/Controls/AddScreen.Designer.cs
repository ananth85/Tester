namespace Automation.Controls
{
    partial class AddScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.T_ScreenName = new System.Windows.Forms.TextBox();
            this.T_ScreenID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // T_ScreenName
            // 
            this.T_ScreenName.Location = new System.Drawing.Point(120, 44);
            this.T_ScreenName.Name = "T_ScreenName";
            this.T_ScreenName.Size = new System.Drawing.Size(141, 20);
            this.T_ScreenName.TabIndex = 16;
            // 
            // T_ScreenID
            // 
            this.T_ScreenID.Enabled = false;
            this.T_ScreenID.Location = new System.Drawing.Point(120, 14);
            this.T_ScreenID.Name = "T_ScreenID";
            this.T_ScreenID.Size = new System.Drawing.Size(61, 20);
            this.T_ScreenID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Screen ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Screen Name";
            // 
            // AddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.T_ScreenName);
            this.Controls.Add(this.T_ScreenID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddScreen";
            this.Size = new System.Drawing.Size(268, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox T_ScreenName;
        private System.Windows.Forms.TextBox T_ScreenID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
