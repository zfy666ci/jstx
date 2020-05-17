namespace WindowsFormsApp1
{
    partial class userfrom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userfrom));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.在线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.离线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.State = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sex1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chatListBox1 = new _CUSTOM_CONTROLS.ChatListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chatListBox2 = new _CUSTOM_CONTROLS.ChatListBox();
            this.richTextBoxReceive = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(21, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(13, 13);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.在线ToolStripMenuItem,
            this.离线ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 56);
            // 
            // 在线ToolStripMenuItem
            // 
            this.在线ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("在线ToolStripMenuItem.Image")));
            this.在线ToolStripMenuItem.Name = "在线ToolStripMenuItem";
            this.在线ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.在线ToolStripMenuItem.Tag = "0x0A";
            this.在线ToolStripMenuItem.Text = "在线";
            // 
            // 离线ToolStripMenuItem
            // 
            this.离线ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("离线ToolStripMenuItem.Image")));
            this.离线ToolStripMenuItem.Name = "离线ToolStripMenuItem";
            this.离线ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.离线ToolStripMenuItem.Tag = "0x28";
            this.离线ToolStripMenuItem.Text = "离线";
            // 
            // State
            // 
            this.State.BackColor = System.Drawing.Color.Transparent;
            this.State.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.State.ContextMenuStrip = this.contextMenuStrip1;
            this.State.FlatAppearance.BorderSize = 0;
            this.State.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.State.Image = ((System.Drawing.Image)(resources.GetObject("State.Image")));
            this.State.Location = new System.Drawing.Point(-7, -3);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(41, 32);
            this.State.TabIndex = 0;
            this.State.UseVisualStyleBackColor = false;
            this.State.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.sex1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Name1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sex1
            // 
            this.sex1.AutoSize = true;
            this.sex1.BackColor = System.Drawing.Color.Transparent;
            this.sex1.Location = new System.Drawing.Point(109, 69);
            this.sex1.Name = "sex1";
            this.sex1.Size = new System.Drawing.Size(24, 16);
            this.sex1.TabIndex = 5;
            this.sex1.Text = "男";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.BackColor = System.Drawing.Color.Transparent;
            this.Name1.Location = new System.Drawing.Point(103, 38);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(56, 16);
            this.Name1.TabIndex = 3;
            this.Name1.Text = "用户名";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-7, 224);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(297, 326);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chatListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(289, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "好友";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chatListBox1
            // 
            this.chatListBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.chatListBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBox1.Location = new System.Drawing.Point(6, 6);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.Size = new System.Drawing.Size(277, 287);
            this.chatListBox1.TabIndex = 0;
            this.chatListBox1.Text = "chatListBox1";
            this.chatListBox1.DoubleClickSubItem += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.chatListBox1_DoubleClickSubItem);
            this.chatListBox1.MouseEnterHead += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.chatListBox1_MouseEnterHead);
            this.chatListBox1.MouseLeaveHead += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.chatListBox1_MouseLeaveHead);
            this.chatListBox1.Click += new System.EventHandler(this.chatListBox1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage2.Controls.Add(this.chatListBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(289, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "群组";
            // 
            // chatListBox2
            // 
            this.chatListBox2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.chatListBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBox2.Location = new System.Drawing.Point(6, 6);
            this.chatListBox2.Name = "chatListBox2";
            this.chatListBox2.Size = new System.Drawing.Size(277, 287);
            this.chatListBox2.TabIndex = 1;
            this.chatListBox2.Text = "chatListBox2";
            // 
            // richTextBoxReceive
            // 
            this.richTextBoxReceive.Location = new System.Drawing.Point(474, 250);
            this.richTextBoxReceive.Multiline = true;
            this.richTextBoxReceive.Name = "richTextBoxReceive";
            this.richTextBoxReceive.Size = new System.Drawing.Size(153, 108);
            this.richTextBoxReceive.TabIndex = 7;
            // 
            // userfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(290, 551);
            this.Controls.Add(this.richTextBoxReceive);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.State);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "userfrom";
            this.Text = "FY";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 在线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 离线ToolStripMenuItem;
        private System.Windows.Forms.Button State;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label sex1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private _CUSTOM_CONTROLS.ChatListBox chatListBox1;
        private _CUSTOM_CONTROLS.ChatListBox chatListBox2;
        private System.Windows.Forms.TextBox richTextBoxReceive;
    }
}