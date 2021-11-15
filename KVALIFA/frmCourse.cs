using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVALIFA
{
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        bool ner1 = false;
        bool ner2 = false;
        bool ner3 = false;
        bool ner4 = false;
        Pen myPen;
        Graphics gr;
        Bitmap bitmap;
        double x1 = -10, x2 = 10, y1 = -10, y2 = 10, h, x, y, a, b;
        int i1, i2, j1, j2, n;

        int xtoi(double x)
        {
            int ii;
            ii = i1 + (int)Math.Truncate((x - x1) * ((i2 - i1) / (x2 - x1)));
            return ii;
        }

        int ytoj(double y)
        {
            int jj;
            jj = j2 + (int)Math.Truncate((y - y1) * (j1 - j2) / (y2 - y1));
            return jj;
        }

        void system_koordinat(double x1, double x2, double y1, double y2)
        {
            Font myFont = new Font("Times New Roman", 12, FontStyle.Italic);
            Pen pen_setka = new Pen(Brushes.LightBlue, 1);
            pen_setka.DashStyle = DashStyle.Dash;
            for (int p = (int)x1; p <= (int)x2; p++)
            {
                gr.DrawLine(pen_setka, xtoi(p), ytoj(y2), xtoi(p), ytoj(y1));
            }
            for (int p = (int)y1; p <= (int)y2; p++)
            {
                gr.DrawLine(pen_setka, xtoi(x1), ytoj(p), xtoi(x2), ytoj(p));
            }
            Pen pen_os = new Pen(Brushes.Blue, 1);
            pen_os.EndCap = LineCap.ArrowAnchor;
            pen_os.StartCap = LineCap.Triangle;

            gr.DrawLine(pen_os, xtoi(x1), ytoj(0), xtoi(x2), ytoj(0));
            gr.DrawLine(pen_os, xtoi(0), ytoj(y1), xtoi(0), ytoj(y2));

            Font MyFont = new Font("Times New Roman", 8, FontStyle.Regular);
            for (int p = 1; p <= x2; p++)
                gr.DrawString(Convert.ToString(p), MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
            for (int p = -1; p >= x1; p--)
                gr.DrawString(Convert.ToString(p), MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
            for (int p = 0; p <= y2; p++)
                gr.DrawString(Convert.ToString(p), MyFont, Brushes.Blue, new Point(xtoi(-0.5), ytoj(p + 0.1)));
            for (int p = -1; p >= y1; p--)
                gr.DrawString(Convert.ToString(p), MyFont, Brushes.Blue, new Point(xtoi(-0.6), ytoj(p + 0.1)));
            gr.DrawString("x", myFont, Brushes.Blue, xtoi(x2 - 0.5), ytoj(-0.2));
            gr.DrawString("y", myFont, Brushes.Blue, xtoi(-0.8), ytoj(y2 - 0.2));
        }

        private bool isDragging = false;

        private Point lastCursor;
        private Point lastForm;

        private void frmOneGraphics_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;

            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void frmOneGraphics_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }

        private void frmOneGraphics_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pctClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctClose_MouseEnter(object sender, EventArgs e)
        {
            timerPlus.Start();
            timerMinus.Stop();
            this.pctClose.Image = global::KVALIFA.Properties.Resources.RedB;
            label9.Visible = false;
        }

        private void pctClose_MouseLeave(object sender, EventArgs e)
        {
            timerMinus.Start();
            timerPlus.Stop();
            this.pctClose.Image = global::KVALIFA.Properties.Resources.closeR;
        }


        private void timerPlus_Tick(object sender, EventArgs e)
        {
            if (pctClose.Width <= 30)
            {
                pnlTop.Height += 1;
                pctClose.Width += 1;
                pctClose.Height += 1;
                this.pctClose.Image = global::KVALIFA.Properties.Resources.closeR;
            }
            else
            {
                label9.Visible = false;
            }
        }

        private void timerMinus_Tick(object sender, EventArgs e)
        {
            if (pctClose.Width >= 15)
            {
                pnlTop.Height -= 1;
                pctClose.Width -= 1;
                pctClose.Height -= 1;
                this.pctClose.Image = global::KVALIFA.Properties.Resources.RedB;
            }
            else
            {
                label9.Visible = true;
            }
        }

        private void lblLinFun_Click(object sender, EventArgs e)
        {
            ner1 = true;
            ner2 = false;
            ner3 = false;
            ner4 = false;
            lblGivenFun.Visible = false;
            lblOutput.Visible = true;
            lblOutput.Text = "Відповідь: ";
            lbl1.BackColor = Color.FromArgb(219, 249, 184);
            lbl2.BackColor = Color.FromArgb(136, 216, 105);
            lbl3.BackColor = Color.FromArgb(136, 216, 105);
            lbl4.BackColor = Color.FromArgb(136, 216, 105);
            PB.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(206, 82);
            panel2.Visible = false;
            panel2.Location = new Point(541, 240);
            panel3.Visible = false;
            panel3.Location = new Point(541, 373);
            panel4.Visible = false;
            panel4.Location = new Point(541, 506);
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            ner1 = false;
            ner2 = true;
            ner3 = false;
            ner4 = false;
            lblOutput.Visible = true;
            lblOutput.Text = "Відповідь: ";
            lbl2.BackColor = Color.FromArgb(219, 249, 184);
            lbl1.BackColor = Color.FromArgb(136, 216, 105);
            lbl3.BackColor = Color.FromArgb(136, 216, 105);
            lbl4.BackColor = Color.FromArgb(136, 216, 105);
            PB.Visible = false;
            panel2.Visible = true;
            panel2.Location = new Point(206, 82);
            panel1.Visible = false;
            panel1.Location = new Point(541, 240);
            panel3.Visible = false;
            panel3.Location = new Point(541, 373);
            panel4.Visible = false;
            panel4.Location = new Point(541, 506);
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            ner1 = false;
            ner2 = false;
            ner3 = true;
            ner4 = false;
            lblOutput.Visible = true;
            lblOutput.Text = "Відповідь: ";
            lbl3.BackColor = Color.FromArgb(219, 249, 184);
            lbl2.BackColor = Color.FromArgb(136, 216, 105);
            lbl1.BackColor = Color.FromArgb(136, 216, 105);
            lbl4.BackColor = Color.FromArgb(136, 216, 105);
            PB.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(206, 82);
            panel2.Visible = false;
            panel2.Location = new Point(541, 240);
            panel1.Visible = false;
            panel1.Location = new Point(541, 373);
            panel4.Visible = false;
            panel4.Location = new Point(541, 506);
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            ner1 = false;
            ner2 = false;
            ner3 = false;
            ner4 = true;
            lblOutput.Visible = true;
            lblOutput.Text = "Відповідь: ";
            lbl4.BackColor = Color.FromArgb(219, 249, 184);
            lbl2.BackColor = Color.FromArgb(136, 216, 105);
            lbl3.BackColor = Color.FromArgb(136, 216, 105);
            lbl1.BackColor = Color.FromArgb(136, 216, 105);
            PB.Visible = false;
            panel4.Visible = true;
            panel4.Location = new Point(206, 82);
            panel2.Visible = false;
            panel2.Location = new Point(541, 240);
            panel3.Visible = false;
            panel3.Location = new Point(541, 373);
            panel1.Visible = false;
            panel1.Location = new Point(541, 506);
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            x1 -= 1;
            x2 += 1;
            y1 -= 1;
            y2 += 1;
            if (ner1)
                btn1_Main.PerformClick();
            if (ner2)
                btn2_Main.PerformClick();
            if (ner3)
                btn3_Main.PerformClick();
            if (ner4)
                btn4_Main.PerformClick();
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (x1 != 1)
            {
                x1 += 1;
                x2 -= 1;
                y1 += 1;
                y2 -= 1;
            }
            if (ner1)
                btn1_Main.PerformClick();
            if (ner2)
                btn2_Main.PerformClick();
            if (ner3)
                btn3_Main.PerformClick();
            if (ner4)
                btn4_Main.PerformClick();
        }

        double fLin(double xt, double k)
        {
            return k * x;
        }

        double f41(double xt, double a)
        {
            double ff = xt * xt * xt + a;
            return ff;
        }

        double f42(double xt, double a)
        {
            double ff = -xt * xt * xt - a;
            return ff;
        }

        double zal1(double xt, double i)
        {
            return -0.5 * xt + i;
        }

        double zal2(double xt, double i)
        {
            return 0.5 * xt + i;
        }

        double zal3(double xt, double i)
        {
            return -2 * xt + i;
        }

        double zal4(double xt, double i)
        {
            return 2 * xt + i;
        }

        double f21(double xt, double a)
        {
            double ff = -xt + a;
            return ff;
        }

        double f22(double xt, double a)
        {
            double ff = xt + a;
            return ff;
        }
        double f23(double xt, double a)
        {
            double ff = -xt - a;
            return ff;
        }

        double f24(double xt, double a)
        {
            double ff = xt - a;
            return ff;
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pctExit, "До програмної частини");
            toolTip1.SetToolTip(pctHelp, "Довідник користувача");
            toolTip1.SetToolTip(pctClose, "Вихід");
        }

        private void txt1_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != '\u002C') && (e.KeyChar != (char)Keys.Back))
                    e.Handled = true;
            }
            catch
            {
                return;
            }
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            frmProgramMenu programMenu = new frmProgramMenu();
            programMenu.Show();
            this.Hide();
        }

        private void lbl1_MouseEnter(object sender, EventArgs e)
        {
            lbl1.Text = "y  ≥  ax";
        }

        private void lbl1_MouseLeave(object sender, EventArgs e)
        {
            lbl1.Text = "y ≥ ax";
        }

        private void lbl2_MouseEnter(object sender, EventArgs e)
        {
            lbl2.Text = "|y|  ≥  x³  +  a";
        }

        private void lbl2_MouseLeave(object sender, EventArgs e)
        {
            lbl2.Text = "|y| ≥ x³ + a";
        }

        private void lbl3_MouseEnter(object sender, EventArgs e)
        {
            lbl3.Text = "|x|  +  |y|  ≤  a";
        }

        private void lbl3_MouseLeave(object sender, EventArgs e)
        {
            lbl3.Text = "|x| + |y| ≤ a";
        }

        private void lbl4_MouseEnter(object sender, EventArgs e)
        {
            lbl4.Text = "||x|  -  |y||  >  a";
        }

        private void lbl4_MouseLeave(object sender, EventArgs e)
        {
            lbl4.Text = "||x| - |y|| > a";
        }

        private void pctHelp_Click(object sender, EventArgs e)
        {
            frmUserGuide userGuide = new frmUserGuide();
            userGuide.ShowDialog();
        }

        double f101(double xt, double a)
        {
            double ff = xt + a;
            return ff;
        }

        double f102(double xt, double a)
        {
            double ff = -xt + a;
            return ff;
        }

        double f103(double xt, double a)
        {
            double ff = xt - a;
            return ff;
        }

        double f104(double xt, double a)
        {
            double ff = -xt - a;
            return ff;
        }

        double f105(double xt, double a)
        {
            double ff = xt + a;
            return ff;
        }

        double f106(double xt, double a)
        {
            double ff = -xt + a;
            return ff;
        }

        double f107(double xt, double a)
        {
            double ff = xt - a;
            return ff;
        }

        double f108(double xt, double a)
        {
            double ff = -xt - a;
            return ff;
        }

        private void btn1_Main_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt1_A.Text == "")
                {
                    txt1_A.Text = "1";
                }
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                myPen = new Pen(Color.Red, 3);
                
                try
                {
                    a = double.Parse(txt1_A.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                }
                if (a == 0)
                    lblGivenFun.Text = "y ≥ 0";
                if (a == 1)
                    lblGivenFun.Text = "y ≥ x";
                else
                    lblGivenFun.Text = "y ≥ " + a + "x";
                gr.Clear(Color.White);
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                system_koordinat(x1, x2, y1, y2);

                n = PB.Width;
                h = (x2 - x1) / n;
                x = x1;
                while (x < x2)
                {
                    y = fLin(x, a);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(fLin(x, a)), xtoi(x + h), ytoj(fLin(x + h, a)));
                    }
                    x = x + h;

                }
                if (a < 0)
                {
                    for (double i = x2 - a * 10; i >= x1 + a * 10; i -= 0.2)
                    {
                        x = x2;
                        while (x > i / (a - 0.5))
                        {

                            y = zal2(x, i);
                            if (y > y1)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal2(x, i)), xtoi(x + h), ytoj(zal2(x + h, i)));
                            }
                            x = x - h;
                        }
                    }
                }
                else
                {
                    for (double i = x1 - a * 10; i <= x2 + 10; i += 0.2)
                    {
                        x = x1;
                        while (x < i / (a + 0.5))
                        {

                            y = zal1(x, i);
                            if (y < y2)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal1(x, i)), xtoi(x + h), ytoj(zal1(x + h, i)));
                            }
                            x = (x + h);
                        }
                    }
                }
                PB.Image = bitmap;
                lblOutput.Text = "Відповідь: \r\n\r\nПри x ∈ R, \r\ny ∈ [ " + a + "x; ∞ )";
            }
            catch
            {
                return;
            }
        }

        private void btn2_Main_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt2_A.Text == "")
                {
                    txt2_A.Text = "1";
                }
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                myPen = new Pen(Color.Red, 3);
                try
                {
                    a = double.Parse(txt2_A.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                }
                gr.Clear(Color.White);
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                system_koordinat(x1, x2, y1, y2);
                if (a > 0)
                    lblGivenFun.Text = "|y| ≥ x³ + " + Math.Abs(a);
                if (a < 0)
                    lblGivenFun.Text = "|y| ≥ x³ - " + Math.Abs(a);
                if (a == 0)
                    lblGivenFun.Text = "|y| ≥ x³";
                n = PB.Width;
                h = (x2 - x1) / n;

                x = x1;
                while (x < x2)
                {
                    y = f41(x, a);
                    if (y < y2 && y >= 0 - 0.01)
                    {

                        gr.DrawLine(myPen, xtoi(x), ytoj(f41(x, a)), xtoi(x + h), ytoj(f41(x + h, a)));
                    }
                    x = x + h;

                }
                x = x1;
                y = f42(x, a);
                while (x < x2)
                {
                    y = f42(x, a);
                    if (y <= 0 + 0.01)
                    {

                        gr.DrawLine(myPen, xtoi(x), ytoj(f42(x, a)), xtoi(x + h), ytoj(f42(x + h, a)));
                    }
                    x = x + h;

                }

                for (double i = x1 - 24; i <= x2 + 24; i += 1)
                {
                    x = x1;
                    while (x * x * x + 2 * x < i - a)
                    {

                        y = zal3(x, i);
                        if (y < y2)
                        {
                            if (y > 0)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal3(x, i)), xtoi(x + h), ytoj(zal3(x + h, i)));
                            }

                        }
                        x += h;
                    }
                }
                if (a < 0)
                {
                    x = 1;
                    while (-x * x * x + 2 * x >= 0 - a)
                    {
                        y = zal3(x, 0);
                        if (y < y2)
                        {
                            if (y <= 0)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal3(x, 0)), xtoi(x + h), ytoj(zal3(x + h, 0)));
                            }
                        }
                        x = (x + h);
                    }
                }

                for (double i = 0 - a; i >= x1 - 24; i -= 1)
                {
                    x = 0;
                    while (-x * x * x + 2 * x >= i + a)
                    {

                        y = zal3(x, i);
                        if (y < y2)
                        {
                            if (y <= 0)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal3(x, i)), xtoi(x + h), ytoj(zal3(x + h, i)));
                            }
                        }
                        x = (x + h);
                    }
                }
                for (double i = 0; i >= x1 - 24; i -= 1)
                {
                    x = x1;
                    while (-x * x * x + 2 * x >= i + a)
                    {

                        y = zal3(x, i);
                        if (y < y2)
                        {
                            if (y <= 0)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal3(x, i)), xtoi(x + h), ytoj(zal3(x + h, i)));
                            }
                        }
                        x = (x + h);
                    }
                }
                PB.Image = bitmap;
                lblOutput.Text = "Відповідь: \r\n\r\nПри x ∈ ( -∞; ∛" + a + " ), \r\ny ∈ R; \r\n\r\nПри x ∈ [ ∛" + a + "; ∞ ), \r\ny ∈ (-∞; - x\u00B3 - " + a + "] ∪ [x\u00B3 + " + a + "; ∞]";
            }
            catch
            {
                return;
            }
        }

        private void btn3_Main_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt3_A.Text == "")
                {
                    txt3_A.Text = "1";
                }
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                myPen = new Pen(Color.Red, 3);
                try
                {
                    a = double.Parse(txt3_A.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                }
                gr.Clear(Color.White);
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                system_koordinat(x1, x2, y1, y2);
                lblGivenFun.Text = "|x| + |y| ≤ " + a;
                n = PB.Width;
                h = (x2 - x1) / n;

                if (a == 0)
                {
                    //listBox1.Items.Add("При а = 0 розв'язком є точка (0; 0)");
                    gr.FillEllipse(Brushes.Red, xtoi(0) - 4, ytoj(0) - 4, 8, 8);

                }
                else
                {
                    if (a < 0)
                    {
                        MessageBox.Show("При а < 0 нерівність не має розв'язків");
                        return;
                    }
                    else
                    {
                        x = x1;
                        y = f21(x, a);
                        while (x <= a)
                        {
                            y = f21(x, a);
                            if (y <= a)
                            {
                                if (x >= 0 || y >= 0)
                                    gr.DrawLine(myPen, xtoi(x), ytoj(f21(x, a)), xtoi(x + h), ytoj(f21(x + h, a)));
                            }
                            x = x + h;

                        }

                        //listBox1.Items.Add("f1");

                        x = -a;
                        y = f22(x, a);
                        while (x < x2)
                        {
                            y = f22(x, a);
                            if (y < a)
                            {
                                if (xtoi(x) < 0 || ytoj(y) >= 0)
                                {
                                    gr.DrawLine(myPen, xtoi(x), ytoj(f22(x, a)), xtoi(x + h), ytoj(f22(x + h, a)));
                                }
                            }
                            x = x + h;
                        }
                        //listBox1.Items.Add("f2");

                        x = -a;
                        y = f23(x, a);
                        while (x < x2)
                        {
                            y = f23(x, a);
                            if (y > -a)
                            {
                                if (x < 0 || y < 0)
                                    gr.DrawLine(myPen, xtoi(x), ytoj(f23(x, a)), xtoi(x + h), ytoj(f23(x + h, a)));
                            }
                            x = x + h;
                        }
                        //listBox1.Items.Add("f3");

                        x = 0;
                        y = f24(x, a);
                        while (x < x2)
                        {
                            y = f24(x, a);
                            if (y < 0)
                            {
                                if (x > 0 || y < 0)
                                    gr.DrawLine(myPen, xtoi(x), ytoj(f24(x, a)), xtoi(x + h), ytoj(f24(x + h, a)));
                            }
                            x = x + h;
                        }

                        for (double i = x1 - a * 10; i <= x2 + a * 10; i += 0.2)
                        {

                            double xa = (i - a) / 3;
                            double xb = (a + i) / 3;
                            double xc = i + a;
                            double xd = i - a;
                            if ((xa < 0) && (xb > 0))
                            //listBox1.Items.Add("xa = " + xa);
                            //listBox1.Items.Add("xb = " + xb);   
                            {

                                x = xa;
                                while ((x >= (i - a) / 3) && (x <= (a + i) / 3))
                                {

                                    y = zal3(x, i);
                                    if (y < y2)
                                    {
                                        gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal3(x, i)), xtoi(x + h), ytoj(zal3(x + h, i)));

                                    }
                                    x = x + h;
                                }
                            }
                            if ((xa >= 0) && (xb >= 0))
                            {
                                //listBox1.Items.Add("xa = " + xa);
                                //listBox1.Items.Add("xb = " + xb);
                                x = xd;
                                while ((x >= xd) && (x <= xb))
                                {

                                    y = zal3(x, i);
                                    if (y < y2)
                                    {
                                        gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal3(x, i)), xtoi(x + h), ytoj(zal3(x + h, i)));

                                    }
                                    x = x + h;
                                }
                            }
                            if ((xa <= 0) && (xb <= 0))
                            {
                                x = xa;
                                while ((x >= xa) && (x <= xc))
                                {

                                    y = zal3(x, i);
                                    if (y < y2)
                                    {
                                        gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal3(x, i)), xtoi(x + h), ytoj(zal3(x + h, i)));

                                    }
                                    x = x + h;
                                }
                            }
                        }
                    }
                }
                PB.Image = bitmap;
                if (a > 0)
                    lblOutput.Text = "Відповідь: \r\n\r\nПри x ∈ [ - " + a + "; 0 ], \r\ny ∈ [ -x - " + a + "; x + " + a + " ];\r\n\r\nПри x ∈ (0 ; " + a + " ], \r\ny ∈ [x - " + a + " ; -x + " + a + " ];\r\n\r\nПри x ∈ ( -∞; -" + a + " )∪( " + a + "; ∞ ), \r\ny ∈ ∅";
                else
                {
                    if (a == 0)
                    {
                        lblOutput.Text = "Відповідь: \r\n\r\nРозв'язком є точка (0; 0)";
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn4_Main_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt4_A.Text == "")
                {
                    txt4_A.Text = "1";
                }
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                myPen = new Pen(Color.Red, 3);
                try
                {
                    a = double.Parse(txt4_A.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                }
                gr.Clear(Color.White);
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                system_koordinat(x1, x2, y1, y2);
                lblGivenFun.Text = "||x| - |y|| > " + a;
                h = (x2 - x1) / n;

                x = x1;
                while (x < -a)
                {
                    y = f101(x, a);
                    if (y < y2)
                    {

                        gr.DrawLine(myPen, xtoi(x), ytoj(f101(x, a)), xtoi(x + h), ytoj(f101(x + h, a)));
                    }
                    x = x + 5 * h;
                }
                x = a;
                while (x < x2)
                {
                    y = f102(x, a);
                    if (y < y2)
                    {

                        gr.DrawLine(myPen, xtoi(x), ytoj(f102(x, a)), xtoi(x + h), ytoj(f102(x + h, a)));
                    }
                    x = x + 5 * h;
                }
                x = a;
                while (x < x2)
                {
                    y = f103(x, a);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(f103(x, a)), xtoi(x + h), ytoj(f103(x + h, a)));
                    }
                    x = x + 5 * h;
                }

                x = x1;
                while (x < -a)
                {
                    y = f104(x, a);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(f104(x, a)), xtoi(x + h), ytoj(f104(x + h, a)));
                    }
                    x = x + 5 * h;
                }
                x = 0;
                while (x < x2)
                {
                    y = f105(x, a);
                    if (y < y2)
                    {

                        gr.DrawLine(myPen, xtoi(x), ytoj(f105(x, a)), xtoi(x + h), ytoj(f105(x + h, a)));
                    }
                    x = x + 5 * h;
                }
                x = x1;
                while (x < a)
                {
                    y = f106(x, a);
                    if (y < y2 && y > a)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(f106(x, a)), xtoi(x + h), ytoj(f106(x + h, a)));
                    }
                    x = x + 5 * h;
                }
                x = x1;
                while (x < 0)
                {
                    y = f107(x, a);
                    if (y < y2 && y < -a)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(f107(x, a)), xtoi(x + h), ytoj(f107(x + h, a)));
                    }
                    x = x + 5 * h;
                }

                x = -a;
                while (x < x2)
                {
                    y = f108(x, a);
                    if (y < y2 && y < -a)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(f108(x, a)), xtoi(x + h), ytoj(f108(x + h, a)));
                    }
                    x = x + 5 * h;
                }
                //________________________________________________________
                if (a <= 0)
                {
                    for (double i = x1 - (-a) * 10 - 10; i < x2 + (-a) * 10 + 10; i++)
                    {
                        x = x1 - 10;
                        while (x < x2)
                        {

                            y = zal1(x, i);
                            if (y < y2)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal1(x, i)), xtoi(x + h), ytoj(zal1(x + h, i)));
                            }
                            x = (x + h);
                        }
                    }
                    //gr.DrawEllipse(myPen, xtoi(0) - 4, ytoj(0) - 4, 8, 8);
                }
                else
                {
                    double x11 = -10;
                    for (double i = a + 5; i >= x1; i--)
                    {
                        x = x11;
                        y = zal1(x, i);
                        while ((-0.5 * x + i >= -x + a) && (-0.5 * x + i >= x + a))
                        {
                            y = zal1(x, i);
                            if (y < y2)
                            {
                                if (y > 0)
                                {
                                    gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal1(x, i)), xtoi(x + h), ytoj(zal1(x + h, i)));
                                }
                            }
                            x = x + h;
                        }
                        x11 += 2;
                    }
                    for (double i = x1 - a * 10; i <= x2 + 10; i++)
                    {
                        x = x1;
                        while ((-0.5 * x + i >= -x + a) && (-0.5 * x + i >= x + a))
                        {
                            y = zal1(x, i);
                            if (y < y2)
                            {
                                if (y > 0)
                                {
                                    gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal1(x, i)), xtoi(x + h), ytoj(zal1(x + h, i)));
                                }
                            }
                            x = x + h;
                        }
                    }
                    //________________________________________________________
                    for (double i = 5; i >= x1; i--)
                    {
                        x = 0;
                        while ((-0.5 * x + i <= x - a) && (-0.5 * x + i >= -x + a))
                        {
                            y = zal1(x, i);
                            if (y < y2)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal1(x, i)), xtoi(x + h), ytoj(zal1(x + h, i)));
                            }
                            x = x + h;
                        }
                    }
                    //-------------------------------------------
                    for (double i = -2; i >= x1 - 20; i--)
                    {
                        x = -2 / 3;
                        while ((-0.5 * x + i <= x - a) && (-0.5 * x + i <= -x - a))
                        {
                            y = zal1(x, i);
                            if (y < y2)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal1(x, i)), xtoi(x + h), ytoj(zal1(x + h, i)));
                            }
                            x = x - h;
                        }
                    }
                    for (double i = -2; i >= x1 - 20; i--)
                    {
                        x = -2 / 3;
                        while ((-0.5 * x + i <= x - a) && (-0.5 * x + i <= -x - a))
                        {
                            y = zal1(x, i);
                            if (y < y2)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal1(x, i)), xtoi(x + h), ytoj(zal1(x + h, i)));
                            }
                            x = x + h;
                        }
                    }
                    //
                    for (double i = 3; i >= x1 - 10; i--)
                    {
                        x = x1;
                        while ((-0.5 * x + i <= -x - a) && (-0.5 * x + i >= x + a))
                        {
                            y = zal1(x, i);
                            if (y < y2)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal1(x, i)), xtoi(x + h), ytoj(zal1(x + h, i)));
                            }
                            x = x + h;
                        }
                    }
                    //
                    for (double i = 20; i >= x1 - 10; i--)
                    {
                        x = 14;
                        while ((-0.5 * x + i <= x - a) && (-0.5 * x + i >= -x + a))
                        {
                            y = zal1(x, i);
                            if (y < y2 && y > y1)
                            {
                                gr.DrawLine(Pens.Green, xtoi(x), ytoj(zal1(x, i)), xtoi(x + h), ytoj(zal1(x + h, i)));
                            }
                            x = x - h;
                        }
                    }
                }
                myPen = new Pen(Color.DarkGreen, 2);
                if (a == 0)
                    gr.DrawEllipse(myPen, xtoi(0) - 4, ytoj(0) - 4, 8, 8);
                PB.Image = bitmap;
                if (a > 0)
                    lblOutput.Text = "Відповідь: \r\n\r\nПри x∈(-∞; " + a + "),\r\ny∈(-∞; x - " + a + ")∪(x + " + a + "; -x - " + a + ")∪(-x + " + a + ";∞)\r\n\r\nПри x∈(-" + a + "; 0),\r\ny∈(-∞; x - " + a + ")∪(-x + " + a + ";∞)\r\n\r\nПри x∈(0; " + a + "),\r\ny∈(-∞; -x - " + a + ")∪(x + " + a + ";∞)\r\n\r\nПри x∈(" + a + "; ∞),\r\ny∈(-∞; -x - " + a + ")∪(-x + " + a + "; x - " + a + ")∪(x + " + a + "; ∞)";
                if (a < 0)
                    lblOutput.Text = "Відповідь: \r\nРозв'язок нерівності - вся координатна площина";
                if (a == 0)
                    lblOutput.Text = "Відповідь: \r\n\r\nПри x∈(-∞; 0),\r\ny∈(-∞; x)∪(x ; -x)∪(-x; ∞)\r\n\r\nПри x∈(0; ∞),\r\ny∈(-∞; -x)∪(-x; x)∪(x; ∞)\r\n\r\nПри x=0, \r\ny∈(-∞; 0)∪(0; ∞) ";
            }
            catch
            {
                return;
            }
        }
    }
}