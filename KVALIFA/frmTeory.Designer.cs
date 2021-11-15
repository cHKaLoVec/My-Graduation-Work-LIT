namespace KVALIFA
{
    partial class frmTeory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeory));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblVysnovok = new System.Windows.Forms.Label();
            this.lblTeory = new System.Windows.Forms.Label();
            this.lblVstup = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerMinus = new System.Windows.Forms.Timer(this.components);
            this.timerPlus = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.pnlTop.Controls.Add(this.pctClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(100, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 15);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmOneGraphics_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmOneGraphics_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmOneGraphics_MouseUp);
            // 
            // pctClose
            // 
            this.pctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pctClose.Image = ((System.Drawing.Image)(resources.GetObject("pctClose.Image")));
            this.pctClose.Location = new System.Drawing.Point(1085, 0);
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
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.pnlLeft.Controls.Add(this.lblVysnovok);
            this.pnlLeft.Controls.Add(this.lblTeory);
            this.pnlLeft.Controls.Add(this.lblVstup);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.pctExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(100, 760);
            this.pnlLeft.TabIndex = 2;
            this.pnlLeft.Leave += new System.EventHandler(this.pnlLeft_Leave);
            this.pnlLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLeft_MouseDown);
            this.pnlLeft.MouseEnter += new System.EventHandler(this.pnlLeft_MouseEnter);
            this.pnlLeft.MouseLeave += new System.EventHandler(this.pnlLeft_MouseLeave);
            // 
            // lblVysnovok
            // 
            this.lblVysnovok.BackColor = System.Drawing.Color.Transparent;
            this.lblVysnovok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVysnovok.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVysnovok.ForeColor = System.Drawing.Color.Black;
            this.lblVysnovok.Location = new System.Drawing.Point(4, 355);
            this.lblVysnovok.Name = "lblVysnovok";
            this.lblVysnovok.Size = new System.Drawing.Size(286, 51);
            this.lblVysnovok.TabIndex = 18;
            this.lblVysnovok.Text = "Висновок";
            this.lblVysnovok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVysnovok.Visible = false;
            this.lblVysnovok.Click += new System.EventHandler(this.lblVysnovok_Click);
            // 
            // lblTeory
            // 
            this.lblTeory.BackColor = System.Drawing.Color.Transparent;
            this.lblTeory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTeory.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeory.ForeColor = System.Drawing.Color.Black;
            this.lblTeory.Location = new System.Drawing.Point(4, 304);
            this.lblTeory.Name = "lblTeory";
            this.lblTeory.Size = new System.Drawing.Size(286, 51);
            this.lblTeory.TabIndex = 17;
            this.lblTeory.Text = "Теоретична частина";
            this.lblTeory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTeory.Visible = false;
            this.lblTeory.Click += new System.EventHandler(this.lblTeory_Click);
            // 
            // lblVstup
            // 
            this.lblVstup.BackColor = System.Drawing.Color.Transparent;
            this.lblVstup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVstup.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVstup.ForeColor = System.Drawing.Color.Black;
            this.lblVstup.Location = new System.Drawing.Point(4, 253);
            this.lblVstup.Name = "lblVstup";
            this.lblVstup.Size = new System.Drawing.Size(286, 51);
            this.lblVstup.TabIndex = 16;
            this.lblVstup.Text = "Вступ";
            this.lblVstup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVstup.Visible = false;
            this.lblVstup.Click += new System.EventHandler(this.lblVstup_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(4, 202);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 51);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Титульна сторінка";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Visible = false;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::KVALIFA.Properties.Resources.table_of_content__1_;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 87);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 87);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оберіть розділ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(12, 668);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(80, 80);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 12;
            this.pctExit.TabStop = false;
            this.pctExit.ClientSizeChanged += new System.EventHandler(this.pctExit_ClientSizeChanged);
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // timerMinus
            // 
            this.timerMinus.Interval = 10;
            this.timerMinus.Tick += new System.EventHandler(this.timerMinus_Tick);
            // 
            // timerPlus
            // 
            this.timerPlus.Interval = 10;
            this.timerPlus.Tick += new System.EventHandler(this.timerPlus_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(100, 15);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1100, 745);
            this.webBrowser1.TabIndex = 16;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmTeory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTeory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teory";
            this.Load += new System.EventHandler(this.frmTeory_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timerMinus;
        private System.Windows.Forms.Timer timerPlus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lblVysnovok;
        private System.Windows.Forms.Label lblTeory;
        private System.Windows.Forms.Label lblVstup;
        private System.Windows.Forms.Timer timer2;
    }
}