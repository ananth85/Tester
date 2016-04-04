namespace Automation.Controls
{
    partial class AddObject
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
            this.label2 = new System.Windows.Forms.Label();
            this.T_ObjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.T_FindBy = new System.Windows.Forms.TextBox();
            this.T_Property = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.T_FrameName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Object Name";
            // 
            // T_ObjectName
            // 
            this.T_ObjectName.Location = new System.Drawing.Point(126, 39);
            this.T_ObjectName.Name = "T_ObjectName";
            this.T_ObjectName.Size = new System.Drawing.Size(141, 20);
            this.T_ObjectName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Find by";
            // 
            // T_FindBy
            // 
            this.T_FindBy.Location = new System.Drawing.Point(126, 66);
            this.T_FindBy.Name = "T_FindBy";
            this.T_FindBy.Size = new System.Drawing.Size(141, 20);
            this.T_FindBy.TabIndex = 7;
            // 
            // T_Property
            // 
            this.T_Property.Location = new System.Drawing.Point(126, 92);
            this.T_Property.Name = "T_Property";
            this.T_Property.Size = new System.Drawing.Size(141, 20);
            this.T_Property.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Property";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(126, 118);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            // 
            // T_FrameName
            // 
            this.T_FrameName.Location = new System.Drawing.Point(126, 13);
            this.T_FrameName.Name = "T_FrameName";
            this.T_FrameName.Size = new System.Drawing.Size(141, 20);
            this.T_FrameName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Frame";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.T_FrameName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.T_Property);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.T_FindBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.T_ObjectName);
            this.Controls.Add(this.label2);
            this.Name = "AddObject";
            this.Size = new System.Drawing.Size(282, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox T_ObjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox T_FindBy;
        private System.Windows.Forms.TextBox T_Property;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox T_FrameName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}
