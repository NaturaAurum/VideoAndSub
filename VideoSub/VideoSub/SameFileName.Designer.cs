namespace VideoSub
{
    partial class SameFileName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputName = new System.Windows.Forms.TextBox();
            this.SFNLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(0, 74);
            this.inputName.Multiline = true;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(285, 188);
            this.inputName.TabIndex = 0;
            // 
            // SFNLabel
            // 
            this.SFNLabel.AutoSize = true;
            this.SFNLabel.Location = new System.Drawing.Point(12, 30);
            this.SFNLabel.Name = "SFNLabel";
            this.SFNLabel.Size = new System.Drawing.Size(169, 12);
            this.SFNLabel.TabIndex = 1;
            this.SFNLabel.Text = "Please Input Name you want";
            // 
            // SameFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SFNLabel);
            this.Controls.Add(this.inputName);
            this.Name = "SameFileName";
            this.Text = "SameFileName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label SFNLabel;
    }
}