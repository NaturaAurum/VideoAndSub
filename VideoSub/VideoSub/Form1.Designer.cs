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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDoChange = new System.Windows.Forms.Button();
            this.PathList = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnAFN = new System.Windows.Forms.Button();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(3, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(71, 37);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDoChange
            // 
            this.btnDoChange.Location = new System.Drawing.Point(103, 7);
            this.btnDoChange.Name = "btnDoChange";
            this.btnDoChange.Size = new System.Drawing.Size(68, 37);
            this.btnDoChange.TabIndex = 1;
            this.btnDoChange.Text = "Change";
            this.btnDoChange.UseVisualStyleBackColor = true;
            this.btnDoChange.Click += new System.EventHandler(this.btnDoChange_Click);
            // 
            // PathList
            // 
            this.PathList.BackColor = System.Drawing.SystemColors.Window;
            this.PathList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathList.FormattingEnabled = true;
            this.PathList.ItemHeight = 12;
            this.PathList.Location = new System.Drawing.Point(0, 0);
            this.PathList.Name = "PathList";
            this.PathList.Size = new System.Drawing.Size(784, 761);
            this.PathList.TabIndex = 2;
            this.PathList.SelectedIndexChanged += new System.EventHandler(this.PathList_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 37);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.AutoSize = true;
            this.btnPanel.Controls.Add(this.btnAFN);
            this.btnPanel.Controls.Add(this.btnLoad);
            this.btnPanel.Controls.Add(this.btnClear);
            this.btnPanel.Controls.Add(this.btnDoChange);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 714);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(784, 47);
            this.btnPanel.TabIndex = 4;
            // 
            // btnAFN
            // 
            this.btnAFN.Location = new System.Drawing.Point(304, 7);
            this.btnAFN.Name = "btnAFN";
            this.btnAFN.Size = new System.Drawing.Size(167, 37);
            this.btnAFN.TabIndex = 4;
            this.btnAFN.Text = "Change All File to Same";
            this.btnAFN.UseVisualStyleBackColor = true;
            this.btnAFN.Click += new System.EventHandler(this.btnAFN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.PathList);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VideoSub";
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDoChange;
        private System.Windows.Forms.ListBox PathList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnAFN;
    }
}

