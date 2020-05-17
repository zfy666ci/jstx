namespace WindowsFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Usertxt1 = new System.Windows.Forms.TextBox();
            this.Pwdtxt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Login1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usertxt1
            // 
            this.Usertxt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Usertxt1, "Usertxt1");
            this.Usertxt1.Name = "Usertxt1";
            // 
            // Pwdtxt1
            // 
            resources.ApplyResources(this.Pwdtxt1, "Pwdtxt1");
            this.Pwdtxt1.Name = "Pwdtxt1";
            this.Pwdtxt1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login1
            // 
            resources.ApplyResources(this.Login1, "Login1");
            this.Login1.FlatAppearance.BorderSize = 0;
            this.Login1.Name = "Login1";
            this.Login1.UseVisualStyleBackColor = true;
            this.Login1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pwdtxt1);
            this.Controls.Add(this.Usertxt1);
            this.Controls.Add(this.Login1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Usertxt1;
        private System.Windows.Forms.TextBox Pwdtxt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Login1;
    }
}

