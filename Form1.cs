using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Hooks;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Principal;
using System.Net;
using System.IO;

namespace HELP
{
    public partial class Form1 : Form
    {
        private int keyF123 = 0;

        private Color curColor;
        private Color saveColor1;

        private IntPtr hWnd;
        private int sleepSec = 0;

        private bool firstPotion = false;
        private bool running = false;

        private int endCount = 0;
        private int ti3 = 0;

        private int mouseX1 = 0;
        private int mouseY1 = 0;
        private int curmouseX1 = 0;
        private int savemouseX1 = 0;

        private const bool noPotion = false;

        private RECT stRect = default;
        private int curTopPos = 0;
        private int curLeftPos = 0;
        private int saveTopPos = 0;
        private int saveLeftPos = 0;
        private int tTopPos = 0;
        private int tLeftPos = 0;


        private bool potionflag = false;
        private string versionSelected = "";
        private int chatDelaySelected = 0;
        //-------------------------------------------
        //
        // 타이머 변수

        int timerHour = 0;
        int timerMin = 0;
        int timerSec = 0;

        private int timer1sec = 0; // 타이머인터벌과 1초를 맞추기위한 변수
        private int ti_Timer = 0;       // 위 동일

        private int chatdelay_ = 0;
        private int ti_Chat = 0;

        private bool timerflag = false; //업데이트쪽에서 타이머를 위한

        private bool saveCheck10m = false;    //체크박스 변수 저장
        private bool saveCheck5m = false;
        private bool saveCheck1m = false;
        private bool saveCheck0m = false;



        private string curProgramVersion = "";
        private string upProgramVersion = "";


        //
        BossTimer bTimer;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            // 관리자실행
            if (!IsRunningAsAdministrator())
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase);
                {
                    var withBlock = processStartInfo;
                    withBlock.UseShellExecute = true;
                    withBlock.Verb = "runas";
                    Process.Start(processStartInfo);
                    Application.Exit();
                }
            }
            else
                this.Text += " " + "(Administrator)";

            //프로그램 업데이트
            curProgramVersion = "1.0";
            upProgramVersion = ProgramUpdateCheck(curProgramVersion);


            //  단축키
            this.HookedKeyboardNofity += new KeyboardHooker.HookedKeyboardUserEventHandler(Form1_HookedKeyboardNofity);
            KeyboardHooker.Hook(HookedKeyboardNofity);

            // 변수 기본값
            keyF123 = 1;
            timer1.Interval = 200;
            nextChat = 1;
            label1.Text = "대기중";

            versionSelected = cbVersion.SelectedItem as string;

            string[] chatDelayData = { "30", "60", "90", "120" };
            cbchatdelay.Items.AddRange(chatDelayData);
            cbchatdelay.SelectedIndex = 1;
            chatDelaySelected = int.Parse(cbchatdelay.SelectedItem as string);


            string[] versionData = { "1902151002", "( 직접입력 )" };
            cbVersion.Items.AddRange(versionData);
            cbVersion.SelectedIndex = 0;
            hWnd = FindWindow(null, "Lineage Windows Client (" + versionSelected + ") ");
            GetWindowRect((int)hWnd, ref stRect);

            saveTopPos = stRect.top;
            saveLeftPos = stRect.left;     


             bTimer = new BossTimer();

        }

        


        // 업데이트
        private void Update(object sender, EventArgs e)
        {
            if (potionflag == true)
                AutoPotionUpdate();


            if (timerflag == true)
            {
                ti_Timer++;

                if( timer1sec == ti_Timer )
                {
                    ti_Timer = 0;
                    TimerUpdate();
                    bTimer.Update();
                }
            }

            //Debug.WriteLine(chatFlag + "  ");
            if (chatFlag == true)
            {
                ti_Chat++;

                
                chatdelay_ = chatDelaySelected*1000 / timer1.Interval;
                
                //chatdelay_ = 5;
                //Debug.WriteLine(ti_Chat + " == " + chatdelay_);

                if (chatdelay_ == ti_Chat)
                {
                    ti_Chat = 0;

                    ChatUpdate();
                }

            }


            if (potionflag == false 
                    && timerflag == false 
                        && chatFlag == false)
            {
                timer1.Stop();
            }

        }

        private string ProgramUpdateCheck(string tS)
        {
            string result = "";

            string filePath = FileDown("Version");

            FileInfo fileIs = new FileInfo(filePath);
            //if (fileIs.Exists)
            result = System.IO.File.ReadAllText(filePath);

            if (tS != result)
            {
                ProgramUpdateRun();
            }
                                

            //string[] textValue = System.IO.File.ReadAllLines(path);



            //Process.Start(filePath);

            //Delay(10000);


            return result;
        }

        private void ProgramUpdateRun()
        {
            FileDown("Update");
        }



        private string FileDown(string tS)
        {
            string result = "";
            string url;
            string filePath;

            if ("Version" == tS)
            {
                url = "https://drive.google.com/u/0/uc?id=1QS0wDJL_1VgMT5FefbbHC_XdHJ3Zogtw&export=download";
                filePath = Application.StartupPath + "\\version.txt";

                WebClient webClinet = new WebClient();
                webClinet.DownloadFile(url, filePath);

                result = filePath;
            }
            else if("Update" == tS)
            {
                url = "https://drive.google.com/u/0/uc?id=1MMqJdH2nl2OdRy-n-eOaLYUyDUPLz7Y7&export=download";
                filePath = Application.StartupPath + "\\HelpUpdate.exe";

                WebClient webClinet = new WebClient();
                webClinet.DownloadFile(url, filePath);


                Process.Start(filePath);

                result = filePath;
            }
            

            return result;
        }




        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }


        public bool IsRunningAsAdministrator()
        {
            WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void PotionKey(string tS)
        {
            if ("F5" == tS)
                PostMessage(hWnd, 0x100, 0x74, 0x3f0001);

        }

        private void RestCheck()
        {
            savemouseX1 = curmouseX1;
            curmouseX1 = Cursor.Position.X;
            if (savemouseX1 != curmouseX1)
                endCount = 0;
        }

        private void RandomDelay()
        {
            Random r = new Random();
            r.Next(1, 4);

            sleepSec *= 100;
            Thread.Sleep(sleepSec);
        }

        public Color GetColorAt(int tX, int tY)
        {
            Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, tX, tY, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        private void PotionStart()
        {
            if (running == false)
            {
                timer1.Start();
                running = true;
                potionflag = true;
                ti3 = 60000 / timer1.Interval * 2;
                
            }
            label1.Text = "실행중";

        }

        private void PotionStop()
        {
            potionflag = false;
            label1.Text = "대기중";

            running = false;
        }




       
        //
        // 단축키설정
        //
        event KeyboardHooker.HookedKeyboardUserEventHandler HookedKeyboardNofity;
        
        private long Form1_HookedKeyboardNofity(
            bool bIsKeyDown, bool bAlt, bool bCtrl, bool bShift, bool bWindowKey, int vkCode)
        {
            long lResult = 0;

            //Debug.WriteLine(vkCode);


            switch (vkCode)
                {                    
                    case (int)System.Windows.Forms.Keys.F1:
                        MyKeyPress("F1");
                        break;

                    case (int)System.Windows.Forms.Keys.F2:
                        MyKeyPress("F2");
                        break;

                    case (int)System.Windows.Forms.Keys.F3:
                        MyKeyPress("F3");
                        break;

                    case (int)System.Windows.Forms.Keys.F8:
                        MyKeyPress("F8");
                        break;

                    case 109:
                        MyKeyPress("NumpadSub"); //시작 키
                        break;

                    case 107:
                        MyKeyPress("NumpadAdd"); //멈춤 키
                        break;

                    case 111:
                        MyKeyPress("NumpadDiv"); //물약지정1
                        break;

                    case 106:
                        MyKeyPress("NumpadPro"); //물약지정2
                        break;

                    case (int)System.Windows.Forms.Keys.PageUp:
                        MyKeyPress("PageUp");
                        break;

                    case (int)System.Windows.Forms.Keys.PageDown:
                        MyKeyPress("PageDown");
                        break;

                    default:

                        break;
                
            }

            return lResult;
        }

        private void AutoPotionUpdate()
        {
            //마우스 움직임 없을 경우
            //잠수로 판단하여 중지 ( 2분 )
            endCount++;

            if (endCount > ti3)
                PotionStop();
            else
                RestCheck();


            //게임창 이동체크
            //이동이 있으면 물약 포인트 지점 변경
            GameWindowsPos();





            //물약먹는 기준 픽셀
            curColor = GetColorAt(mouseX1, mouseY1);

            if (curColor == saveColor1)
            {
                if (firstPotion == false)
                {
                    firstPotion = true;

                    RandomDelay(); //첫물약일땐 딜레이
                }


                if (noPotion == PotionLimit()) // false 면 물약먹기
                    PotionKey("F5");
            }
            else
                firstPotion = false;
        }

        private void GameWindowsPos()
        {
            GetWindowRect((int)hWnd, ref stRect);


            curTopPos = stRect.top;
            curLeftPos = stRect.left;

            if (saveTopPos != curTopPos)
            {
                if (curTopPos > saveTopPos)
                {
                    tTopPos = curTopPos - saveTopPos;

                    mouseY1 += tTopPos;
                }
                else
                {
                    tTopPos = saveTopPos - curTopPos;

                    mouseY1 -= tTopPos;
                }

                saveTopPos = curTopPos;
            }
            if (saveLeftPos != curLeftPos)
            {
                if (curLeftPos > saveLeftPos)
                {
                    tLeftPos = curLeftPos - saveLeftPos;

                    mouseX1 += tLeftPos;
                }
                else
                {
                    tLeftPos = saveLeftPos - curLeftPos;

                    mouseX1 -= tLeftPos;
                }

                saveLeftPos = curLeftPos;
            }
        }

        private bool PotionLimit()
        {
            bool limt = false;

            switch (keyF123)
            {
                case 1:
                    if (checkBoxF1.Checked == true)
                        limt = true;
                    break;
                case 2:
                    if (checkBoxF2.Checked == true)
                        limt = true;
                    break;
                case 3:
                    if (checkBoxF3.Checked == true)
                        limt = true;
                    break;
                default:
                    limt = false;
                    break;
            }

            return limt;
        }

        private void MyKeyPress(string tS)
        {
            switch (tS)
            {
                case "F1":
                    keyF123 = 1;
                    break;

                case "F2":
                    keyF123 = 2;
                    break;

                case "F3":
                    keyF123 = 3;
                    break;

                case "F8":
                    PotionStop();
                    break;

                case "NumpadDiv":
                    saveTopPos = stRect.top;
                    saveLeftPos = stRect.left;

                    mouseX1 = Cursor.Position.X;
                    mouseY1 = Cursor.Position.Y;

                    saveColor1 = GetColorAt(mouseX1, mouseY1);
                    break;

                case "NumpadPro":
                    
                    break;

                case "NumpadSub":
                    PotionStart();
                    break;

                case "NumpadAdd":
                    PotionStop();
                    break;

                case "PageUp":
                    ChatStart();
                    break;

                case "PageDown":
                    ChatStop();
                break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyboardHooker.UnHook();
        }



        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }


        private void cbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbVersion.SelectedIndex >= 0)
            {
                versionSelected = cbVersion.SelectedItem as string;
            }
        }

        private void LblTextToString(string ts)
        {
            if ("h" == ts)
                lblH.Text = timerHour.ToString("D2");
            else if ("m" == ts)
                lblM.Text = timerMin.ToString("D2");
            else if ("s" == ts)
                lblS.Text = timerSec.ToString("D2");
        }

        private void TimerUpdate()
        {
            timerSec--;
            if (timerSec < 0)
            {
                timerMin--;
                timerSec = 59;

                if (timerMin < 0)
                {
                    timerHour--;
                    timerMin = 59;

                    if (timerHour <= 0)
                    {
                        timerHour = 0;
                    }
                }
            }
            LblTextToString("h");
            LblTextToString("m");
            LblTextToString("s");


            TimerAlarm();

            if (timerHour == 0 && timerMin == 0 && timerSec == 0)
            {
                timerflag = false;
                //MessageBox.Show("타이머가 종료되었습니다.", "확인", MessageBoxButtons.OK);

            }
        }

        private void TimerAlarm()
        {

            if (cb10m.Checked == true)
            {
                if (timerMin == 10 && timerSec == 0)
                {
                    saveCheck10m = cb10m.Checked;

                    //알람
                    cb10m.Checked = false;
                }
            }
            else if (cb5m.Checked == true)
            {
                if (timerMin == 5 && timerSec == 0)
                {
                    saveCheck5m = cb5m.Checked;

                    //알람
                    cb5m.Checked = false;
                }
            }
            else if (cb1m.Checked == true)
            {
                if (timerMin == 1 && timerSec == 0)
                {
                    saveCheck1m = cb1m.Checked;

                    //알람
                    cb1m.Checked = false;
                }
            }
            else if (cb0m.Checked == true)
            {
                if (timerMin == 0 && timerSec == 0)
                {
                    saveCheck0m = cb0m.Checked;

                    //알람
                    cb0m.Checked = false;
                }
            }

            if (timerHour == 0 && timerMin == 0 && timerSec == 0)
            {
                cb10m.Checked = saveCheck10m;
                cb5m.Checked = saveCheck5m;
                cb1m.Checked = saveCheck1m;
                cb0m.Checked = saveCheck0m;
            }

        }

        

        /// UI 함수들
        /// 
        ///
        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            if (timerflag == false)
            {
                timer1.Start();
                timerflag = true;

                timer1sec = 1000 / timer1.Interval;
            }
        }


        private void btn10s_Click(object sender, EventArgs e)
        {
            timerSec += 10;
            if (timerSec > 60)
            {
                timerSec -= 60;
                timerMin++;
            }
            LblTextToString("m");
            LblTextToString("s");
        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {
            timerflag = false;
        }

        private void btn1m_Click(object sender, EventArgs e)
        {
            timerMin += 1;
            if (timerMin > 60)
            {
                timerMin -= 60;
                timerHour++;
            }
            LblTextToString("m");
            LblTextToString("h");
        }

        private void btn30s_Click(object sender, EventArgs e)
        {
            timerSec += 30;
            if (timerSec > 60)
            {
                timerSec -= 60;
                timerMin++;
            }
            LblTextToString("m");
            LblTextToString("s");
        }

        private void btn10m_Click(object sender, EventArgs e)
        {
            timerMin += 10;
            if (timerMin > 60)
            {
                timerMin -= 60;
                timerHour++;
            }
            LblTextToString("m");
            LblTextToString("h");
        }

        private void btn30m_Click(object sender, EventArgs e)
        {
            timerMin += 30;
            if (timerMin > 60)
            {
                timerMin -= 60;
                timerHour++;
            }
            LblTextToString("m");
            LblTextToString("h");
        }

        private void btn1h_Click(object sender, EventArgs e)
        {
            timerHour += 1;

            LblTextToString("h");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            timerHour = 0;
            timerMin = 0;
            timerSec = 0;

            LblTextToString("s");
            LblTextToString("m");
            LblTextToString("h");
        }

        private void btn6h_Click(object sender, EventArgs e)
        {
            timerHour += 6;

            LblTextToString("h");
        }


        private void btnHUp_Click(object sender, EventArgs e)
        {
            timerHour++;

            LblTextToString("h");
        }

        private void btnMUp_Click(object sender, EventArgs e)
        {
            timerMin += 1;
            if (timerMin >= 60)
            {
                timerHour++;
                timerMin = 0;
            }

            LblTextToString("h");
            LblTextToString("m");
        }

        private void btnSUp_Click(object sender, EventArgs e)
        {
            timerSec += 1;
            if (timerSec >= 60)
            {
                timerMin++;
                timerSec = 0;
            }

            LblTextToString("m");
            LblTextToString("s");
        }

        private void btnHDown_Click(object sender, EventArgs e)
        {
            timerHour--;
            if (timerHour <= 0)
                timerHour = 0;

            LblTextToString("h");
        }

        private void btnMDown_Click(object sender, EventArgs e)
        {
            timerMin--;
            if (timerMin < 0)
            {
                timerMin = 59;

                if (timerHour >= 1)
                    timerHour--;
            }

            LblTextToString("h");
            LblTextToString("m");
        }

        private void btnSDown_Click(object sender, EventArgs e)
        {
            timerSec--;
            if (timerSec < 0)
            {
                timerSec = 59;

                if (timerMin >= 1)
                    timerMin--;
            }

            LblTextToString("m");
            LblTextToString("s");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ChatStart();



        }


        private bool chatFlag = false;
       

        private void ChatStart()
        {
            //SendKatalk(txtchat1.Text.ToString());
            if(chatFlag == false)
            {
                chatFlag = true;

                timer1.Start();

                
            }
            
        }

        private void ChatStop()
        {
            chatFlag = false;
        }


        private void cbchatdelay_SelectedIndexChanged(object sender, EventArgs e)
        {
            chatDelaySelected = int.Parse(cbchatdelay.SelectedItem as string);
        }

        private int nextChat = 0;

        private void ChatUpdate()
        {
            if (chkchat1.Checked == false && nextChat == 1)
                nextChat = 2;
            if (chkchat2.Checked == false && nextChat == 2)
                nextChat = 3;
            if (chkchat3.Checked == false && nextChat == 3)
                nextChat = 4;
            if (chkchat4.Checked == false && nextChat == 4)
                nextChat = 1;


            if (chkchat1.Checked == false && chkchat2.Checked == false
                && chkchat3.Checked == false && chkchat4.Checked == false)
            {
                ChatStop();
            }

            if (chatFlag == true)
            {
                if (nextChat == 1)
                {
                    SendKeys.Send(txtColor1.Text);
                    SendKeys.Send(txtchat1.Text);
                    SendKeys.Send("{Enter}");
                }
                else if (nextChat == 2)
                {
                    SendKeys.Send(txtColor2.Text);
                    SendKeys.Send(txtchat2.Text);
                    SendKeys.Send("{Enter}");
                }
                else if (nextChat == 3)
                {
                    SendKeys.Send(txtColor3.Text);
                    SendKeys.Send(txtchat3.Text);
                    SendKeys.Send("{Enter}");
                }
                else if (nextChat == 4)
                {
                    SendKeys.Send(txtColor4.Text);
                    SendKeys.Send(txtchat4.Text);
                    SendKeys.Send("{Enter}");
                }
            }


            nextChat++;
            if (nextChat == 5)
                nextChat = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatStop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPotionStart_Click(object sender, EventArgs e)
        {
            MyKeyPress("NumpadSub"); //시작 키                        
        }

        private void btnPotionStop_Click(object sender, EventArgs e)
        {
            MyKeyPress("NumpadAdd"); //멈춤 키
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        [DllImport("User32", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll")]
        public static extern int GetWindowRect(int hwnd, ref RECT lpRect);

        [DllImport("user32.dll")]
        //public static extern int SendMessage(int hWnd, int Msg, int wParam, string lParam);
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    }
}

