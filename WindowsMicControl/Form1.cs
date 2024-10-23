using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;
using System.Collections;
using NAudio.CoreAudioApi;
using System.Timers;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using IWshRuntimeLibrary;
using System.Windows.Forms;

//Powered By C#
namespace WindowsMicControl {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public static string Developer = "season of yanhua";
        public static string Version = "1.0";
        public static bool IsBetaVersion = false;
        public static string ProgramName = "MicControl";

        public static MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        public static IEnumerable<MMDevice> micDevice = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToArray();        //获取所有麦克风设备

        public static string MicMutedText;                              //是否静音Text
        public static bool RunAfterSystemBoot = false;                  //开机自启状态
        public static RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);                 //注册表自启键值

        public static Icon Muted = Properties.Resources.muted;                 //静音图标为黑色
        public static Icon Play = Properties.Resources.play;                   //解除图标为绿色
        public static Image MainMutedImage = Properties.Resources.MainMuted;
        public static Image MainPlayImage = Properties.Resources.MainPlay;
        public static MemoryStream StreamOfMuted = new MemoryStream();
        public static MemoryStream StreamOfPlay = new MemoryStream();

        public static MMDevice MicroPhone;              //选中麦克风对象全局变量

        //初始化
        private void Form1_Load(object sender, EventArgs e) {
            if (micDevice.Count() == 0) {
                MessageBox.Show("未找到麦克风设备 \n 请检查麦克风设备是否禁用或拔出", "应用程序错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            
            MicroPhone = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);

            for (var i = 0; i < micDevice.Count(); i++) {
                listBox2.Items.Add(micDevice.ToList()[i]);

                if (micDevice.ToList()[i].ID == MicroPhone.ID) {
                    listBox2.SelectedIndex = i;
                }
            }

            if (MicroPhone.AudioEndpointVolume.Mute == false) {
                MicMutedText = "否";
                button1.Text = "麦克风静音";
                this.notifyIcon1.Icon = Play;
                this.Icon = Play;
                this.pictureBox1.Image = MainPlayImage;
            }
            else {
                MicMutedText = "是";
                button1.Text = "麦克风开启";
                this.notifyIcon1.Icon = Muted;
                this.Icon = Muted;
                this.pictureBox1.Image = MainMutedImage;
            }

            label1.Text = $"静音：{MicMutedText}";

            AppHotKey hotkey = new AppHotKey(Handle);
            AppHotKey.Hotkey1 = hotkey.RegisterHotkey(Keys.Scroll, AppHotKey.KeyFlags.NONE);
            hotkey.OnHotkey += new HotkeyEventHandler(PressHotkey);

            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = MicroPhone.ToString();
            设备列表ToolStripMenuItem.DropDownItems.Add(item);

            ToolStripMenuItem ItemInMainForm = new ToolStripMenuItem();
            ItemInMainForm.Text = MicroPhone.ToString();
            设备ToolStripMenuItem.DropDownItems.Add(ItemInMainForm);
        }

        //按下热键
        public void PressHotkey(int HotkeyID) { 
            if (HotkeyID == AppHotKey.Hotkey1) MuteOrPlay(MicroPhone);
        }

        //刷新设备列表
        public void FlushDevices() { 
            micDevice = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToArray();

            listBox2.Items.Clear();

            for (var i = 0; i < micDevice.Count(); i++) {
                listBox2.Items.Add(micDevice.ToList()[i]);

                if (micDevice.ToList()[i].ID == MicroPhone.ID) {
                    listBox2.SelectedIndex = i;
                }
            }
            MicroPhone = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);
        }

        //静音、解除
        public bool MuteOrPlay(MMDevice mmdevice) {
            if (mmdevice.AudioEndpointVolume.Mute == false) {
                mmdevice.AudioEndpointVolume.Mute = true;
                MicMutedText = "是";
                button1.Text = "麦克风开启";
                label1.Text = $"静音：{MicMutedText}";
                this.notifyIcon1.Icon = Muted;
                this.Icon = Muted;
                this.pictureBox1.Image = MainMutedImage;
                return true;
            }
            else {
                mmdevice.AudioEndpointVolume.Mute = false;
                MicMutedText = "否";
                button1.Text = "麦克风静音";
                label1.Text = $"静音：{MicMutedText}";
                this.notifyIcon1.Icon = Play;
                this.Icon = Play;
                this.pictureBox1.Image = MainPlayImage;
                return false;
            }
        }

        public void DeveloperInfoModify(string developer,string version, bool isbetaversion) { 
            Form1.Developer = developer;
            Form1.Version = version;
            Form1.IsBetaVersion = isbetaversion;
        }

        private void button1_Click(object sender, EventArgs e) {
            MuteOrPlay(MicroPhone);
        }

        private void Form1_SizeChanged(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }

        }

        //右键托盘打开菜单后执行
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            this.麦克风静音ToolStripMenuItem.Checked = MicroPhone.AudioEndpointVolume.Mute;
            
            Play.Save(StreamOfPlay);
            Image ImaPlay = Image.FromStream(StreamOfPlay);
            Muted.Save(StreamOfMuted);
            Image ImaMuted = Image.FromStream(StreamOfMuted);

            if (MicroPhone.AudioEndpointVolume.Mute == false) {
                this.显示主窗体ToolStripMenuItem.Image = ImaPlay;
            }
            else {
                this.显示主窗体ToolStripMenuItem.Image = ImaMuted;
            }

            string[] keylist = registryKey.GetValueNames();
            for (var index = 0; index < keylist.Length; index++) {              //循环检索键
                if (keylist[index].Equals(ProgramName)) {
                    this.开机后自启动ToolStripMenuItem.Checked = true;
                    return;
                }
            }
            this.开机后自启动ToolStripMenuItem.Checked = false;

        }
        
        private void 麦克风静音ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.麦克风静音ToolStripMenuItem.Checked == false) this.麦克风静音ToolStripMenuItem.Checked = true;
            else this.麦克风静音ToolStripMenuItem.Checked = false;
            MuteOrPlay(MicroPhone);
        }
        private void 开机后自启动ToolStripMenuItem_Click(object sender, EventArgs e) {                //开机自启设置
            if (this.开机后自启动ToolStripMenuItem.Checked == false) {
                this.开机后自启动ToolStripMenuItem.Checked = true;
                registryKey.SetValue(ProgramName, Application.ExecutablePath);
            }
            else {
                this.开机后自启动ToolStripMenuItem.Checked = false;
                registryKey.DeleteValue(ProgramName);
                
            }
            RunAfterSystemBoot = this.开机后自启动ToolStripMenuItem.Checked;
        }

        private void 设备列表ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 显示主窗体ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.ShowInTaskbar = true;
        }
        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Dispose();
            Environment.Exit(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            notifyIcon1.Dispose();
        }

        public void StateChangeOnly(MMDevice mmdevice) {
            if (mmdevice.AudioEndpointVolume.Mute == false) {
                MicMutedText = "是";
                button1.Text = "麦克风开启";
                label1.Text = $"静音：{MicMutedText}";
                this.notifyIcon1.Icon = Muted;
                this.Icon = Muted;
                this.pictureBox1.Image = MainMutedImage;
            }
            else {
                MicMutedText = "否";
                button1.Text = "麦克风静音";
                label1.Text = $"静音：{MicMutedText}";
                this.notifyIcon1.Icon = Play;
                this.Icon = Play;
                this.pictureBox1.Image = MainPlayImage;
            }
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Dispose();
            Environment.Exit(0);
        }
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 隐藏窗口ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        private void 设备ToolStripMenuItem_Click(object sender, EventArgs e) {

        }
        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e) {
            string[] keylist = registryKey.GetValueNames();
            int index;
            for (index = 0; index < keylist.Length; index++) {              //循环检索键
                if (keylist[index].Equals(ProgramName)) {
                    this.开机后自启动ToolStripMenuItem1.Checked = true;
                    break;
                }
            }
            if (index >= keylist.Length) {
                this.开机后自启动ToolStripMenuItem1.Checked = false;
            }
        }
        private void 麦克风静音ToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (this.麦克风静音ToolStripMenuItem.Checked == false) this.麦克风静音ToolStripMenuItem.Checked = true;
            else this.麦克风静音ToolStripMenuItem.Checked = false;
            MuteOrPlay(MicroPhone);
        }

        private void 开机后自启动ToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (this.开机后自启动ToolStripMenuItem1.Checked == false) {
                this.开机后自启动ToolStripMenuItem1.Checked = true;
                registryKey.SetValue(ProgramName, Application.ExecutablePath);
            }
            else {
                this.开机后自启动ToolStripMenuItem1.Checked = false;
                registryKey.DeleteValue(ProgramName);
            }
            RunAfterSystemBoot = this.开机后自启动ToolStripMenuItem.Checked;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {
            for (int i = 0; i < micDevice.Count(); i++) {
                if (listBox2.SelectedItems == listBox2.Items[i]) {
                    MicroPhone = micDevice.ToList()[i];
                }
            }
            
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Developer: season of yanhua \n Version: 1.0 \n Date: 2023/3/8");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }

    public delegate void HotkeyEventHandler(int HotKeyID);

    //快捷键类
    public class AppHotKey : IMessageFilter {
        public List<UInt32> keyIDs = new List<UInt32>();
        IntPtr hWnd;

        public static int Hotkey1;

        public event HotkeyEventHandler OnHotkey;

        public enum KeyFlags {
            NONE = 0,
            ALT = 1,
            CONTROL = 2,
            SHIFT = 4,
            SCROLL = 8
        }
        [DllImport("user32.dll")]
        public static extern UInt32 RegisterHotKey(IntPtr hWnd, UInt32 id, KeyFlags fsModifiers, UInt32 vk);

        [DllImport("user32.dll")]
        public static extern UInt32 UnregisterHotKey(IntPtr hWnd, UInt32 id);

        [DllImport("kernel32.dll")]
        public static extern UInt32 GlobalAddAtom(String lpString);

        [DllImport("kernel32.dll")]
        public static extern UInt32 GlobalDeleteAtom(UInt32 nAtom);

        public AppHotKey(IntPtr hWnd) {         //构造器
            this.hWnd = hWnd;
            Application.AddMessageFilter(this);
        }

        public int RegisterHotkey(Keys Key, KeyFlags keyflags) {
            UInt32 hotkeyid = GlobalAddAtom(Guid.NewGuid().ToString());
            RegisterHotKey(hWnd, hotkeyid, keyflags, (UInt32)Key);
            keyIDs.Add(hotkeyid);
            return (int)hotkeyid;
        }

        public void UnregisterHotkeys() {
            Application.RemoveMessageFilter(this);
            foreach (UInt32 key in keyIDs) {
                UnregisterHotKey(hWnd, key);
                GlobalDeleteAtom(key);
            }
        }

        public bool PreFilterMessage(ref Message m) {
            if (m.Msg == 0x312) {
                if (OnHotkey != null) {
                    foreach (UInt32 key in keyIDs) {
                        if ((UInt32)m.WParam == key) {
                            OnHotkey((int)m.WParam);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
