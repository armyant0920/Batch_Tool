using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BatchTool
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ipconfig_Click(object sender, EventArgs e)
        {
            string info = Get_IPCONFIG();
            WriteMessage(info);

        }

        private void WriteMessage(string msg)
        {
            tb_board.AppendText(msg);
            tb_board.SelectionStart = tb_board.Text.Length;
            tb_board.ScrollToCaret();
        }



        public static string Get_IPCONFIG()
        {
            Process process = new Process();
            process.StartInfo.FileName = "ipconfig.exe";
            process.StartInfo.Arguments = "/all";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;

            process.Start();
            string info = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            process.Close();

            return info;


        }

        private void ipconfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = Get_IPCONFIG();
            WriteMessage(s);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_board.Clear();
            WriteMessage("clear!");
        }



        private void RunCMD(string args) {

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = string.Format(@"/c {0}",args);//c是一個cmd.exe命令行選項，它告訴cmd.exe在執行完指定的命令後退出。
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            WriteMessage(output);
            process.WaitForExit();
            //process.Close();            
            //return output;

        }

        private void ResetPanel(List<Control> controls) {
            //清空所有控制項
            ctrl_panel.Controls.Clear();
            foreach(Control control in controls){
                ctrl_panel.Controls.Add(control);
            }           
        }

        private void Telnet() {

            List<Control> controls = new List<Control>();
            TextBox tb1 = new TextBox();
            TextBox tb2 = new TextBox();
            Button btn = new Button();           
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(tb1, "輸入欲查詢IP或網域");
            
            ToolTip tip2 = new ToolTip();
            tip2.SetToolTip(tb2,"輸入port號");
           
           
            //button setting
            btn.Text = "telnet";
            btn.Click += (sender, e) =>
            {
                RunCMD(string.Format("{0} {1} {2}", btn.Text, tb1.Text.Trim(),tb2.Text.Trim()));
            };
            
            tb1.Location = new Point(0, 0);
            tb2.Location = new Point(0, 25);
            btn.Location = new Point(0, 50);

            controls.Add(btn);
            controls.Add(tb2);
            controls.Add(tb1);
            //設定共同事件
            foreach (Control ctrl in controls)
            {
                ctrl.TabStop = true;//允許tab
                ctrl.KeyDown += (sender, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        btn.PerformClick();
                    }

                };

            }
         
            ResetPanel(controls);

        }


        private void Xcopy()
        {

            List<Control> controls = new List<Control>();
            TextBox tb1 = new TextBox();
            TextBox tb2 = new TextBox();
            Button btn = new Button();
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(tb1, "輸入複製路徑");

            ToolTip tip2 = new ToolTip();
            tip2.SetToolTip(tb2, "輸入目的路徑");

            CheckBox cb1 = new CheckBox();
            cb1.Text = "複製所有子目錄，但不包括空目錄";
            cb1.Tag = "/s";
            cb1.Location = new Point(100, 0);
            //
            CheckBox cb2 = new CheckBox();
            cb2.Text="複製所有子目錄，包括空目錄";
            cb2.Location = new Point(100, 25);
            cb2.Tag = "/e";
            //
            CheckBox cb3 = new CheckBox();
            cb3.Text = "複製隱藏和系統檔案";
            cb3.Location = new Point(100, 50);
            cb3.Tag = "/h";
            //
            CheckBox cb4 = new CheckBox();
            cb4.Text = "複製屬性。如果您不指定此選項，則新檔案將不會繼承舊檔案的屬性";
            cb4.Location = new Point(100, 75);
            cb4.Tag = "/k";
            //
            CheckBox cb5 = new CheckBox();
            cb5.Text = "不提示您確認是否要覆寫已存在的目的地檔案";
            cb5.Location = new Point(100, 100);
            cb5.Tag = "/y";
            //
            CheckBox cb6 = new CheckBox();
            cb6.Text = "僅在源檔案比目的地檔案新或源檔案比目的地檔案舊時才複製";
            cb6.Location = new Point(100, 125);
            cb6.Tag = "/d";
            cb6.BackColor = Color.Green;
            cb6.AutoSize = true;
            cb6.Width = 600;

            //

            controls.Add(cb1);
            controls.Add(cb2);
            controls.Add(cb3);
            controls.Add(cb4);
            controls.Add(cb5);
            controls.Add(cb6);

            //設定checkbox格式
            foreach (CheckBox cb in controls.Where(c => (c is CheckBox))) {
                cb.AutoSize = true;
                cb.BackColor = Color.DarkGray;
            
            }


            //button setting
            btn.Text = "XCOPY";
            btn.Click += (sender, e) =>
            {
                // /e：複製所有子目錄，包括空目錄。 
                // /h：複製隱藏和系統檔案。
                // /y：不提示您確認是否要覆寫已存在的目的地檔案。
                // /d：僅在源檔案比目的地檔案新或源檔案比目的地檔案舊時才複製。

                string settings = string.Empty;
                //加入所有有勾選的checkbox
                foreach (CheckBox cb in controls.Where(c => (c is CheckBox) ))
                {
                    if (cb.Checked)
                        settings += string.Format("{0} ",cb.Tag.ToString());
                
                }
                RunCMD(string.Format("xcopy {0} {1} {2}", tb1.Text.Trim(), tb2.Text.Trim(),settings));
            };
            
            tb1.Location = new Point(0, 0);
            tb2.Location = new Point(0, 25);
            btn.Location = new Point(0, 50);

            controls.Add(btn);
            controls.Add(tb2);
            controls.Add(tb1);
            //設定共同事件
            foreach (Control ctrl in controls.Where(c=>!(c is CheckBox)))//不是checkbox的加入enter事件
            {
                //ctrl.Dock = DockStyle.Top;
                ctrl.KeyDown += (sender, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        btn.PerformClick();
                    }

                };

            }



            ResetPanel(controls);

        }



        private void Ping() {
            List<Control> controls = new List<Control>();
            TextBox tb1 = new TextBox();
            Button btn = new Button();
            tb1.Dock = DockStyle.Left;
            tb1.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter) {
                    btn.PerformClick();
                }
            
            };

            controls.Add(tb1);
            
            btn.Text = "Send";
            btn.Dock = DockStyle.Right;
            
            btn.Click += (sender, e) =>
            {
                RunCMD("ping " + tb1.Text.Trim());
            };
            controls.Add(btn);
            ResetPanel(controls);
        }

        private void AddControls() {

            TextBox tb1 = new TextBox();
            tb1.Dock = DockStyle.Left;

            ctrl_panel.Controls.Add(tb1);
            Button btn = new Button();
            btn.Text = "Send";
            btn.Dock = DockStyle.Right;
            ctrl_panel.Controls.Add(btn);
            btn.Click += (sender, e) => {
                RunCMD("telnet "+tb1.Text.Trim());                        
            };
            ctrl_panel.Controls.Add(btn);
            
            
        
        }

        private void telnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telnet();
        }

        private void puingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ping();
        }

        private void xcopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xcopy();
        }


        private void btn_suspend_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, false, false);//設定休眠狀態為Suspend,避免強制關機及顯示鎖定
        }

    }
    
}
