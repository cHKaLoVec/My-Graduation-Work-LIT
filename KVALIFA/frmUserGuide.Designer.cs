namespace KVALIFA
{
    partial class frmUserGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserGuide));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.timerPlus = new System.Windows.Forms.Timer(this.components);
            this.timerMinus = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.pnlTop.TabIndex = 4;
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
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Controls.Add(this.pctExit);
            this.pnlLeft.Controls.Add(this.lbl3);
            this.pnlLeft.Controls.Add(this.lbl2);
            this.pnlLeft.Controls.Add(this.lbl1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(100, 760);
            this.pnlLeft.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 87);
            this.label1.TabIndex = 16;
            this.label1.Text = "Оберіть розділ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::KVALIFA.Properties.Resources.table_of_content__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(12, 668);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(80, 80);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 5;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(12, 316);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(548, 79);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Знаходження площ фігур, \r\nобмежених двома графіками функцій";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl3.Visible = false;
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(10, 233);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(550, 83);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Знаходження площ фігур, \r\nобмежених одним графікоми функції";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl2.Visible = false;
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(12, 182);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(548, 51);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Розв\'язування нерівностей";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl1.Visible = false;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
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
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(100, 15);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1100, 745);
            this.webBrowser1.TabIndex = 5;
            // 
            // frmUserGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(249)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Guide";
            this.Load += new System.EventHandler(this.frmUserGuide_Load);
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
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerPlus;
        private System.Windows.Forms.Timer timerMinus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}