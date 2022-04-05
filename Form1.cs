using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatic_Execution
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            notifyIcon1.Visible = true;

            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                this.ShowInTaskbar = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
//#if DEBUG
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
            }
//#endif
        }

        #region MonitoringProcess 관련 변수 선언.

        string monitoringFileName = "notepad";

        #endregion

        public void MonitoringProcess()
        {
            while (true)
            {
                Process[] processA = Process.GetProcessesByName(monitoringFileName);

                if (processA.Length <= 0)
                {
                    Start();
                    //isLiveMonitoring = false;
                    ScreenLog("동작테스트", "프로그램을 실행 합니다.");
                }
                else
                {
                    ScreenLog("동작테스트", "프로그램이 정상적으로 구동하고 있습니다.");
                    //isLiveMonitoring = true;

                    // 로그 남기는 변수 생성해서...
                    //richTextBox1.Invoke(new Action(() =>
                    //{
                    //    richTextBox1.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ff")} :: 정상 동작중~!{Environment.NewLine}");
                    //}));

                    // 이전 테스트용 
                    //int nCnt = 0;

                    //while (true)
                    //{
                    //    Thread.Sleep(1000);

                    //    richTextBox1.Invoke(new Action(() =>
                    //    {
                    //        richTextBox1.AppendText($"{nCnt++} :: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} :: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} :: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} :: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} :: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} :: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
                    //        richTextBox1.AppendText(Environment.NewLine);
                    //    }));
                    //}


                }

                Thread.Sleep(1000);
            }

        }

        /// <summary>
        /// 모니터링 할 파일 정보
        /// </summary>
        private void Start()
        {
            Process ps = new Process();

            ps.StartInfo.FileName = tBoxFilename.Text;
            ps.StartInfo.WorkingDirectory = tBoxPath.Text;
            ps.StartInfo.WindowStyle = chkBoxMaximized.Checked ? ProcessWindowStyle.Maximized : ProcessWindowStyle.Normal;

            ps.Start();
            ps.WaitForExit(1000);
        }

        /// <summary>
        /// INI :: 불러오기 & 저장 :: 없으면 생성~!
        /// </summary>
        public class IniFile
        {
            public string path;

            //Ini 쓰기 WinApi선언
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

            //Ini 읽기 WinApi선언
            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            /// <summary>
            /// INIFile Constructor.
            /// </summary>
            /// <PARAM name="INIPath"></PARAM>
            public IniFile(string INIPath)
            {
                path = INIPath;
            }
            /// <summary>
            /// Write Data to the INI File
            /// </summary>
            /// <PARAM name="Section"></PARAM>
            /// Section name
            /// <PARAM name="Key"></PARAM>
            /// Key Name
            /// <PARAM name="Value"></PARAM>
            /// Value Name
            public void IniWriteValue(string Section, string Key, string Value)
            {
                WritePrivateProfileString(Section, Key, Value, this.path);
            }

            /// <summary>
            /// Read Data Value From the Ini File
            /// </summary>
            /// <PARAM name="Section"></PARAM>
            /// <PARAM name="Key"></PARAM>
            /// <PARAM name="Path"></PARAM>
            /// <returns></returns>
            public string IniReadValue(string Section, string Key)
            {
                StringBuilder temp = new StringBuilder(255);
                int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
                return temp.ToString();
            }
        }

        #region INI 초기 정보 변수
        private IniFile iniFile = new IniFile("");
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            iniFile.path = Application.StartupPath + @"\Execution.ini";

            ScreenLog("ini파일", $"{iniFile.path}");

            string filePath = iniFile.IniReadValue("info", "경로");
            string fileName = iniFile.IniReadValue("info", "파일");

            chkBoxMaximized.Checked = iniFile.IniReadValue("info", "최대화") == "True" ? true : false;

            if (filePath.Length <= 0)
            {
                tBoxFilename.Text = "notepad.exe";
                tBoxPath.Text = @"C:\Windows\system32";
            }
            else
            {
                tBoxFilename.Text = fileName;
                tBoxPath.Text = filePath;

                monitoringFileName = fileName;
            }

            this.Hide();

            Task task = new Task(new Action(MonitoringProcess));
            task.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "Automatic Execution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "Automatic Execution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        #region Log 순번 변수 선언
        /// <summary>
        /// 로그 카운트용
        /// </summary>
        int LogCount = 0;
        #endregion

        public void ScreenLog(string Title, string content)
        {
            richTextBox1.Invoke(new Action(() =>
            {
                richTextBox1.AppendText($"{LogCount++} :: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ff")} :: [ {Title}] {content}{Environment.NewLine}");
            }));
        }

        private void tBoxFilename_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.InitialDirectory = Application.StartupPath;
            openDialog.Title = $"파일 선택";
            openDialog.Filter = "실행파일 (*.exe)|*.exe";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openDialog.SafeFileName);
                string filePathName = openDialog.FileName;
                string filePath = filePathName.Replace(openDialog.SafeFileName, "");

                #region 그냥 참고용

                ////c:\Windows\System32\notepad
                //string sTmpA = Path.ChangeExtension(filePathName, null);

                ////notepad
                //string sTmpB = Path.GetFileNameWithoutExtension(filePathName);

                ////notepad.exe
                //string sTmpC = Path.GetFileName(filePathName);

                #endregion

                tBoxFilename.Text = fileName;
                tBoxPath.Text = filePath;

                iniFile.IniWriteValue("info", "파일", fileName);
                iniFile.IniWriteValue("info", "경로", filePath);
            }
        }

        private void chkBoxMaximized_CheckedChanged(object sender, EventArgs e)
        {
            iniFile.IniWriteValue("info", "최대화", $"{chkBoxMaximized.Checked}");
        }
    }
}
