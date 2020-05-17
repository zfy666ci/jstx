namespace WindowsFormsApp1
{
    partial class WeChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeChat));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.State1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sex1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chatListBox1 = new _CUSTOM_CONTROLS.ChatListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 284);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.State1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.sex1);
            this.groupBox1.Controls.Add(this.name1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(608, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "资料卡";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "人数：";
            // 
            // State1
            // 
            this.State1.AutoSize = true;
            this.State1.BackColor = System.Drawing.Color.Transparent;
            this.State1.ForeColor = System.Drawing.Color.Black;
            this.State1.Location = new System.Drawing.Point(68, 121);
            this.State1.Name = "State1";
            this.State1.Size = new System.Drawing.Size(40, 16);
            this.State1.TabIndex = 7;
            this.State1.Text = "在线";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "IP：";
            // 
            // sex1
            // 
            this.sex1.AutoSize = true;
            this.sex1.BackColor = System.Drawing.Color.Transparent;
            this.sex1.ForeColor = System.Drawing.Color.Black;
            this.sex1.Location = new System.Drawing.Point(68, 76);
            this.sex1.Name = "sex1";
            this.sex1.Size = new System.Drawing.Size(48, 16);
            this.sex1.TabIndex = 5;
            this.sex1.Text = "TEST1";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.BackColor = System.Drawing.Color.Transparent;
            this.name1.ForeColor = System.Drawing.Color.Black;
            this.name1.Location = new System.Drawing.Point(68, 40);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(48, 16);
            this.name1.TabIndex = 3;
            this.name1.Text = "TEST1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "名称：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2, 307);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(600, 138);
            this.textBox2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(336, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(475, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chatListBox1);
            this.groupBox2.Location = new System.Drawing.Point(608, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 278);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "群员列表";
            // 
            // chatListBox1
            // 
            this.chatListBox1.BackColor = System.Drawing.Color.White;
            this.chatListBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBox1.Location = new System.Drawing.Point(15, 34);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.Size = new System.Drawing.Size(155, 236);
            this.chatListBox1.TabIndex = 0;
            this.chatListBox1.Text = "chatListBox1";
            // 
            // WeChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeChat";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label State1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sex1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private _CUSTOM_CONTROLS.ChatListBox chatListBox1;
    }
}