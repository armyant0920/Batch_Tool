namespace BatchTool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_board = new System.Windows.Forms.RichTextBox();
            this.ctrl_panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ipconfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nslookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.xcopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_clear = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip_ipconfig = new System.Windows.Forms.ToolTip(this.components);
            this.btn_suspend = new System.Windows.Forms.Button();

            this.btn_clear = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip_ipconfig = new System.Windows.Forms.ToolTip(this.components);
            this.xcopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_board
            // 
            this.tb_board.Location = new System.Drawing.Point(32, 179);
            this.tb_board.Name = "tb_board";
            this.tb_board.ReadOnly = true;
            this.tb_board.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tb_board.Size = new System.Drawing.Size(726, 259);
            this.tb_board.TabIndex = 0;
            this.tb_board.Text = "";
            // 
            // ctrl_panel
            // 
            this.ctrl_panel.AutoScroll = true;
            this.ctrl_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrl_panel.Location = new System.Drawing.Point(32, 51);
            this.ctrl_panel.Name = "ctrl_panel";
            this.ctrl_panel.Size = new System.Drawing.Size(699, 122);
            this.ctrl_panel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ipconfigToolStripMenuItem,
            this.telnetToolStripMenuItem,
            this.puingToolStripMenuItem,
            this.nslookupToolStripMenuItem,
            this.xcopyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ipconfigToolStripMenuItem
            // 
            this.ipconfigToolStripMenuItem.Name = "ipconfigToolStripMenuItem";
            this.ipconfigToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ipconfigToolStripMenuItem.Text = "ipconfig";
            this.ipconfigToolStripMenuItem.ToolTipText = "查詢本機網路資訊";
            this.ipconfigToolStripMenuItem.Click += new System.EventHandler(this.ipconfigToolStripMenuItem_Click);
            // 
            // telnetToolStripMenuItem
            // 
            this.telnetToolStripMenuItem.Name = "telnetToolStripMenuItem";
            this.telnetToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.telnetToolStripMenuItem.Text = "telnet";
            this.telnetToolStripMenuItem.ToolTipText = "遠端操作";
            this.telnetToolStripMenuItem.Click += new System.EventHandler(this.telnetToolStripMenuItem_Click);
            // 
            // puingToolStripMenuItem
            // 
            this.puingToolStripMenuItem.Name = "puingToolStripMenuItem";
            this.puingToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.puingToolStripMenuItem.Text = "ping";
            this.puingToolStripMenuItem.ToolTipText = "查連線狀況";
            this.puingToolStripMenuItem.Click += new System.EventHandler(this.puingToolStripMenuItem_Click);
            // 
            // nslookupToolStripMenuItem
            // 
            this.nslookupToolStripMenuItem.Name = "nslookupToolStripMenuItem";
            this.nslookupToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nslookupToolStripMenuItem.Text = "nslookup";
            this.nslookupToolStripMenuItem.ToolTipText = "查網域或IP";
            // 

            // xcopyToolStripMenuItem
            // 
            this.xcopyToolStripMenuItem.Name = "xcopyToolStripMenuItem";
            this.xcopyToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.xcopyToolStripMenuItem.Text = "xcopy";
            this.xcopyToolStripMenuItem.ToolTipText = "使用xcopy複製檔案";
            this.xcopyToolStripMenuItem.Click += new System.EventHandler(this.xcopyToolStripMenuItem_Click);
            // 


            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(32, 444);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 

            // btn_suspend
            // 
            this.btn_suspend.Location = new System.Drawing.Point(144, 443);
            this.btn_suspend.Name = "btn_suspend";
            this.btn_suspend.Size = new System.Drawing.Size(75, 23);
            this.btn_suspend.TabIndex = 5;
            this.btn_suspend.Text = "suspend";
            this.btn_suspend.UseVisualStyleBackColor = true;
            this.btn_suspend.Click += new System.EventHandler(this.btn_suspend_Click);

            // xcopyToolStripMenuItem
            // 
            this.xcopyToolStripMenuItem.Name = "xcopyToolStripMenuItem";
            this.xcopyToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.xcopyToolStripMenuItem.Text = "xcopy";
            this.xcopyToolStripMenuItem.ToolTipText = "使用xcopy複製檔案";
            this.xcopyToolStripMenuItem.Click += new System.EventHandler(this.xcopyToolStripMenuItem_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);

            this.Controls.Add(this.btn_suspend);

            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.ctrl_panel);
            this.Controls.Add(this.tb_board);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bat指令";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_board;
        private System.Windows.Forms.Panel ctrl_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ipconfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nslookupToolStripMenuItem;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip_ipconfig;
        private System.Windows.Forms.ToolStripMenuItem xcopyToolStripMenuItem;

        private System.Windows.Forms.Button btn_suspend;

    }
}

