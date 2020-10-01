namespace SCPSLUtil
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Memory = new System.Windows.Forms.CheckBox();
            this.maintext = new System.Windows.Forms.Label();
            this.InfLoad = new System.Windows.Forms.CheckBox();
            this.Remove = new System.Windows.Forms.CheckBox();
            this.Execute = new System.Windows.Forms.Button();
            this.Sign = new System.Windows.Forms.CheckBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Session = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.Font = new System.Drawing.Font("IBM Plex Sans KR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Memory.ForeColor = System.Drawing.Color.Black;
            this.Memory.Location = new System.Drawing.Point(21, 182);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(128, 25);
            this.Memory.TabIndex = 0;
            this.Memory.Text = "메모리 오류 해결";
            this.Memory.UseVisualStyleBackColor = true;
            this.Memory.CheckedChanged += new System.EventHandler(this.Memory_CheckedChanged);
            // 
            // maintext
            // 
            this.maintext.AutoSize = true;
            this.maintext.Font = new System.Drawing.Font("IBM Plex Sans KR", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.maintext.Location = new System.Drawing.Point(16, 23);
            this.maintext.Name = "maintext";
            this.maintext.Size = new System.Drawing.Size(161, 33);
            this.maintext.TabIndex = 1;
            this.maintext.Text = "SCPSL Utility";
            // 
            // InfLoad
            // 
            this.InfLoad.AutoSize = true;
            this.InfLoad.Font = new System.Drawing.Font("IBM Plex Sans KR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InfLoad.ForeColor = System.Drawing.Color.Black;
            this.InfLoad.Location = new System.Drawing.Point(155, 182);
            this.InfLoad.Name = "InfLoad";
            this.InfLoad.Size = new System.Drawing.Size(111, 25);
            this.InfLoad.TabIndex = 2;
            this.InfLoad.Text = "무한로딩 해결";
            this.InfLoad.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.AutoSize = true;
            this.Remove.Font = new System.Drawing.Font("IBM Plex Sans KR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Remove.ForeColor = System.Drawing.Color.Red;
            this.Remove.Location = new System.Drawing.Point(21, 244);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(98, 25);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "게임 초기화";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.CheckedChanged += new System.EventHandler(this.Remove_CheckedChanged);
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("IBM Plex Sans KR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Execute.Location = new System.Drawing.Point(82, 316);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(125, 30);
            this.Execute.TabIndex = 4;
            this.Execute.Text = "실행";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Sign
            // 
            this.Sign.AutoSize = true;
            this.Sign.Font = new System.Drawing.Font("IBM Plex Sans KR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Sign.ForeColor = System.Drawing.Color.Blue;
            this.Sign.Location = new System.Drawing.Point(21, 213);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(198, 25);
            this.Sign.TabIndex = 6;
            this.Sign.Text = "Digital Signature 문제해결";
            this.Sign.UseVisualStyleBackColor = true;
            this.Sign.CheckedChanged += new System.EventHandler(this.Sign_CheckedChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ProgressBar.Location = new System.Drawing.Point(21, 99);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(245, 23);
            this.ProgressBar.TabIndex = 8;
            // 
            // Session
            // 
            this.Session.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Session.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Session.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Session.Location = new System.Drawing.Point(36, 128);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(216, 27);
            this.Session.TabIndex = 9;
            this.Session.Text = "기다리는 중...";
            this.Session.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Icon made by Freepik from Flaticon";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("IBM Plex Sans KR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(50, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "문의: Discord 한동전#8080";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Session);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.InfLoad);
            this.Controls.Add(this.maintext);
            this.Controls.Add(this.Memory);
            this.Font = new System.Drawing.Font("IBM Plex Sans KR", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCPSLUtil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox Memory;
        private System.Windows.Forms.Label maintext;
        private System.Windows.Forms.CheckBox InfLoad;
        private System.Windows.Forms.CheckBox Remove;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.CheckBox Sign;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.TextBox Session;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

#endregion