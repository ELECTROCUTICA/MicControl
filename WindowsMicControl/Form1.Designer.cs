﻿namespace WindowsMicControl {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.麦克风静音ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示主窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.设备列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开机后自启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.麦克风静音ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.开机后自启动ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 55);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "设备列表";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(109, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(263, 52);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(105, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Test";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "麦克风控制";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.麦克风静音ToolStripMenuItem,
            this.显示主窗体ToolStripMenuItem,
            this.toolStripSeparator1,
            this.设备列表ToolStripMenuItem,
            this.开机后自启动ToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出程序ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 126);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 麦克风静音ToolStripMenuItem
            // 
            this.麦克风静音ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.麦克风静音ToolStripMenuItem.Name = "麦克风静音ToolStripMenuItem";
            this.麦克风静音ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.麦克风静音ToolStripMenuItem.Text = "麦克风静音";
            this.麦克风静音ToolStripMenuItem.Click += new System.EventHandler(this.麦克风静音ToolStripMenuItem_Click);
            // 
            // 显示主窗体ToolStripMenuItem
            // 
            this.显示主窗体ToolStripMenuItem.Name = "显示主窗体ToolStripMenuItem";
            this.显示主窗体ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.显示主窗体ToolStripMenuItem.Text = "显示主窗体";
            this.显示主窗体ToolStripMenuItem.Click += new System.EventHandler(this.显示主窗体ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // 设备列表ToolStripMenuItem
            // 
            this.设备列表ToolStripMenuItem.Name = "设备列表ToolStripMenuItem";
            this.设备列表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.设备列表ToolStripMenuItem.Text = "设备列表";
            this.设备列表ToolStripMenuItem.Click += new System.EventHandler(this.设备列表ToolStripMenuItem_Click);
            // 
            // 开机后自启动ToolStripMenuItem
            // 
            this.开机后自启动ToolStripMenuItem.Name = "开机后自启动ToolStripMenuItem";
            this.开机后自启动ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.开机后自启动ToolStripMenuItem.Text = "开机后自启动";
            this.开机后自启动ToolStripMenuItem.Click += new System.EventHandler(this.开机后自启动ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试ToolStripMenuItem,
            this.显示ToolStripMenuItem,
            this.设备ToolStripMenuItem,
            this.选项ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.测试ToolStripMenuItem.Text = "程序";
            this.测试ToolStripMenuItem.Click += new System.EventHandler(this.测试ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.隐藏窗口ToolStripMenuItem});
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 隐藏窗口ToolStripMenuItem
            // 
            this.隐藏窗口ToolStripMenuItem.Name = "隐藏窗口ToolStripMenuItem";
            this.隐藏窗口ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.隐藏窗口ToolStripMenuItem.Text = "隐藏窗口";
            this.隐藏窗口ToolStripMenuItem.Click += new System.EventHandler(this.隐藏窗口ToolStripMenuItem_Click);
            // 
            // 设备ToolStripMenuItem
            // 
            this.设备ToolStripMenuItem.Name = "设备ToolStripMenuItem";
            this.设备ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设备ToolStripMenuItem.Text = "设备";
            this.设备ToolStripMenuItem.Click += new System.EventHandler(this.设备ToolStripMenuItem_Click);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.麦克风静音ToolStripMenuItem1,
            this.toolStripSeparator3,
            this.开机后自启动ToolStripMenuItem1});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.选项ToolStripMenuItem.Text = "选项";
            this.选项ToolStripMenuItem.Click += new System.EventHandler(this.选项ToolStripMenuItem_Click);
            // 
            // 麦克风静音ToolStripMenuItem1
            // 
            this.麦克风静音ToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.麦克风静音ToolStripMenuItem1.Name = "麦克风静音ToolStripMenuItem1";
            this.麦克风静音ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.麦克风静音ToolStripMenuItem1.Text = "麦克风静音";
            this.麦克风静音ToolStripMenuItem1.Click += new System.EventHandler(this.麦克风静音ToolStripMenuItem1_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // 开机后自启动ToolStripMenuItem1
            // 
            this.开机后自启动ToolStripMenuItem1.Name = "开机后自启动ToolStripMenuItem1";
            this.开机后自启动ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.开机后自启动ToolStripMenuItem1.Text = "开机后自启动";
            this.开机后自启动ToolStripMenuItem1.Click += new System.EventHandler(this.开机后自启动ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 170);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "麦克风静音控制";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示主窗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 麦克风静音ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开机后自启动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 麦克风静音ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 开机后自启动ToolStripMenuItem1;
    }
}

