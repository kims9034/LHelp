namespace HELP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxF1 = new System.Windows.Forms.CheckBox();
            this.checkBoxF2 = new System.Windows.Forms.CheckBox();
            this.checkBoxF3 = new System.Windows.Forms.CheckBox();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn30s = new System.Windows.Forms.Button();
            this.btn10s = new System.Windows.Forms.Button();
            this.btn6h = new System.Windows.Forms.Button();
            this.btn1m = new System.Windows.Forms.Button();
            this.btn1h = new System.Windows.Forms.Button();
            this.btn10m = new System.Windows.Forms.Button();
            this.btn30m = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb0m = new System.Windows.Forms.CheckBox();
            this.cb1m = new System.Windows.Forms.CheckBox();
            this.cb5m = new System.Windows.Forms.CheckBox();
            this.cb10m = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSDown = new System.Windows.Forms.Button();
            this.btnSUp = new System.Windows.Forms.Button();
            this.lblS = new System.Windows.Forms.Label();
            this.btnMDown = new System.Windows.Forms.Button();
            this.btnHDown = new System.Windows.Forms.Button();
            this.btnMUp = new System.Windows.Forms.Button();
            this.btnHUp = new System.Windows.Forms.Button();
            this.btnTimerStop = new System.Windows.Forms.Button();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtColor4 = new System.Windows.Forms.TextBox();
            this.txtColor3 = new System.Windows.Forms.TextBox();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChatStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtchat4 = new System.Windows.Forms.TextBox();
            this.chkchat4 = new System.Windows.Forms.CheckBox();
            this.txtchat3 = new System.Windows.Forms.TextBox();
            this.chkchat3 = new System.Windows.Forms.CheckBox();
            this.txtchat2 = new System.Windows.Forms.TextBox();
            this.chkchat2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbchatdelay = new System.Windows.Forms.ComboBox();
            this.txtchat1 = new System.Windows.Forms.TextBox();
            this.chkchat1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPotionStop = new System.Windows.Forms.Button();
            this.btnPotionStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblChatDelay = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "대기중";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Update);
            // 
            // checkBoxF1
            // 
            this.checkBoxF1.AutoSize = true;
            this.checkBoxF1.Location = new System.Drawing.Point(6, 20);
            this.checkBoxF1.Name = "checkBoxF1";
            this.checkBoxF1.Size = new System.Drawing.Size(105, 16);
            this.checkBoxF1.TabIndex = 3;
            this.checkBoxF1.Text = "F1 일때 노물약";
            this.checkBoxF1.UseVisualStyleBackColor = true;
            // 
            // checkBoxF2
            // 
            this.checkBoxF2.AutoSize = true;
            this.checkBoxF2.Location = new System.Drawing.Point(6, 42);
            this.checkBoxF2.Name = "checkBoxF2";
            this.checkBoxF2.Size = new System.Drawing.Size(105, 16);
            this.checkBoxF2.TabIndex = 4;
            this.checkBoxF2.Text = "F2 일때 노물약";
            this.checkBoxF2.UseVisualStyleBackColor = true;
            // 
            // checkBoxF3
            // 
            this.checkBoxF3.AutoSize = true;
            this.checkBoxF3.Location = new System.Drawing.Point(6, 64);
            this.checkBoxF3.Name = "checkBoxF3";
            this.checkBoxF3.Size = new System.Drawing.Size(105, 16);
            this.checkBoxF3.TabIndex = 5;
            this.checkBoxF3.Text = "F3 일때 노물약";
            this.checkBoxF3.UseVisualStyleBackColor = true;
            // 
            // cbVersion
            // 
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(349, 29);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(105, 20);
            this.cbVersion.TabIndex = 6;
            this.cbVersion.SelectedIndexChanged += new System.EventHandler(this.cbVersion_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 327);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnSDown);
            this.tabPage1.Controls.Add(this.btnSUp);
            this.tabPage1.Controls.Add(this.lblS);
            this.tabPage1.Controls.Add(this.btnMDown);
            this.tabPage1.Controls.Add(this.btnHDown);
            this.tabPage1.Controls.Add(this.btnMUp);
            this.tabPage1.Controls.Add(this.btnHUp);
            this.tabPage1.Controls.Add(this.btnTimerStop);
            this.tabPage1.Controls.Add(this.btnTimerStart);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lblM);
            this.tabPage1.Controls.Add(this.lblH);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(464, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " 타이머 ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn30s);
            this.groupBox2.Controls.Add(this.btn10s);
            this.groupBox2.Controls.Add(this.btn6h);
            this.groupBox2.Controls.Add(this.btn1m);
            this.groupBox2.Controls.Add(this.btn1h);
            this.groupBox2.Controls.Add(this.btn10m);
            this.groupBox2.Controls.Add(this.btn30m);
            this.groupBox2.Location = new System.Drawing.Point(30, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 155);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "시간추가";
            // 
            // btn30s
            // 
            this.btn30s.Location = new System.Drawing.Point(100, 20);
            this.btn30s.Name = "btn30s";
            this.btn30s.Size = new System.Drawing.Size(81, 30);
            this.btn30s.TabIndex = 26;
            this.btn30s.Text = "+ 30초";
            this.btn30s.UseVisualStyleBackColor = true;
            this.btn30s.Click += new System.EventHandler(this.btn30s_Click);
            // 
            // btn10s
            // 
            this.btn10s.Location = new System.Drawing.Point(10, 20);
            this.btn10s.Name = "btn10s";
            this.btn10s.Size = new System.Drawing.Size(81, 30);
            this.btn10s.TabIndex = 25;
            this.btn10s.Text = "+ 10초";
            this.btn10s.UseVisualStyleBackColor = true;
            this.btn10s.Click += new System.EventHandler(this.btn10s_Click);
            // 
            // btn6h
            // 
            this.btn6h.Location = new System.Drawing.Point(190, 118);
            this.btn6h.Name = "btn6h";
            this.btn6h.Size = new System.Drawing.Size(81, 30);
            this.btn6h.TabIndex = 31;
            this.btn6h.Text = "+ 6시간";
            this.btn6h.UseVisualStyleBackColor = true;
            this.btn6h.Click += new System.EventHandler(this.btn6h_Click);
            // 
            // btn1m
            // 
            this.btn1m.Location = new System.Drawing.Point(10, 67);
            this.btn1m.Name = "btn1m";
            this.btn1m.Size = new System.Drawing.Size(81, 30);
            this.btn1m.TabIndex = 27;
            this.btn1m.Text = "+ 1분";
            this.btn1m.UseVisualStyleBackColor = true;
            this.btn1m.Click += new System.EventHandler(this.btn1m_Click);
            // 
            // btn1h
            // 
            this.btn1h.Location = new System.Drawing.Point(10, 118);
            this.btn1h.Name = "btn1h";
            this.btn1h.Size = new System.Drawing.Size(81, 30);
            this.btn1h.TabIndex = 30;
            this.btn1h.Text = "+ 1시간";
            this.btn1h.UseVisualStyleBackColor = true;
            this.btn1h.Click += new System.EventHandler(this.btn1h_Click);
            // 
            // btn10m
            // 
            this.btn10m.Location = new System.Drawing.Point(100, 67);
            this.btn10m.Name = "btn10m";
            this.btn10m.Size = new System.Drawing.Size(81, 30);
            this.btn10m.TabIndex = 28;
            this.btn10m.Text = "+ 10분";
            this.btn10m.UseVisualStyleBackColor = true;
            this.btn10m.Click += new System.EventHandler(this.btn10m_Click);
            // 
            // btn30m
            // 
            this.btn30m.Location = new System.Drawing.Point(190, 67);
            this.btn30m.Name = "btn30m";
            this.btn30m.Size = new System.Drawing.Size(81, 30);
            this.btn30m.TabIndex = 29;
            this.btn30m.Text = "+ 30분";
            this.btn30m.UseVisualStyleBackColor = true;
            this.btn30m.Click += new System.EventHandler(this.btn30m_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb0m);
            this.groupBox1.Controls.Add(this.cb1m);
            this.groupBox1.Controls.Add(this.cb5m);
            this.groupBox1.Controls.Add(this.cb10m);
            this.groupBox1.Location = new System.Drawing.Point(6, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 55);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "알람설정";
            // 
            // cb0m
            // 
            this.cb0m.AutoSize = true;
            this.cb0m.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb0m.Location = new System.Drawing.Point(307, 20);
            this.cb0m.Name = "cb0m";
            this.cb0m.Size = new System.Drawing.Size(77, 28);
            this.cb0m.TabIndex = 35;
            this.cb0m.Text = "정각";
            this.cb0m.UseVisualStyleBackColor = true;
            // 
            // cb1m
            // 
            this.cb1m.AutoSize = true;
            this.cb1m.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb1m.Location = new System.Drawing.Point(211, 20);
            this.cb1m.Name = "cb1m";
            this.cb1m.Size = new System.Drawing.Size(90, 28);
            this.cb1m.TabIndex = 34;
            this.cb1m.Text = "1분전";
            this.cb1m.UseVisualStyleBackColor = true;
            // 
            // cb5m
            // 
            this.cb5m.AutoSize = true;
            this.cb5m.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb5m.Location = new System.Drawing.Point(115, 20);
            this.cb5m.Name = "cb5m";
            this.cb5m.Size = new System.Drawing.Size(90, 28);
            this.cb5m.TabIndex = 33;
            this.cb5m.Text = "5분전";
            this.cb5m.UseVisualStyleBackColor = true;
            // 
            // cb10m
            // 
            this.cb10m.AutoSize = true;
            this.cb10m.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb10m.Location = new System.Drawing.Point(6, 20);
            this.cb10m.Name = "cb10m";
            this.cb10m.Size = new System.Drawing.Size(103, 28);
            this.cb10m.TabIndex = 32;
            this.cb10m.Text = "10분전";
            this.cb10m.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(355, 162);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 71);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "시간초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSDown
            // 
            this.btnSDown.Location = new System.Drawing.Point(303, 56);
            this.btnSDown.Name = "btnSDown";
            this.btnSDown.Size = new System.Drawing.Size(23, 25);
            this.btnSDown.TabIndex = 23;
            this.btnSDown.Text = "▼";
            this.btnSDown.UseVisualStyleBackColor = true;
            this.btnSDown.Click += new System.EventHandler(this.btnSDown_Click);
            // 
            // btnSUp
            // 
            this.btnSUp.Location = new System.Drawing.Point(303, 34);
            this.btnSUp.Name = "btnSUp";
            this.btnSUp.Size = new System.Drawing.Size(23, 25);
            this.btnSUp.TabIndex = 22;
            this.btnSUp.Text = "▲";
            this.btnSUp.UseVisualStyleBackColor = true;
            this.btnSUp.Click += new System.EventHandler(this.btnSUp_Click);
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("휴먼모음T", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblS.Location = new System.Drawing.Point(238, 33);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(70, 48);
            this.lblS.TabIndex = 21;
            this.lblS.Text = "00";
            // 
            // btnMDown
            // 
            this.btnMDown.Location = new System.Drawing.Point(188, 54);
            this.btnMDown.Name = "btnMDown";
            this.btnMDown.Size = new System.Drawing.Size(23, 25);
            this.btnMDown.TabIndex = 19;
            this.btnMDown.Text = "▼";
            this.btnMDown.UseVisualStyleBackColor = true;
            this.btnMDown.Click += new System.EventHandler(this.btnMDown_Click);
            // 
            // btnHDown
            // 
            this.btnHDown.Location = new System.Drawing.Point(88, 54);
            this.btnHDown.Name = "btnHDown";
            this.btnHDown.Size = new System.Drawing.Size(23, 25);
            this.btnHDown.TabIndex = 18;
            this.btnHDown.Text = "▼";
            this.btnHDown.UseVisualStyleBackColor = true;
            this.btnHDown.Click += new System.EventHandler(this.btnHDown_Click);
            // 
            // btnMUp
            // 
            this.btnMUp.Location = new System.Drawing.Point(188, 32);
            this.btnMUp.Name = "btnMUp";
            this.btnMUp.Size = new System.Drawing.Size(23, 25);
            this.btnMUp.TabIndex = 16;
            this.btnMUp.Text = "▲";
            this.btnMUp.UseVisualStyleBackColor = true;
            this.btnMUp.Click += new System.EventHandler(this.btnMUp_Click);
            // 
            // btnHUp
            // 
            this.btnHUp.Location = new System.Drawing.Point(88, 32);
            this.btnHUp.Name = "btnHUp";
            this.btnHUp.Size = new System.Drawing.Size(23, 25);
            this.btnHUp.TabIndex = 15;
            this.btnHUp.Text = "▲";
            this.btnHUp.UseVisualStyleBackColor = true;
            this.btnHUp.Click += new System.EventHandler(this.btnHUp_Click);
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.Location = new System.Drawing.Point(355, 85);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(103, 71);
            this.btnTimerStop.TabIndex = 14;
            this.btnTimerStop.Text = "정지";
            this.btnTimerStop.UseVisualStyleBackColor = true;
            this.btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.Location = new System.Drawing.Point(355, 8);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(103, 71);
            this.btnTimerStart.TabIndex = 8;
            this.btnTimerStart.Text = "시작";
            this.btnTimerStart.UseVisualStyleBackColor = true;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "초";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "분";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "시간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼모음T", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(217, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 48);
            this.label7.TabIndex = 10;
            this.label7.Text = ".";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("휴먼모음T", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblM.Location = new System.Drawing.Point(124, 33);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(70, 48);
            this.lblM.TabIndex = 9;
            this.lblM.Text = "00";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("휴먼모음T", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblH.Location = new System.Drawing.Point(22, 33);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(70, 48);
            this.lblH.TabIndex = 8;
            this.lblH.Text = "00";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.lblChatDelay);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtColor4);
            this.tabPage3.Controls.Add(this.txtColor3);
            this.tabPage3.Controls.Add(this.txtColor2);
            this.tabPage3.Controls.Add(this.txtColor1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btnChatStart);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtchat4);
            this.tabPage3.Controls.Add(this.chkchat4);
            this.tabPage3.Controls.Add(this.txtchat3);
            this.tabPage3.Controls.Add(this.chkchat3);
            this.tabPage3.Controls.Add(this.txtchat2);
            this.tabPage3.Controls.Add(this.chkchat2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cbchatdelay);
            this.tabPage3.Controls.Add(this.txtchat1);
            this.tabPage3.Controls.Add(this.chkchat1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(464, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "채팅매크로";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(382, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 12);
            this.label15.TabIndex = 27;
            this.label15.Text = "PageDown";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "PageUp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "단축키";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "영어로 칠것 ex) 팝니다 -> vkqslek";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "색상 미구현";
            // 
            // txtColor4
            // 
            this.txtColor4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtColor4.Location = new System.Drawing.Point(67, 253);
            this.txtColor4.Name = "txtColor4";
            this.txtColor4.Size = new System.Drawing.Size(86, 29);
            this.txtColor4.TabIndex = 22;
            this.txtColor4.Text = "&";
            // 
            // txtColor3
            // 
            this.txtColor3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtColor3.Location = new System.Drawing.Point(67, 203);
            this.txtColor3.Name = "txtColor3";
            this.txtColor3.Size = new System.Drawing.Size(86, 29);
            this.txtColor3.TabIndex = 21;
            this.txtColor3.Text = "&";
            // 
            // txtColor2
            // 
            this.txtColor2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtColor2.Location = new System.Drawing.Point(67, 152);
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(86, 29);
            this.txtColor2.TabIndex = 20;
            this.txtColor2.Text = "&";
            // 
            // txtColor1
            // 
            this.txtColor1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtColor1.Location = new System.Drawing.Point(67, 100);
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(86, 29);
            this.txtColor1.TabIndex = 19;
            this.txtColor1.Text = "&";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "정지";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChatStart
            // 
            this.btnChatStart.Location = new System.Drawing.Point(290, 11);
            this.btnChatStart.Name = "btnChatStart";
            this.btnChatStart.Size = new System.Drawing.Size(76, 42);
            this.btnChatStart.TabIndex = 16;
            this.btnChatStart.Text = "시작";
            this.btnChatStart.UseVisualStyleBackColor = true;
            this.btnChatStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "초";
            // 
            // txtchat4
            // 
            this.txtchat4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtchat4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtchat4.Location = new System.Drawing.Point(169, 253);
            this.txtchat4.Name = "txtchat4";
            this.txtchat4.Size = new System.Drawing.Size(289, 29);
            this.txtchat4.TabIndex = 14;
            // 
            // chkchat4
            // 
            this.chkchat4.AutoSize = true;
            this.chkchat4.Location = new System.Drawing.Point(19, 261);
            this.chkchat4.Name = "chkchat4";
            this.chkchat4.Size = new System.Drawing.Size(42, 16);
            this.chkchat4.TabIndex = 13;
            this.chkchat4.Text = "4번";
            this.chkchat4.UseVisualStyleBackColor = true;
            // 
            // txtchat3
            // 
            this.txtchat3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtchat3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtchat3.Location = new System.Drawing.Point(169, 203);
            this.txtchat3.Name = "txtchat3";
            this.txtchat3.Size = new System.Drawing.Size(289, 29);
            this.txtchat3.TabIndex = 12;
            // 
            // chkchat3
            // 
            this.chkchat3.AutoSize = true;
            this.chkchat3.Location = new System.Drawing.Point(19, 211);
            this.chkchat3.Name = "chkchat3";
            this.chkchat3.Size = new System.Drawing.Size(42, 16);
            this.chkchat3.TabIndex = 11;
            this.chkchat3.Text = "3번";
            this.chkchat3.UseVisualStyleBackColor = true;
            // 
            // txtchat2
            // 
            this.txtchat2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtchat2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtchat2.Location = new System.Drawing.Point(169, 152);
            this.txtchat2.Name = "txtchat2";
            this.txtchat2.Size = new System.Drawing.Size(289, 29);
            this.txtchat2.TabIndex = 10;
            // 
            // chkchat2
            // 
            this.chkchat2.AutoSize = true;
            this.chkchat2.Location = new System.Drawing.Point(19, 160);
            this.chkchat2.Name = "chkchat2";
            this.chkchat2.Size = new System.Drawing.Size(42, 16);
            this.chkchat2.TabIndex = 9;
            this.chkchat2.Text = "2번";
            this.chkchat2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "채팅 딜레이";
            // 
            // cbchatdelay
            // 
            this.cbchatdelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbchatdelay.FormattingEnabled = true;
            this.cbchatdelay.Location = new System.Drawing.Point(96, 23);
            this.cbchatdelay.Name = "cbchatdelay";
            this.cbchatdelay.Size = new System.Drawing.Size(57, 20);
            this.cbchatdelay.TabIndex = 2;
            this.cbchatdelay.SelectedIndexChanged += new System.EventHandler(this.cbchatdelay_SelectedIndexChanged);
            // 
            // txtchat1
            // 
            this.txtchat1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtchat1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtchat1.Location = new System.Drawing.Point(169, 100);
            this.txtchat1.Name = "txtchat1";
            this.txtchat1.Size = new System.Drawing.Size(289, 29);
            this.txtchat1.TabIndex = 1;
            // 
            // chkchat1
            // 
            this.chkchat1.AutoSize = true;
            this.chkchat1.Location = new System.Drawing.Point(19, 108);
            this.chkchat1.Name = "chkchat1";
            this.chkchat1.Size = new System.Drawing.Size(42, 16);
            this.chkchat1.TabIndex = 0;
            this.chkchat1.Text = "1번";
            this.chkchat1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btnPotionStop);
            this.tabPage2.Controls.Add(this.btnPotionStart);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbVersion);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(464, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " 물 약 ";
            // 
            // btnPotionStop
            // 
            this.btnPotionStop.Location = new System.Drawing.Point(23, 191);
            this.btnPotionStop.Name = "btnPotionStop";
            this.btnPotionStop.Size = new System.Drawing.Size(75, 47);
            this.btnPotionStop.TabIndex = 10;
            this.btnPotionStop.Text = "정지";
            this.btnPotionStop.UseVisualStyleBackColor = true;
            this.btnPotionStop.Click += new System.EventHandler(this.btnPotionStop_Click);
            // 
            // btnPotionStart
            // 
            this.btnPotionStart.Location = new System.Drawing.Point(23, 132);
            this.btnPotionStart.Name = "btnPotionStart";
            this.btnPotionStart.Size = new System.Drawing.Size(75, 47);
            this.btnPotionStart.TabIndex = 9;
            this.btnPotionStart.Text = "시작";
            this.btnPotionStart.UseVisualStyleBackColor = true;
            this.btnPotionStart.Click += new System.EventHandler(this.btnPotionStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxF2);
            this.groupBox3.Controls.Add(this.checkBoxF1);
            this.groupBox3.Controls.Add(this.checkBoxF3);
            this.groupBox3.Location = new System.Drawing.Point(341, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 91);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "특수 기능";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "게임 버전";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numpad -";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(104, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(73, 120);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "단축키";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Numpad +";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(23, 61);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(150, 52);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "물약지정단축키";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "마우스 주차후 Numpad /";
            // 
            // lblChatDelay
            // 
            this.lblChatDelay.AutoSize = true;
            this.lblChatDelay.Location = new System.Drawing.Point(65, 56);
            this.lblChatDelay.Name = "lblChatDelay";
            this.lblChatDelay.Size = new System.Drawing.Size(0, 12);
            this.lblChatDelay.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 339);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "HELP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxF1;
        private System.Windows.Forms.CheckBox checkBoxF2;
        private System.Windows.Forms.CheckBox checkBoxF3;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Button btnMDown;
        private System.Windows.Forms.Button btnHDown;
        private System.Windows.Forms.Button btnMUp;
        private System.Windows.Forms.Button btnHUp;
        private System.Windows.Forms.Button btnTimerStop;
        private System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn30s;
        private System.Windows.Forms.Button btn10s;
        private System.Windows.Forms.Button btn6h;
        private System.Windows.Forms.Button btn1m;
        private System.Windows.Forms.Button btn1h;
        private System.Windows.Forms.Button btn10m;
        private System.Windows.Forms.Button btn30m;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb0m;
        private System.Windows.Forms.CheckBox cb1m;
        private System.Windows.Forms.CheckBox cb5m;
        private System.Windows.Forms.CheckBox cb10m;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSDown;
        private System.Windows.Forms.Button btnSUp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbchatdelay;
        private System.Windows.Forms.TextBox txtchat1;
        private System.Windows.Forms.CheckBox chkchat1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtchat4;
        private System.Windows.Forms.CheckBox chkchat4;
        private System.Windows.Forms.TextBox txtchat3;
        private System.Windows.Forms.CheckBox chkchat3;
        private System.Windows.Forms.TextBox txtchat2;
        private System.Windows.Forms.CheckBox chkchat2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChatStart;
        private System.Windows.Forms.TextBox txtColor4;
        private System.Windows.Forms.TextBox txtColor3;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPotionStop;
        private System.Windows.Forms.Button btnPotionStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChatDelay;
    }
}

