namespace KVALIFA
{
    partial class frmCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourse));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pctHelp = new System.Windows.Forms.PictureBox();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.timerPlus = new System.Windows.Forms.Timer(this.components);
            this.timerMinus = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lblGivenFun = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn1_Main = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt1_A = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn2_Main = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt2_A = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn3_Main = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt3_A = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn4_Main = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt4_A = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.PB = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.pnlLeft.Controls.Add(this.pctHelp);
            this.pnlLeft.Controls.Add(this.pctExit);
            this.pnlLeft.Controls.Add(this.lbl4);
            this.pnlLeft.Controls.Add(this.lbl3);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.lbl2);
            this.pnlLeft.Controls.Add(this.lbl1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 760);
            this.pnlLeft.TabIndex = 1;
            // 
            // pctHelp
            // 
            this.pctHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctHelp.Image = ((System.Drawing.Image)(resources.GetObject("pctHelp.Image")));
            this.pctHelp.Location = new System.Drawing.Point(113, 653);
            this.pctHelp.Name = "pctHelp";
            this.pctHelp.Size = new System.Drawing.Size(80, 80);
            this.pctHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHelp.TabIndex = 6;
            this.pctHelp.TabStop = false;
            this.pctHelp.Click += new System.EventHandler(this.pctHelp_Click);
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(7, 643);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(100, 100);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 5;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl4.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl4.ForeColor = System.Drawing.Color.Black;
            this.lbl4.Location = new System.Drawing.Point(10, 260);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(190, 51);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "||x| - |y|| > a";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            this.lbl4.MouseEnter += new System.EventHandler(this.lbl4_MouseEnter);
            this.lbl4.MouseLeave += new System.EventHandler(this.lbl4_MouseLeave);
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl3.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(10, 209);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(190, 51);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "|x| + |y| ≤ a";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            this.lbl3.MouseEnter += new System.EventHandler(this.lbl3_MouseEnter);
            this.lbl3.MouseLeave += new System.EventHandler(this.lbl3_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 87);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оберіть нерівність";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(10, 158);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(190, 51);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "|y| ≥ x³ + a";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            this.lbl2.MouseEnter += new System.EventHandler(this.lbl2_MouseEnter);
            this.lbl2.MouseLeave += new System.EventHandler(this.lbl2_MouseLeave);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(16, 107);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(184, 51);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "y ≥ ax";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl1.Click += new System.EventHandler(this.lblLinFun_Click);
            this.lbl1.MouseEnter += new System.EventHandler(this.lbl1_MouseEnter);
            this.lbl1.MouseLeave += new System.EventHandler(this.lbl1_MouseLeave);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.pnlTop.Controls.Add(this.pctClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 15);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmOneGraphics_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmOneGraphics_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmOneGraphics_MouseUp);
            // 
            // pctClose
            // 
            this.pctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pctClose.Image = ((System.Drawing.Image)(resources.GetObject("pctClose.Image")));
            this.pctClose.Location = new System.Drawing.Point(985, 0);
            this.pctClose.Margin = new System.Windows.Forms.Padding(5);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(15, 15);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctClose.TabIndex = 0;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.pctClose_Click);
            this.pctClose.MouseEnter += new System.EventHandler(this.pctClose_MouseEnter);
            this.pctClose.MouseLeave += new System.EventHandler(this.pctClose_MouseLeave);
            // 
            // timerPlus
            // 
            this.timerPlus.Interval = 10;
            this.timerPlus.Tick += new System.EventHandler(this.timerPlus_Tick);
            // 
            // timerMinus
            // 
            this.timerMinus.Interval = 10;
            this.timerMinus.Tick += new System.EventHandler(this.timerMinus_Tick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(206, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(982, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "Побудувати графік нерівності";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGivenFun
            // 
            this.lblGivenFun.BackColor = System.Drawing.Color.Transparent;
            this.lblGivenFun.Font = new System.Drawing.Font("Times New Roman", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblGivenFun.ForeColor = System.Drawing.Color.Black;
            this.lblGivenFun.Location = new System.Drawing.Point(522, 45);
            this.lblGivenFun.Name = "lblGivenFun";
            this.lblGivenFun.Size = new System.Drawing.Size(666, 35);
            this.lblGivenFun.TabIndex = 11;
            this.lblGivenFun.Text = "Задана нерівність  ";
            this.lblGivenFun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGivenFun.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Minus);
            this.panel1.Controls.Add(this.btn_Plus);
            this.panel1.Controls.Add(this.btn1_Main);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(206, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 127);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.btn_Minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minus.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Minus.ForeColor = System.Drawing.Color.Black;
            this.btn_Minus.Location = new System.Drawing.Point(272, 82);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(35, 35);
            this.btn_Minus.TabIndex = 16;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = false;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.btn_Plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Plus.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Plus.ForeColor = System.Drawing.Color.Black;
            this.btn_Plus.Location = new System.Drawing.Point(3, 82);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(35, 35);
            this.btn_Plus.TabIndex = 15;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = false;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn1_Main
            // 
            this.btn1_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.btn1_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1_Main.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btn1_Main.ForeColor = System.Drawing.Color.Black;
            this.btn1_Main.Location = new System.Drawing.Point(49, 82);
            this.btn1_Main.Name = "btn1_Main";
            this.btn1_Main.Size = new System.Drawing.Size(212, 35);
            this.btn1_Main.TabIndex = 14;
            this.btn1_Main.Text = "Побудувати";
            this.btn1_Main.UseVisualStyleBackColor = false;
            this.btn1_Main.Click += new System.EventHandler(this.btn1_Main_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt1_A);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введіть параметр:";
            // 
            // txt1_A
            // 
            this.txt1_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(184)))));
            this.txt1_A.Location = new System.Drawing.Point(59, 31);
            this.txt1_A.Name = "txt1_A";
            this.txt1_A.Size = new System.Drawing.Size(62, 32);
            this.txt1_A.TabIndex = 1;
            this.txt1_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_A_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "a = ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn2_Main);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(541, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 127);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(272, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(3, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn2_Main
            // 
            this.btn2_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.btn2_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2_Main.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btn2_Main.ForeColor = System.Drawing.Color.Black;
            this.btn2_Main.Location = new System.Drawing.Point(49, 82);
            this.btn2_Main.Name = "btn2_Main";
            this.btn2_Main.Size = new System.Drawing.Size(212, 35);
            this.btn2_Main.TabIndex = 14;
            this.btn2_Main.Text = "Побудувати";
            this.btn2_Main.UseVisualStyleBackColor = false;
            this.btn2_Main.Click += new System.EventHandler(this.btn2_Main_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt2_A);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 73);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введіть параметр:";
            // 
            // txt2_A
            // 
            this.txt2_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(184)))));
            this.txt2_A.Location = new System.Drawing.Point(59, 31);
            this.txt2_A.Name = "txt2_A";
            this.txt2_A.Size = new System.Drawing.Size(62, 32);
            this.txt2_A.TabIndex = 1;
            this.txt2_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_A_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "a = ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.btn3_Main);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(541, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 127);
            this.panel3.TabIndex = 18;
            this.panel3.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(272, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 16;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(3, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 15;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn3_Main
            // 
            this.btn3_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.btn3_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3_Main.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btn3_Main.ForeColor = System.Drawing.Color.Black;
            this.btn3_Main.Location = new System.Drawing.Point(49, 82);
            this.btn3_Main.Name = "btn3_Main";
            this.btn3_Main.Size = new System.Drawing.Size(212, 35);
            this.btn3_Main.TabIndex = 14;
            this.btn3_Main.Text = "Побудувати";
            this.btn3_Main.UseVisualStyleBackColor = false;
            this.btn3_Main.Click += new System.EventHandler(this.btn3_Main_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt3_A);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 73);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Введіть параметр:";
            // 
            // txt3_A
            // 
            this.txt3_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(184)))));
            this.txt3_A.Location = new System.Drawing.Point(59, 31);
            this.txt3_A.Name = "txt3_A";
            this.txt3_A.Size = new System.Drawing.Size(62, 32);
            this.txt3_A.TabIndex = 1;
            this.txt3_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_A_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "a = ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.btn4_Main);
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Location = new System.Drawing.Point(541, 506);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 127);
            this.panel4.TabIndex = 19;
            this.panel4.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(272, 82);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 16;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(3, 82);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 15;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn4_Main
            // 
            this.btn4_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.btn4_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4_Main.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btn4_Main.ForeColor = System.Drawing.Color.Black;
            this.btn4_Main.Location = new System.Drawing.Point(49, 82);
            this.btn4_Main.Name = "btn4_Main";
            this.btn4_Main.Size = new System.Drawing.Size(212, 35);
            this.btn4_Main.TabIndex = 14;
            this.btn4_Main.Text = "Побудувати";
            this.btn4_Main.UseVisualStyleBackColor = false;
            this.btn4_Main.Click += new System.EventHandler(this.btn4_Main_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt4_A);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 73);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Введіть параметр:";
            // 
            // txt4_A
            // 
            this.txt4_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(184)))));
            this.txt4_A.Location = new System.Drawing.Point(59, 31);
            this.txt4_A.Name = "txt4_A";
            this.txt4_A.Size = new System.Drawing.Size(62, 32);
            this.txt4_A.TabIndex = 1;
            this.txt4_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_A_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "a = ";
            // 
            // lblOutput
            // 
            this.lblOutput.AllowDrop = true;
            this.lblOutput.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblOutput.Location = new System.Drawing.Point(206, 212);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(310, 481);
            this.lblOutput.TabIndex = 20;
            this.lblOutput.Text = "Відповідь:";
            this.lblOutput.Visible = false;
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(522, 82);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(666, 666);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 4;
            this.PB.TabStop = false;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblGivenFun);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCourse";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Timer timerPlus;
        private System.Windows.Forms.Timer timerMinus;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGivenFun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt1_A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn1_Main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn2_Main;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt2_A;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn3_Main;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt3_A;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn4_Main;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt4_A;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox pctHelp;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}