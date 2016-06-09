namespace VideoSub
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
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDoChange = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoChange
            // 
            this.btnDoChange.Location = new System.Drawing.Point(0, 0);
            this.btnDoChange.Name = "btnDoChange";
            this.btnDoChange.Size = new System.Drawing.Size(148, 261);
            this.btnDoChange.TabIndex = 0;
            this.btnDoChange.Text = "Change";
            this.btnDoChange.UseVisualStyleBackColor = true;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(209, 0);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(75, 261);
            this.btnAddMenu.TabIndex = 1;
            this.btnAddMenu.Text = "btnAddMenu";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.btnDoChange);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VideoSub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoChange;
        private System.Windows.Forms.Button btnAddMenu;
    }
}

