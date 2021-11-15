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
    public partial class frmTwoGraphics : Form
    {
        public frmTwoGraphics()
        {
            InitializeComponent();
        }

        bool linf1 = false;
        bool linf2 = false;
        bool quadf1 = false;
        bool quadf2 = false;
        bool revf1 = false;
        bool revf2 = false;

        void LinFun_1_Selected()
        {
            linf1 = true;
            quadf1 = false;
            revf1 = false;
            PB.Visible = false;
            lblLinFun1.BackColor = Color.FromArgb(219, 249, 184);
            lblLinFun1.ForeColor = Color.FromArgb(0, 0, 0);

            lblQuadraticFun1.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun1.ForeColor = Color.FromArgb(0, 0, 0);
            //lblReverseFun1.BackColor = Color.FromArgb(136, 216, 105);
            //lblReverseFun1.ForeColor = Color.FromArgb(0, 0, 0);

            grbLinF1.Visible = true;
            grbLinF1.Location = new Point(206, 21);
            grbLinF1.Size = new Size(301, 110);
            grbQuadF1.Visible = false;
            grbQuadF1.Location = new Point(513, 22);
            grbQuadF1.Size = new Size(301, 110);
            

            lbl_SFRect.Visible = false;
            lbl_SFRect.Text = "S = ";
            lbl_SFTrap.Visible = false;
            lbl_SFTrap.Text = "S = ";
            lbl_SFSympson.Visible = false;
            lbl_SFSympson.Text = "S = ";
            lbl_SFIntegral.Visible = false;
            lbl_SFIntegral.Text = "S = ";
        }

        void QuadFun_1_Selected()
        {
            linf1 = false;
            quadf1 = true;
            revf1 = false;
            PB.Visible = false;
            lblLinFun1.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun1.ForeColor = Color.FromArgb(0, 0, 0);

            lblQuadraticFun1.BackColor = Color.FromArgb(219, 249, 184);
            lblQuadraticFun1.ForeColor = Color.FromArgb(0, 0, 0);

            //lblReverseFun1.BackColor = Color.FromArgb(136, 216, 105);
            //lblReverseFun1.ForeColor = Color.FromArgb(0, 0, 0);

            grbLinF1.Visible = false;
            grbLinF1.Location = new Point(513, 22);
            grbLinF1.Size = new Size(301, 110);
            grbQuadF1.Visible = true;
            grbQuadF1.Location = new Point(206, 21);
            grbQuadF1.Size = new Size(301, 110);
            

            lbl_SFRect.Visible = false;
            lbl_SFRect.Text = "S = ";
            lbl_SFTrap.Visible = false;
            lbl_SFTrap.Text = "S = ";
            lbl_SFSympson.Visible = false;
            lbl_SFSympson.Text = "S = ";
            lbl_SFIntegral.Visible = false;
            lbl_SFIntegral.Text = "S = ";
        }

        void RevFun_1_Selected()
        {
            linf1 = false;
            quadf1 = false;
            revf1 = true;
            PB.Visible = false;
            lblLinFun1.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun1.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun1.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun1.ForeColor = Color.FromArgb(0, 0, 0);

            //lblReverseFun1.BackColor = Color.FromArgb(219, 249, 184);
            //lblReverseFun1.ForeColor = Color.FromArgb(0, 0, 0);

            grbLinF1.Visible = false;
            grbLinF1.Location = new Point(513, 22);
            grbLinF1.Size = new Size(301, 110);
            grbQuadF1.Visible = false;
            grbQuadF1.Location = new Point(820, 22);
            grbQuadF1.Size = new Size(301, 110);
            

            lbl_SFRect.Visible = false;
            lbl_SFRect.Text = "S = ";
            lbl_SFTrap.Visible = false;
            lbl_SFTrap.Text = "S = ";
            lbl_SFSympson.Visible = false;
            lbl_SFSympson.Text = "S = ";
            lbl_SFIntegral.Visible = false;
            lbl_SFIntegral.Text = "S = ";
        }

        void LinFun_2_Selected()
        {
            linf2 = true;
            quadf2 = false;
            revf2 = false;
            PB.Visible = false;
            lblLinFun2.BackColor = Color.FromArgb(219, 249, 184);
            lblLinFun2.ForeColor = Color.FromArgb(0, 0, 0);

            lblQuadraticFun2.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun2.ForeColor = Color.FromArgb(0, 0, 0);
            //lblReverseFun2.BackColor = Color.FromArgb(136, 216, 105);
            //lblReverseFun2.ForeColor = Color.FromArgb(0, 0, 0);

            grbLinF2.Visible = true;
            grbLinF2.Location = new Point(206, 137);
            grbLinF2.Size = new Size(301, 110);
            grbQuadF2.Visible = false;
            grbQuadF2.Location = new Point(513, 137);
            grbQuadF2.Size = new Size(301, 110);
            

            lbl_SFRect.Visible = false;
            lbl_SFRect.Text = "S = ";
            lbl_SFTrap.Visible = false;
            lbl_SFTrap.Text = "S = ";
            lbl_SFSympson.Visible = false;
            lbl_SFSympson.Text = "S = ";
            lbl_SFIntegral.Visible = false;
            lbl_SFIntegral.Text = "S = ";
        }

        void QuadFun_2_Selected()
        {
            linf2 = false;
            quadf2 = true;
            revf2 = false;
            PB.Visible = false;
            lblLinFun2.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun2.ForeColor = Color.FromArgb(0, 0, 0);

            lblQuadraticFun2.BackColor = Color.FromArgb(219, 249, 184);
            lblQuadraticFun2.ForeColor = Color.FromArgb(0, 0, 0);

            //lblReverseFun2.BackColor = Color.FromArgb(136, 216, 105);
            //lblReverseFun2.ForeColor = Color.FromArgb(0, 0, 0);

            grbLinF2.Visible = false;
            grbLinF2.Location = new Point(513, 137);
            grbLinF2.Size = new Size(301, 110);
            grbQuadF2.Visible = true;
            grbQuadF2.Location = new Point(206, 137);
            grbQuadF2.Size = new Size(301, 110);
            

            lbl_SFRect.Visible = false;
            lbl_SFRect.Text = "S = ";
            lbl_SFTrap.Visible = false;
            lbl_SFTrap.Text = "S = ";
            lbl_SFSympson.Visible = false;
            lbl_SFSympson.Text = "S = ";
            lbl_SFIntegral.Visible = false;
            lbl_SFIntegral.Text = "S = ";
        }

        void RevFun_2_Selected()
        {
            linf2 = true;
            quadf2 = false;
            revf2 = true;
            PB.Visible = false;
            lblLinFun2.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun2.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun2.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun2.ForeColor = Color.FromArgb(0, 0, 0);

            //lblReverseFun2.BackColor = Color.FromArgb(219, 249, 184);
            //lblReverseFun2.ForeColor = Color.FromArgb(0, 0, 0);

            grbLinF2.Visible = false;
            grbLinF2.Location = new Point(513, 137);
            grbLinF2.Size = new Size(301, 110);
            grbQuadF2.Visible = false;
            grbQuadF2.Location = new Point(820, 137);
            grbQuadF2.Size = new Size(301, 110);
            
            lbl_SFRect.Visible = false;
            lbl_SFRect.Text = "S = ";
            lbl_SFTrap.Visible = false;
            lbl_SFTrap.Text = "S = ";
            lbl_SFSympson.Visible = false;
            lbl_SFSympson.Text = "S = ";
            lbl_SFIntegral.Visible = false;
            lbl_SFIntegral.Text = "S = ";
        }

        private void pctClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void pctClose_MouseLeave(object sender, EventArgs e)
        {           
            timerMinus.Start();
            timerPlus.Stop();
            this.pctClose.Image = global::KVALIFA.Properties.Resources.closeR;
            label2.Visible = true;
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
                label2.Visible = false;
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
                label2.Visible = true;
            }
        }

        private void pctClose_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = false;
            timerPlus.Start();
            timerMinus.Stop();
            this.pctClose.Image = global::KVALIFA.Properties.Resources.RedB;
        }

        private void chbHand_CheckedChanged(object sender, EventArgs e)
        {
            if(chbHand.Checked==true)
            {
                txt_X1.Enabled = true;
                txt_X2.Enabled = true;
            }
            else
            {
                txt_X1.Enabled = false;
                txt_X2.Enabled = false;
                set_Limits_Integral();
            }
        }

        private void lblLinFun1_Click(object sender, EventArgs e)
        {
            LinFun_1_Selected();
        }

        private void lblQuadraticFun1_Click(object sender, EventArgs e)
        {
            QuadFun_1_Selected();
        }

        private void lblReverseFun1_Click(object sender, EventArgs e)
        {
            RevFun_1_Selected();
        }

        private void lblLinFun2_Click(object sender, EventArgs e)
        {
            LinFun_2_Selected();
            btn_Build.Visible = true;
            btn_Minus.Visible = true;
            btn_Plus.Visible = true;
        }

        private void lblQuadraticFun2_Click(object sender, EventArgs e)
        {
            QuadFun_2_Selected();
            btn_Build.Visible = true;
            btn_Minus.Visible = true;
            btn_Plus.Visible = true;
        }

        private void lblReverseFun2_Click(object sender, EventArgs e)
        {
            RevFun_2_Selected();
        }

        Pen myPen;
        Graphics gr;
        Bitmap bitmap;
        double k1, k2, a1, a2, b1, b2, c1, c2, x0, y0, x01, x02, y01, y02;
        double xi1, xi2, S, H;
        int N;
        int i1, i2, j1, j2, n;

        private void lblLinFun1_MouseEnter(object sender, EventArgs e)
        {
            lblLinFun1.Text = "y = kx + b";
        }

        private void lblLinFun1_MouseLeave(object sender, EventArgs e)
        {
            lblLinFun1.Text = "y=kx+b";
        }

        private void lblQuadraticFun1_MouseEnter(object sender, EventArgs e)
        {
            lblQuadraticFun1.Text = "y = ax² + bx + c";
        }

        private void lblQuadraticFun1_MouseLeave(object sender, EventArgs e)
        {
            lblQuadraticFun1.Text = "y=ax²+bx+c";
        }

        private void lblLinFun2_MouseEnter(object sender, EventArgs e)
        {
            lblLinFun2.Text = "y = kx + b";
        }

        private void lblLinFun2_MouseLeave(object sender, EventArgs e)
        {
            lblLinFun2.Text = "y=kx+b";
        }

        private void lblQuadraticFun2_MouseEnter(object sender, EventArgs e)
        {
            lblQuadraticFun2.Text = "y = ax² + bx + c";
        }

        private void lblQuadraticFun2_MouseLeave(object sender, EventArgs e)
        {
            lblQuadraticFun2.Text = "y=ax²+bx+c";
        }

        private void pctHelp_Click(object sender, EventArgs e)
        {
            frmUserGuide userGuide = new frmUserGuide();
            userGuide.ShowDialog();
        }

        private void frmTwoGraphics_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pctClose, "Вихід");
            toolTip1.SetToolTip(pctExit, "До програмної частини");
            toolTip1.SetToolTip(pctHelp, "Довідник користувача");
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            frmProgramMenu programMenu = new frmProgramMenu();
            programMenu.Show();
            this.Hide();
        }

        private void txt1_K1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != '\u002C') && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        double x1 = -10, x2 = 10, y1 = -10, y2 = 10, h, x, y;

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
            Font myFont = new Font("Times New Roman", 14, FontStyle.Italic);
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

            Font MyFont = new Font("arial", 8, FontStyle.Regular);
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

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            try
            {
                if (x2 > 1)
                {
                    x1 += 1;
                    x2 -= 1;
                    y1 += 1;
                    y2 -= 1;
                }
                btn_Build.PerformClick();
            }
            catch
            {
                return;
            }
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            try
            {
                x1 -= 1;
                x2 += 1;
                y1 -= 1;
                y2 += 1;
                btn_Build.PerformClick();
            }
            catch
            {
                return;
            }
        }

        double fLin(double xt, double k, double b)
        {
            double ff = k * xt + b;
            return ff;
        }

        double fQuad(double xt, double a, double b, double c)
        {
            double ff = a * xt * xt + b * xt + c;
            return ff;
        }

        double fRev(double xt, double k, double a, double b)
        {
            double ff = k / (xt + a) + b;
            return ff;
        }

        double xp1, xp2;
        void set_Limits_Integral()
        {
            try
            {
                btn_Build.PerformClick();
                if (linf1 == true && linf2 == true)
                {
                    xp1 = -b1 / k1;
                    xp2 = -b2 / k2;
                    if (k1 * k2 < 0) // Разные знаки
                    {
                        if (xp1 < xp2)
                        {
                            txt_X1.Text = "" + Math.Round(xp1, 1);
                            txt_X2.Text = "" + Math.Round(xp2, 1);
                        }
                        if (xp1 > xp2)
                        {
                            txt_X1.Text = "" + Math.Round(xp2, 1);
                            txt_X2.Text = "" + Math.Round(xp1, 1);
                        }
                    }
                    else
                    {
                        if (k1 > 0 && k2 > 0)
                        {
                            if (fLin(x0, k1, b1) > 0)
                            {
                                if (xp1 < xp2)
                                {
                                    if (xp2 < x0)
                                    {
                                        txt_X1.Text = "" + Math.Round(xp1, 1);
                                        txt_X2.Text = "" + Math.Round(x0, 1);
                                    }
                                }
                                else
                                {
                                    if (xp1 > xp2)
                                    {
                                        if (xp1 < x0)
                                        {
                                            txt_X1.Text = "" + Math.Round(xp2, 1);
                                            txt_X2.Text = "" + Math.Round(x0, 1);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (fLin(x0, k1, b1) < 0)
                                {
                                    if (k1 > 0 && k2 > 0)
                                    {
                                        if (xp1 < xp2)
                                        {
                                            if (xp1 > x0)
                                            {
                                                txt_X1.Text = "" + Math.Round(x0, 1);
                                                txt_X2.Text = "" + Math.Round(xp2, 1);
                                            }
                                        }
                                        else
                                        {
                                            if (xp1 > xp2)
                                            {
                                                if (xp2 > x0)
                                                {
                                                    txt_X1.Text = "" + Math.Round(x0, 1);
                                                    txt_X2.Text = "" + Math.Round(xp1, 1);
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                        else
                        {
                            if (k1 < 0 && k2 < 0)
                            {
                                if (fLin(x0, k1, b1) > 0)
                                {
                                    if (xp1 < xp2)
                                    {
                                        if (xp1 > x0)
                                        {
                                            txt_X1.Text = "" + Math.Round(x0, 1);
                                            txt_X2.Text = "" + Math.Round(xp2, 1);
                                        }
                                    }
                                    else
                                    {
                                        if (xp1 > xp2)
                                        {
                                            if (xp2 > x0)
                                            {
                                                txt_X1.Text = "" + Math.Round(x0, 1);
                                                txt_X2.Text = "" + Math.Round(xp1, 1);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (fLin(x0, k1, b1) < 0)
                                    {
                                        if (xp1 < xp2)
                                        {
                                            if (xp2 < x0)
                                            {
                                                txt_X1.Text = "" + Math.Round(xp1, 1);
                                                txt_X2.Text = "" + Math.Round(x0, 1);
                                            }
                                        }
                                        else
                                        {
                                            if (xp1 > xp2)
                                            {
                                                if (xp1 < x0)
                                                {
                                                    txt_X1.Text = "" + Math.Round(xp2, 1);
                                                    txt_X2.Text = "" + Math.Round(x0, 1);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                            }
                        }
                    }
                }
                else
                {
                    if ((linf1 == true && quadf2 == true) || (quadf1 == true && linf2 == true))
                    {
                        if (a2 > 0)
                        {
                            txt_X1.Text = "" + Math.Round(x01, 1);
                            txt_X2.Text = "" + Math.Round(x02, 1);
                        }
                        else
                        {
                            if (a2 < 0)
                            {
                                txt_X1.Text = "" + Math.Round(x02, 1);
                                txt_X2.Text = "" + Math.Round(x01, 1);
                            }
                        }
                    }
                    else
                    {
                        if (quadf1 == true && quadf2 == true)
                        {
                            if (x01 < x02)
                            {
                                txt_X1.Text = "" + Math.Round(x01, 1);
                                txt_X2.Text = "" + Math.Round(x02, 1);
                            }
                            else
                            {
                                if (x01 > x02)
                                {
                                    txt_X1.Text = "" + Math.Round(x02, 1);
                                    txt_X2.Text = "" + Math.Round(x01, 1);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn_Build_Click(object sender, EventArgs e)
        {
            try
            {
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                gr.Clear(Color.White);
                PB.Visible = true;
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                h = (x2 - x1) / n;
                if (linf1 == true && linf2 == true)
                {
                    gr.Clear(Color.White);
                    if (txt1_K1.Text == "")
                        txt1_K1.Text = "1";
                    if (txt1_K2.Text == "")
                        txt1_K2.Text = "-0,5";
                    if (txt1_B1.Text == "")
                        txt1_B1.Text = "2";
                    if (txt1_B2.Text == "")
                        txt1_B2.Text = "5";
                    try
                    {
                        k1 = double.Parse(txt1_K1.Text);
                        k2 = double.Parse(txt1_K2.Text);
                        b1 = double.Parse(txt1_B1.Text);
                        b2 = double.Parse(txt1_B2.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректні дані");
                        return;
                    }
                    system_koordinat(x1, x2, y1, y2);
                    label2.Text = "Знайти площу фігури, обмеженої лініями \r\n y = ";// + k1 + "x + " + b1 + ";     y = " + k2 + "x + " + b2+";     y = 0";
                    if (k1 != 1)
                    {
                        if (k1 == -1)
                            label2.Text += " - ";
                        else
                            label2.Text += k1;
                    }

                    label2.Text += "x";
                    if (b1 > 0)
                    {
                        label2.Text += " + " + b1;
                    }
                    if (b1 < 0)
                    {
                        label2.Text += " - " + Math.Abs(b1);
                    }
                    label2.Text += ";     y = ";
                    if (k2 != 1)
                    {
                        if (k2 == -1)
                            label2.Text += " - ";
                        else
                            label2.Text += k2;
                    }
                    label2.Text += "x";
                    if (b2 > 0)
                    {
                        label2.Text += " + " + b1;
                    }
                    if (b2 < 0)
                    {
                        label2.Text += " - " + Math.Abs(b2);
                    }
                    label2.Text += ";     y = 0";
                    myPen = new Pen(Color.Red, 3);
                    //1
                    x = x1;
                    while (x < x2)
                    {
                        y = fLin(x, k1, b1);
                        if (y < y2)
                        {
                            gr.DrawLine(myPen, xtoi(x), ytoj(fLin(x, k1, b1)), xtoi(x + h), ytoj(fLin(x + h, k1, b1)));
                        }
                        x = x + h;
                    }
                    //2
                    myPen.Color = Color.Green;
                    x = x1;
                    while (x < x2)
                    {
                        y = fLin(x, k2, b2);
                        if (y < y2)
                        {
                            gr.DrawLine(myPen, xtoi(x), ytoj(fLin(x, k2, b2)), xtoi(x + h), ytoj(fLin(x + h, k2, b2)));
                        }
                        x = x + h;
                    }

                    if (k1 - k2 != 0)
                    {
                        x0 = (b2 - b1) / (k1 - k2);
                        y0 = fLin(x0, k1, b1);
                        gr.FillEllipse(Brushes.Black, xtoi(x0) - 5, ytoj(y0) - 5, 10, 10);
                    }
                    else
                    {
                        PB.Image = bitmap;
                        MessageBox.Show("Немає точок перетину");
                        grbS.Visible = false;
                        return;
                    }

                    if (fLin(x0, k1, b1) == 0)
                    {
                        PB.Image = bitmap;
                        MessageBox.Show("S = 0");
                        grbS.Visible = false;
                        return;
                    }

                }
                else
                {
                    if (linf1 == true && quadf2 == true)
                    {
                        gr.Clear(Color.White);
                        if (txt1_K1.Text == "")
                            txt1_K1.Text = "1";
                        if (txt2_A2.Text == "")
                            txt2_A2.Text = "-1";
                        if (txt1_B1.Text == "")
                            txt1_B1.Text = "3";
                        if (txt2_B2.Text == "")
                            txt2_B2.Text = "-2";
                        if (txt2_C2.Text == "")
                            txt2_C2.Text = "3";
                        try
                        {
                            k1 = double.Parse(txt1_K1.Text);
                            b1 = double.Parse(txt1_B1.Text);
                            a2 = double.Parse(txt2_A2.Text);
                            b2 = double.Parse(txt2_B2.Text);
                            c2 = double.Parse(txt2_C2.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректні дані");
                            return;
                        }
                        if (a2 == 0)
                        {
                            MessageBox.Show("Старший коефіцієнт не може дорівнювати 0.");
                            return;
                        }
                        system_koordinat(x1, x2, y1, y2);
                        myPen = new Pen(Color.Red, 3);
                        label2.Text = "Знайти площу фігури, обмеженої лініями \r\n y = ";// +k1+"x + "+b1+";     y = "+a2+"x² + " + b2 +"x + "+ c2);
                        if (k1 != 1)
                        {
                            if (k1 == -1)
                                label2.Text += " - ";
                            else
                                label2.Text += k1;
                        }

                        label2.Text += "x";
                        if (b1 > 0)
                        {
                            label2.Text += " + " + b1;
                        }
                        if (b1 < 0)
                        {
                            label2.Text += " - " + Math.Abs(b1);
                        }
                        label2.Text += ";     y = ";
                        if (a2 != 1)
                        {
                            if (a2 == -1)
                                label2.Text += " - ";
                            else
                                label2.Text += a2;
                        }
                        label2.Text += "x²";
                        if (b2 > 0)
                        {
                            label2.Text += " + " + b2;
                        }
                        if (b2 < 0)
                        {
                            label2.Text += " - " + Math.Abs(b2);
                        }
                        label2.Text += "x";
                        if (c2 > 0)
                        {
                            label2.Text += " + " + c2;
                        }
                        if (c2 < 0)
                        {
                            label2.Text += " - " + Math.Abs(c2);
                        }
                        //1
                        x = x1;
                        while (x < x2)
                        {
                            y = fLin(x, k1, b1);
                            if (y < y2)
                            {
                                gr.DrawLine(myPen, xtoi(x), ytoj(fLin(x, k1, b1)), xtoi(x + h), ytoj(fLin(x + h, k1, b1)));
                            }
                            x = x + h;
                        }
                        //2
                        myPen.Color = Color.Green;
                        x = x1;
                        while (x < x2)
                        {
                            y = fQuad(x, a2, b2, c2);
                            if (y < y2)
                            {
                                gr.DrawLine(myPen, xtoi(x), ytoj(fQuad(x, a2, b2, c2)), xtoi(x + h), ytoj(fQuad(x + h, a2, b2, c2)));
                            }
                            x = x + h;

                        }

                        double D = Math.Pow((b2 - k1), 2) - 4 * a2 * (c2 - b1);
                        if (D < 0)
                        {
                            PB.Image = bitmap;
                            MessageBox.Show("Немає точок перетину");
                            grbS.Visible = false;
                            return;
                        }
                        else
                        {
                            if (D == 0)
                            {
                                x0 = (k1 - b2) / (2 * a2);
                                y0 = fLin(x0, k1, b1);
                                gr.FillEllipse(Brushes.Black, xtoi(x0) - 5, ytoj(y0) - 5, 10, 10);
                            }
                            else
                            {
                                if (D > 0)
                                {
                                    x01 = (k1 - b2 - Math.Sqrt(D)) / (2 * a2);
                                    x02 = (k1 - b2 + Math.Sqrt(D)) / (2 * a2);
                                    y01 = fLin(x01, k1, b1);
                                    y02 = fLin(x02, k1, b1);
                                    //if (a2 > 0)
                                    //{
                                    //    txt_X1.Text = "" + x01;
                                    //    txt_X2.Text = "" + x02;

                                    //}
                                    //else
                                    //{
                                    //    if(a2<0)
                                    //    {
                                    //        txt_X1.Text = "" + x02;
                                    //        txt_X2.Text = "" + x01;
                                    //    }
                                    //}
                                    gr.FillEllipse(Brushes.Black, xtoi(x01) - 5, ytoj(y01) - 5, 10, 10);
                                    gr.FillEllipse(Brushes.Black, xtoi(x02) - 5, ytoj(y02) - 5, 10, 10);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (quadf1 == true && quadf2 == true)
                        {
                            gr.Clear(Color.White);
                            if (txt2_A1.Text == "")
                                txt2_A1.Text = "1";
                            if (txt2_B1.Text == "")
                                txt2_B1.Text = "4";
                            if (txt2_C1.Text == "")
                                txt2_C1.Text = "4";
                            if (txt2_A2.Text == "")
                                txt2_A2.Text = "-1";
                            if (txt2_B2.Text == "")
                                txt2_B2.Text = "-2";
                            if (txt2_C2.Text == "")
                                txt2_C2.Text = "2";
                            try
                            {
                                a1 = double.Parse(txt2_A1.Text);
                                b1 = double.Parse(txt2_B1.Text);
                                c1 = double.Parse(txt2_C1.Text);
                                a2 = double.Parse(txt2_A2.Text);
                                b2 = double.Parse(txt2_B2.Text);
                                c2 = double.Parse(txt2_C2.Text);
                            }
                            catch
                            {
                                MessageBox.Show("Введено некоректні дані");
                                return;
                            }
                            if (a1 == 0 || a2 == 0)
                            {
                                MessageBox.Show("Старший коефіцієнт не може дорівнювати 0.");
                                return;
                            }
                            system_koordinat(x1, x2, y1, y2);
                            myPen = new Pen(Color.Red, 3);
                            label2.Text = "Знайти площу фігури, обмеженої лініями \r\n y = ";// +k1+"x + "+b1+";     y = "+a2+"x² + " + b2 +"x + "+ c2);
                            if (a1 != 1)
                            {
                                if (a1 == -1)
                                    label2.Text += " - ";
                                else
                                    label2.Text += a1;
                            }
                            label2.Text += "x²";
                            if (b1 > 0)
                            {
                                label2.Text += " + " + b1;
                            }
                            if (b1 < 0)
                            {
                                label2.Text += " - " + Math.Abs(b1);
                            }
                            label2.Text += "x";
                            if (c1 > 0)
                            {
                                label2.Text += " + " + c1;
                            }
                            if (c1 < 0)
                            {
                                label2.Text += " - " + Math.Abs(c1);
                            }
                            label2.Text += ";     y = ";
                            if (a2 != 1)
                            {
                                if (a2 == -1)
                                    label2.Text += " - ";
                                else
                                    label2.Text += a2;
                            }
                            label2.Text += "x²";
                            if (b2 > 0)
                            {
                                label2.Text += " + " + b2;
                            }
                            if (b2 < 0)
                            {
                                label2.Text += " - " + Math.Abs(b2);
                            }
                            label2.Text += "x";
                            if (c2 > 0)
                            {
                                label2.Text += " + " + c2;
                            }
                            if (c2 < 0)
                            {
                                label2.Text += " - " + Math.Abs(c2);
                            }
                            //1
                            x = x1;
                            while (x < x2)
                            {
                                y = fQuad(x, a1, b1, c1);
                                if (y < y2)
                                {
                                    gr.DrawLine(myPen, xtoi(x), ytoj(fQuad(x, a1, b1, c1)), xtoi(x + h), ytoj(fQuad(x, a1, b1, c1)));
                                }
                                x = x + h;
                            }
                            //2
                            myPen.Color = Color.Green;
                            x = x1;
                            while (x < x2)
                            {
                                y = fQuad(x, a2, b2, c2);
                                if (y < y2)
                                {
                                    gr.DrawLine(myPen, xtoi(x), ytoj(fQuad(x, a2, b2, c2)), xtoi(x + h), ytoj(fQuad(x + h, a2, b2, c2)));
                                }
                                x = x + h;

                            }
                            double D = (b1 - b2) * (b1 - b2) - 4 * (a1 - a2) * (c1 - c2);
                            if (D < 0)
                            {
                                PB.Image = bitmap;
                                MessageBox.Show("Немає точок перетину");
                                grbS.Visible = false;
                                return;
                            }
                            else
                            {
                                if (D == 0)
                                {
                                    x0 = -(b1 - b2) / (2 * (a1 - a2));
                                    y0 = fQuad(x0, a1, b1, c1);
                                    gr.FillEllipse(Brushes.Black, xtoi(x0) - 5, ytoj(y0) - 5, 10, 10);
                                }
                                else
                                {
                                    if (D > 0)
                                    {
                                        x01 = (-(b1 - b2) - Math.Sqrt(D)) / (2 * (a1 - a2));
                                        x02 = (-(b1 - b2) + Math.Sqrt(D)) / (2 * (a1 - a2));
                                        y01 = fQuad(x01, a1, b1, c1);
                                        y02 = fQuad(x02, a1, b1, c1);
                                        //txt_X1.Text = "" + x01;
                                        //txt_X2.Text = "" + x02;
                                        gr.FillEllipse(Brushes.Black, xtoi(x01) - 5, ytoj(y01) - 5, 10, 10);
                                        gr.FillEllipse(Brushes.Black, xtoi(x02) - 5, ytoj(y02) - 5, 10, 10);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (quadf1 == true && linf2 == true)
                            {
                                gr.Clear(Color.White);
                                if (txt1_K2.Text == "")
                                    txt1_K2.Text = "1";
                                if (txt1_B2.Text == "")
                                    txt1_B2.Text = "3";
                                if (txt2_A1.Text == "")
                                    txt2_A1.Text = "-1";
                                if (txt2_B1.Text == "")
                                    txt2_B1.Text = "-2";
                                if (txt2_C1.Text == "")
                                    txt2_C1.Text = "3";
                                try
                                {
                                    k1 = double.Parse(txt1_K2.Text);
                                    b1 = double.Parse(txt1_B2.Text);
                                    a2 = double.Parse(txt2_A1.Text);
                                    b2 = double.Parse(txt2_B1.Text);
                                    c2 = double.Parse(txt2_C1.Text);
                                }
                                catch
                                {
                                    MessageBox.Show("Введено некоректні дані");
                                    return;
                                }
                                if (a2 == 0)
                                {
                                    MessageBox.Show("Старший коефіцієнт не може дорівнювати 0.");
                                    return;
                                }
                                system_koordinat(x1, x2, y1, y2);
                                myPen = new Pen(Color.Green, 3);
                                label2.Text = "Знайти площу фігури, обмеженої лініями \r\n y = ";// +k1+"x + "+b1+";     y = "+a2+"x² + " + b2 +"x + "+ c2);
                                if (k1 != 1)
                                {
                                    if (k1 == -1)
                                        label2.Text += " - ";
                                    else
                                        label2.Text += k1;
                                }

                                label2.Text += "x";
                                if (b1 > 0)
                                {
                                    label2.Text += " + " + b1;
                                }
                                if (b1 < 0)
                                {
                                    label2.Text += " - " + Math.Abs(b1);
                                }
                                label2.Text += ";     y = ";
                                if (a2 != 1)
                                {
                                    if (a2 == -1)
                                        label2.Text += " - ";
                                    else
                                        label2.Text += a2;
                                }
                                label2.Text += "x²";
                                if (b2 > 0)
                                {
                                    label2.Text += " + " + b2;
                                }
                                if (b2 < 0)
                                {
                                    label2.Text += " - " + Math.Abs(b2);
                                }
                                label2.Text += "x";
                                if (c2 > 0)
                                {
                                    label2.Text += " + " + c2;
                                }
                                if (c2 < 0)
                                {
                                    label2.Text += " - " + Math.Abs(c2);
                                }
                                //1
                                x = x1;
                                while (x < x2)
                                {
                                    y = fLin(x, k1, b1);
                                    if (y < y2)
                                    {
                                        gr.DrawLine(myPen, xtoi(x), ytoj(fLin(x, k1, b1)), xtoi(x + h), ytoj(fLin(x + h, k1, b1)));
                                    }
                                    x = x + h;
                                }
                                //2
                                myPen.Color = Color.Red;
                                x = x1;
                                while (x < x2)
                                {
                                    y = fQuad(x, a2, b2, c2);
                                    if (y < y2)
                                    {
                                        gr.DrawLine(myPen, xtoi(x), ytoj(fQuad(x, a2, b2, c2)), xtoi(x + h), ytoj(fQuad(x + h, a2, b2, c2)));
                                    }
                                    x = x + h;

                                }

                                double D = Math.Pow((b2 - k1), 2) - 4 * a2 * (c2 - b1);
                                if (D < 0)
                                {
                                    PB.Image = bitmap;
                                    MessageBox.Show("Немає точок перетину");
                                    grbS.Visible = false;
                                    return;
                                }
                                else
                                {
                                    if (D == 0)
                                    {
                                        x0 = (k1 - b2) / (2 * a2);
                                        y0 = fLin(x0, k1, b1);
                                        gr.FillEllipse(Brushes.Black, xtoi(x0) - 5, ytoj(y0) - 5, 10, 10);
                                    }
                                    else
                                    {
                                        if (D > 0)
                                        {
                                            x01 = (k1 - b2 - Math.Sqrt(D)) / (2 * a2);
                                            x02 = (k1 - b2 + Math.Sqrt(D)) / (2 * a2);
                                            y01 = fLin(x01, k1, b1);
                                            y02 = fLin(x02, k1, b1);
                                            //if (a2 > 0)
                                            //{
                                            //    txt_X1.Text = "" + x01;
                                            //    txt_X2.Text = "" + x02;

                                            //}
                                            //else
                                            //{
                                            //    if(a2<0)
                                            //    {
                                            //        txt_X1.Text = "" + x02;
                                            //        txt_X2.Text = "" + x01;
                                            //    }
                                            //}
                                            gr.FillEllipse(Brushes.Black, xtoi(x01) - 5, ytoj(y01) - 5, 10, 10);
                                            gr.FillEllipse(Brushes.Black, xtoi(x02) - 5, ytoj(y02) - 5, 10, 10);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                PB.Image = bitmap;
                grbS.Visible = true;
            }
            catch
            {
                return;
            }
        }

        private void btn_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbHand.Checked == false)
                    set_Limits_Integral();
                btn_Build.PerformClick();
                lbl_SFRect.Visible = true;
                if (txt_X1.Text == "" || txt_X2.Text == "")
                {
                    set_Limits_Integral();
                }
                if (txt_N.Text == "")
                {
                    txt_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt_X1.Text);
                    xi2 = double.Parse(txt_X2.Text);
                    N = int.Parse(txt_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }

                myPen = new Pen(Color.Purple, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));


                H = (xi2 - xi1) / N;
                S = 0;
                if (linf1 == true && linf2 == true)
                {
                    if (fLin(x0, k1, b1) > 0)
                    {
                        if (k1 > 0 && k2 < 0)
                        {

                            for (double i = xi1; i <= x0 - H; i += H)
                            {
                                y = fLin(i, k1, b1);
                                S += H * y;
                            }
                            for (double i = x0; i <= xi2 - H; i += H)
                            {
                                y = fLin(i, k2, b2);
                                S += H * y;
                            }
                        }
                        else
                        {
                            if (k1 < 0 && k2 > 0)
                            {
                                for (double i = xi1; i <= x0 - H; i += H)
                                {
                                    y = fLin(i, k2, b2);
                                    S += H * y;
                                }
                                for (double i = x0; i <= xi2 - H; i += H)
                                {
                                    y = fLin(i, k1, b1);
                                    S += H * y;
                                }
                            }
                            else
                            {
                                if (k1 > 0 && k2 > 0)
                                {
                                    double S1 = 0;
                                    if (-b1 / k1 < -b2 / k2)
                                    {
                                        for (double i = xi1; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S += H * y;
                                        }
                                        for (double i = -b2 / k2; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S1 += H * y;
                                        }
                                    }
                                    if (-b1 / k1 > -b2 / k2)
                                    {
                                        for (double i = xi1; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S += H * y;
                                        }
                                        for (double i = -b1 / k1; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S1 += H * y;
                                        }
                                    }
                                    S -= S1;
                                }
                                else
                                {
                                    if (k1 < 0 && k2 < 0)
                                    {
                                        if (-b1 / k1 < -b2 / k2)
                                        {
                                            for (double i = xi1; i <= xi2 - H; i += H)
                                            {
                                                y = fLin(i, k2, b2);
                                                S += H * y;
                                            }
                                            for (double i = xi1; i <= -b1 / k1 - H; i += H)
                                            {
                                                y = fLin(i, k1, b1);
                                                S -= H * y;
                                            }
                                        }
                                        else
                                        {
                                            if (-b1 / k1 > -b2 / k2)
                                            {
                                                for (double i = xi1; i <= xi2 - H; i += H)
                                                {
                                                    y = fLin(i, k1, b1);
                                                    S += H * y;
                                                }
                                                for (double i = xi1; i <= -b2 / k2 - H; i += H)
                                                {
                                                    y = fLin(i, k2, b2);
                                                    S -= H * y;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (fLin(x0, k1, b1) < 0)
                        {
                            if (k1 > 0 && k2 < 0)
                            {
                                if (-b2 / k2 < -b1 / k1)
                                {
                                    for (double i = xi1; i <= x0 - H; i += H)
                                    {
                                        y = fLin(i, k2, b2);
                                        S += H * y;
                                    }
                                    for (double i = x0; i <= xi2 - H; i += H)
                                    {
                                        y = fLin(i, k1, b1);
                                        S += H * y;
                                    }
                                }
                            }
                            else
                            {
                                if (k1 < 0 & k2 > 0)
                                {
                                    if (-b1 / k1 < -b2 / k2)
                                    {
                                        for (double i = xi1; i <= x0 - H; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S += H * y;
                                        }
                                        for (double i = x0; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S += H * y;
                                        }
                                    }
                                }
                                else
                                {
                                    if (k1 > 0 && k2 > 0)
                                    {
                                        if (-b1 / k1 < -b2 / k2)
                                        {
                                            for (double i = xi1; i <= xi2 - H; i += H)
                                            {
                                                y = fLin(i, k2, b2);
                                                S += H * y;
                                            }
                                            for (double i = xi1; i <= -b1 / k1 - H; i += H)
                                            {
                                                y = fLin(i, k1, b1);
                                                S -= H * y;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (k1 < 0 && k2 < 0)
                                        {
                                            if (-b1 / k1 < -b2 / k2)
                                            {
                                                for (double i = xi1; i <= xi2 - H; i += H)
                                                {
                                                    y = fLin(i, k1, b1);
                                                    S += H * y;
                                                }
                                                for (double i = -b2 / k2; i <= xi2 - H; i += H)
                                                {
                                                    y = fLin(i, k2, b2);
                                                    S -= H * y;
                                                }
                                            }
                                            else
                                            {
                                                if (-b1 / k1 > -b2 / k2)
                                                {
                                                    for (double i = xi1; i <= xi2 - H; i += H)
                                                    {
                                                        y = fLin(i, k2, b2);
                                                        S += H * y;
                                                    }
                                                    for (double i = -b1 / k1; i <= xi2 - H; i += H)
                                                    {
                                                        y = fLin(i, k1, b1);
                                                        S -= H * y;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    lbl_SFRect.Text = "S = " + Math.Abs(Math.Round(S, 2));
                }
                else
                {
                    if ((linf1 == true && quadf2 == true) || (quadf1 == true && linf2 == true))
                    {
                        S = 0;
                        double xv = -b2 / (2 * a2);
                        if ((fQuad(xv, a2, b2, c2) >= fLin(xv, k1, b1)) && (a2 < 0))
                        {
                            for (double i = xi1; i <= xi2 - H; i += H)
                            {
                                y = fQuad(i, a2, b2, c2) - fLin(i, k1, b1);
                                S += H * y;
                            }
                        }
                        else
                        {
                            for (double i = xi1; i <= xi2 - H; i += H)
                            {
                                y = fLin(i, k1, b1) - fQuad(i, a2, b2, c2);
                                S += H * y;
                            }
                        }
                        lbl_SFRect.Text = "S = " + Math.Round(S, 2);
                    }
                    else
                    {
                        if (quadf1 == true && quadf2 == true)
                        {
                            S = 0;
                            if (a2 < 0 && a1 > 0)
                            {
                                for (double i = xi1; i <= xi2 - H; i += H)
                                {
                                    y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                    S += H * y;
                                }
                            }
                            else
                            {
                                if (a1 < 0 && a2 > 0)
                                {
                                    for (double i = xi1; i <= xi2 - H; i += H)
                                    {
                                        y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                        S += H * y;
                                    }
                                }
                                else
                                {
                                    if (a1 > 0 && a2 > 0)
                                    {
                                        double xv = -b2 / (2 * a2);
                                        if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                        {
                                            for (double i = xi1; i <= xi2 - H; i += H)
                                            {
                                                y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                                S += H * y;
                                            }
                                        }
                                        else
                                        {
                                            xv = -b1 / (2 * a1);
                                            if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                            {
                                                for (double i = xi1; i <= xi2 - H; i += H)
                                                {
                                                    y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                                    S += H * y;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (a1 < 0 && a2 < 0)
                                        {
                                            double xv = -b2 / (2 * a2);
                                            if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                            {
                                                for (double i = xi1; i <= xi2 - H; i += H)
                                                {
                                                    y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                                    S += H * y;
                                                }
                                            }
                                            else
                                            {
                                                xv = -b1 / (2 * a1);
                                                if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                                {
                                                    for (double i = xi1; i <= xi2 - H; i += H)
                                                    {
                                                        y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                                        S += H * y;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        set_Limits_Integral();
                        lbl_SFRect.Text = "S = " + Math.Abs(Math.Round(S, 2));

                    }
                }
                fillFigure(H);
            }
            catch
            {
                return;
            }
        }

        private void btn_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbHand.Checked == false)
                    set_Limits_Integral();
                btn_Build.PerformClick();
                lbl_SFTrap.Visible = true;
                if (txt_X1.Text == "" || txt_X2.Text == "")
                {
                    set_Limits_Integral();
                }
                if (txt_N.Text == "")
                {
                    txt_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt_X1.Text);
                    xi2 = double.Parse(txt_X2.Text);
                    N = int.Parse(txt_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректні дані");
                    return;
                }
                myPen = new Pen(Color.Purple, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));


                H = (xi2 - xi1) / N;
                S = 0;
                if (linf1 == true && linf2 == true)
                {
                    if (fLin(x0, k1, b1) > 0)
                    {
                        if (k1 > 0 && k2 < 0)
                        {
                            S = H * ((fLin(xi1, k1, b1) + fLin(x0, k1, b1)) / 2);
                            for (double i = xi1 + H; i <= x0 - H; i += H)
                            {
                                y = fLin(i, k1, b1);
                                S += H * y;
                            }
                            S += H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                            for (double i = x0 + H; i <= xi2 - H; i += H)
                            {
                                y = fLin(i, k2, b2);
                                S += H * y;
                            }
                        }
                        else
                        {
                            if (k1 < 0 && k2 > 0)
                            {
                                S = H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                for (double i = xi1 + H; i <= x0 - H; i += H)
                                {
                                    y = fLin(i, k2, b2);
                                    S += H * y;
                                }
                                S += H * ((fLin(xi1, k1, b1) + fLin(x0, k1, b1)) / 2);
                                for (double i = x0 + H; i <= xi2 - H; i += H)
                                {
                                    y = fLin(i, k1, b1);
                                    S += H * y;
                                }
                            }
                            else
                            {
                                if (k1 > 0 && k2 > 0)
                                {
                                    double S1 = 0;
                                    if (-b1 / k1 > -b2 / k2)
                                    {
                                        S = H * ((fLin(xi1, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                        for (double i = xi1 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S += H * y;
                                        }
                                        S1 = H * ((fLin(x0, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                        for (double i = -b1 / k1 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S1 += H * y;
                                        }
                                    }
                                    if (-b1 / k1 < -b2 / k2)
                                    {
                                        S = H * ((fLin(xi1, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                        for (double i = xi1 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S += H * y;
                                        }
                                        S1 = H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                        for (double i = -b2 / k2 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S1 += H * y;
                                        }
                                    }
                                    S -= S1;
                                }
                                else
                                {
                                    if (k1 < 0 && k2 < 0)
                                    {
                                        if (-b1 / k1 < -b2 / k2)
                                        {
                                            S = H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                            for (double i = xi1 + H; i <= xi2 - H; i += H)
                                            {
                                                y = fLin(i, k2, b2);
                                                S += H * y;
                                            }
                                            S -= H * ((fLin(xi1, k1, b1) + fLin(-b1 / k1, k1, b1)) / 2);
                                            for (double i = xi1 + H; i <= -b1 / k1 - H; i += H)
                                            {
                                                y = fLin(i, k1, b1);
                                                S -= H * y;
                                            }
                                        }
                                        else
                                        {
                                            if (-b1 / k1 > -b2 / k2)
                                            {
                                                S = H * ((fLin(xi1, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                                for (double i = xi1 + H; i <= xi2 - H; i += H)
                                                {
                                                    y = fLin(i, k1, b1);
                                                    S += H * y;
                                                }
                                                S -= H * ((fLin(x0, k2, b2) + fLin(-b2 / k2, k2, b2)) / 2);
                                                for (double i = xi1 + H; i <= -b2 / k2 - H; i += H)
                                                {
                                                    y = fLin(i, k2, b2);
                                                    S -= H * y;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (fLin(x0, k1, b1) < 0)
                        {
                            if (k1 > 0 && k2 < 0)
                            {
                                if (-b2 / k2 < -b1 / k1)
                                {
                                    S = H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                    for (double i = -b2 / k2 + H; i <= x0 - H; i += H)
                                    {
                                        y = fLin(i, k2, b2);
                                        S += H * y;
                                    }
                                    S += H * ((fLin(xi1, k1, b1) + fLin(x0, k1, b1)) / 2);
                                    for (double i = x0 + H; i <= -b1 / k1 - H; i += H)
                                    {
                                        y = fLin(i, k1, b1);
                                        S += H * y;
                                    }
                                }
                            }
                            if (k1 < 0 & k2 > 0)
                            {
                                if (-b1 / k1 < -b2 / k2)
                                {
                                    S = H * ((fLin(xi1, k1, b1) + fLin(x0, k1, b1)) / 2);
                                    for (double i = xi1 + H; i <= x0 - H; i += H)
                                    {
                                        y = fLin(i, k1, b1);
                                        S += H * y;
                                    }
                                    S += H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                    for (double i = x0 + H; i <= xi2 - H; i += H)
                                    {
                                        y = fLin(i, k2, b2);
                                        S += H * y;
                                    }
                                }
                            }
                            else
                            {
                                if (k1 > 0 && k2 > 0)
                                {
                                    if (-b1 / k1 < -b2 / k2)
                                    {
                                        S = H * ((fLin(xi1, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                        for (double i = xi1 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S += H * y;
                                        }
                                        S -= H * ((fLin(xi1, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                        for (double i = xi1 + H; i <= -b1 / k1 - H; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S -= H * y;
                                        }
                                    }
                                }
                                else
                                {
                                    if (k1 < 0 && k2 < 0)
                                    {
                                        if (-b1 / k1 < -b2 / k2)
                                        {
                                            S = H * ((fLin(xi1, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                            for (double i = xi1 + H; i <= xi2 - H; i += H)
                                            {
                                                y = fLin(i, k1, b1);
                                                S += H * y;
                                            }
                                            S -= H * ((fLin(-b2 / k2, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                            for (double i = -b2 / k2 + H; i <= xi2 - H; i += H)
                                            {
                                                y = fLin(i, k2, b2);
                                                S -= H * y;
                                            }
                                        }
                                        else
                                        {
                                            if (-b1 / k1 > -b2 / k2)
                                            {
                                                S = H * ((fLin(xi1, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                                for (double i = xi1 + H; i <= xi2 - H; i += H)
                                                {
                                                    y = fLin(i, k2, b2);
                                                    S += H * y;
                                                }
                                                S -= H * ((fLin(-b1 / k1, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                                for (double i = -b1 / k1 + H; i <= xi2 - H; i += H)
                                                {
                                                    y = fLin(i, k1, b1);
                                                    S -= H * y;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    lbl_SFTrap.Text = "S = " + Math.Abs(Math.Round(S, 2));
                }
                else
                {
                    if ((linf1 == true && quadf2 == true) || (quadf1 == true && linf2 == true))
                    {
                        S = H * ((fLin(xi1, k2, b2) + fQuad(xi2, a2, b2, c2)) / 2);
                        double xv = -b2 / (2 * a2);

                        if ((fQuad(xv, a2, b2, c2) > fLin(xv, k1, b1)) && (a2 < 0))
                        {
                            for (double i = xi1 + H; i <= xi2 - H; i += H)
                            {
                                y = fQuad(i, a2, b2, c2) - fLin(i, k1, b1);
                                S += H * y;
                            }
                        }
                        else
                        {
                            for (double i = xi1 + H; i <= xi2 - H; i += H)
                            {
                                y = fLin(i, k1, b1) - fQuad(i, a2, b2, c2);
                                S += H * y;
                            }
                        }

                    }
                    else
                    {
                        if (quadf1 == true && quadf2 == true)
                        {
                            S = 0;
                            if (a2 < 0 && a1 > 0)
                            {
                                S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                for (double i = xi1 + H; i <= xi2 - H; i += H)
                                {
                                    y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                    S += H * y;
                                }
                            }
                            else
                            {
                                if (a1 < 0 && a2 > 0)
                                {
                                    S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                    for (double i = xi1 + H; i <= xi2 - H; i += H)
                                    {
                                        y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                        S += H * y;
                                    }
                                }
                                else
                                {
                                    if (a1 > 0 && a2 > 0)
                                    {
                                        double xv = -b2 / (2 * a2);
                                        if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                        {
                                            S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                            for (double i = xi1 + H; i <= xi2 - H; i += H)
                                            {
                                                y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                                S += H * y;
                                            }
                                        }
                                        else
                                        {
                                            xv = -b1 / (2 * a1);
                                            if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                            {
                                                S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                                for (double i = xi1 + H; i <= xi2 - H; i += H)
                                                {
                                                    y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                                    S += H * y;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (a1 < 0 && a2 < 0)
                                        {
                                            double xv = -b2 / (2 * a2);
                                            if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                            {
                                                S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                                for (double i = xi1 + H; i <= xi2 - H; i += H)
                                                {
                                                    y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                                    S += H * y;
                                                }
                                            }
                                            else
                                            {
                                                xv = -b1 / (2 * a1);
                                                if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                                {
                                                    S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                                    for (double i = xi1 + H; i <= xi2 - H; i += H)
                                                    {
                                                        y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                                        S += H * y;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                lbl_SFTrap.Text = "S = " + Math.Abs(Math.Round(S, 2));
                fillFigure(H);
            }
            catch
            {
                return;
            }
        }

        private void btn_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbHand.Checked == false)
                    set_Limits_Integral();
                btn_Build.PerformClick();
                lbl_SFSympson.Visible = true;
                if (txt_X1.Text == "" || txt_X2.Text == "")
                {
                    set_Limits_Integral();
                }
                if (txt_N.Text == "")
                {
                    txt_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt_X1.Text);
                    xi2 = double.Parse(txt_X2.Text);
                    N = int.Parse(txt_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректні дані");
                    return;
                }
                myPen = new Pen(Color.Purple, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));


                H = (xi2 - xi1) / N;
                H /= 3;
                S = 0;
                if (linf1 == true && linf2 == true)
                {
                    if (fLin(x0, k1, b1) > 0)
                    {
                        if (k1 > 0 && k2 < 0)
                        {
                            S = H * ((fLin(xi1, k1, b1) + fLin(x0, k1, b1)) / 2);
                            for (double i = xi1 + H; i <= x0 - H; i += H)
                            {
                                y = fLin(i, k1, b1);
                                S += H * y;
                            }
                            S += H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                            for (double i = x0 + H; i <= xi2 - H; i += H)
                            {
                                y = fLin(i, k2, b2);
                                S += H * y;
                            }
                            for (double i = (xi1 + H / 2); i <= x0 - H / 2; i += H)
                            {
                                y = fLin(i, k1, b1);
                                S += 2 * H * y;
                            }
                            for (double i = (x0 + H / 2); i <= xi2 - H / 2; i += H)
                            {
                                y = fLin(i, k2, b2);
                                S += 2 * H * y;
                            }
                        }
                        else
                        {
                            if (k1 < 0 && k2 > 0)
                            {
                                S = H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                for (double i = xi1; i <= x0 - H; i += H)
                                {
                                    y = fLin(i, k2, b2);
                                    S += H * y;
                                }
                                S += H * ((fLin(xi1, k1, b1) + fLin(x0, k1, b1)) / 2);
                                for (double i = x0; i <= xi2 - H; i += H)
                                {
                                    y = fLin(i, k1, b1);
                                    S += H * y;
                                }
                                for (double i = (xi1 + H / 2); i <= x0 - H / 2; i += H)
                                {
                                    y = fLin(i, k2, b2);
                                    S += 2 * H * y;
                                }
                                for (double i = (x0 + H / 2); i <= xi2 - H / 2; i += H)
                                {
                                    y = fLin(i, k1, b1);
                                    S += 2 * H * y;
                                }
                            }
                            else
                            {
                                if (k1 > 0 && k2 > 0)
                                {
                                    double S1 = 0;
                                    if (-b1 / k1 > -b2 / k2)
                                    {
                                        S = H * ((fLin(xi1, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                        for (double i = xi1 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S += H * y;
                                        }
                                        for (double i = (xi1 + H / 2); i <= xi2 - H / 2; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S += 2 * H * y;
                                        }
                                        S1 = H * ((fLin(x0, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                        for (double i = -b1 / k1 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S1 += H * y;
                                        }
                                        for (double i = (-b1 / k1 + H / 2); i <= xi2 - H / 2; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S1 += 2 * H * y;
                                        }
                                    }
                                    if (-b1 / k1 < -b2 / k2)
                                    {
                                        S = H * ((fLin(xi1, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                        for (double i = xi1 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S += H * y;
                                        }
                                        for (double i = (xi1 + H / 2); i <= xi2 - H / 2; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S += 2 * H * y;
                                        }
                                        S1 = H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                        for (double i = -b2 / k2 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S1 += H * y;
                                        }
                                        for (double i = (-b2 / k2 + H / 2); i <= xi2 - H / 2; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S1 += 2 * H * y;
                                        }
                                    }
                                    S -= S1;
                                }
                                else
                                {
                                    if (k1 < 0 && k2 < 0)
                                    {
                                        if (-b1 / k1 < -b2 / k2)
                                        {
                                            S = H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                            for (double i = xi1 + H; i <= xi2 - H; i += H)
                                            {
                                                y = fLin(i, k2, b2);
                                                S += H * y;
                                            }
                                            for (double i = (xi1 + H / 2); i <= xi2 - H / 2; i += H)
                                            {
                                                y = fLin(i, k2, b2);
                                                S += 2 * H * y;
                                            }
                                            S -= H * ((fLin(xi1, k1, b1) + fLin(-b1 / k1, k1, b1)) / 2);
                                            for (double i = xi1 + H; i <= -b1 / k1 - H; i += H)
                                            {
                                                y = fLin(i, k1, b1);
                                                S -= H * y;
                                            }
                                            for (double i = (xi1 + H / 2); i <= -b1 / k1 - H / 2; i += H)
                                            {
                                                y = fLin(i, k1, b1);
                                                S -= 2 * H * y;
                                            }
                                        }
                                        else
                                        {
                                            if (-b1 / k1 > -b2 / k2)
                                            {
                                                S = H * ((fLin(xi1, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                                for (double i = xi1 + H; i <= xi2 - H; i += H)
                                                {
                                                    y = fLin(i, k1, b1);
                                                    S += H * y;
                                                }
                                                for (double i = (xi1 + H / 2); i <= xi2 - H / 2; i += H)
                                                {
                                                    y = fLin(i, k1, b1);
                                                    S += 2 * H * y;
                                                }
                                                S -= H * ((fLin(x0, k2, b2) + fLin(-b2 / k2, k2, b2)) / 2);
                                                for (double i = xi1 + H; i <= -b2 / k2 - H; i += H)
                                                {
                                                    y = fLin(i, k2, b2);
                                                    S -= H * y;
                                                }
                                                for (double i = (xi1 + H / 2); i <= -b2 / k2 - H / 2; i += H)
                                                {
                                                    y = fLin(i, k2, b2);
                                                    S -= 2 * H * y;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        lbl_SFSympson.Text = "S = " + Math.Round(S, 2);
                    }
                    if (fLin(x0, k1, b1) < 0)
                    {
                        if (k1 > 0 && k2 < 0)
                        {
                            if (-b2 / k2 < -b1 / k1)
                            {
                                S = H * ((fLin(xi1, k2, b2) + fLin(x0, k2, b2)) / 2);
                                for (double i = xi1 + H; i <= x0 - H; i += H)
                                {
                                    y = fLin(i, k2, b2);
                                    S += H * y;
                                }
                                for (double i = xi1 + H / 2; i <= x0 - H / 2; i += H)
                                {
                                    y = fLin(i, k2, b2);
                                    S += 2 * H * y;
                                }
                                S += H * ((fLin(x0, k1, b1) + fLin(-b1 / k1, k1, b1)) / 2);
                                for (double i = x0 + H; i <= xi2 - H; i += H)
                                {
                                    y = fLin(i, k1, b1);
                                    S += H * y;
                                }
                                for (double i = x0 + H / 2; i <= xi2 - H / 2; i += H)
                                {
                                    y = fLin(i, k1, b1);
                                    S += 2 * H * y;
                                }
                            }
                        }
                        if (k1 < 0 & k2 > 0)
                        {
                            if (-b1 / k1 < -b2 / k2)
                            {
                                S = H * ((fLin(xi1, k1, b1) + fLin(x0, k1, b1)) / 2);
                                for (double i = xi1 + H; i <= x0 - H; i += H)
                                {
                                    y = fLin(i, k1, b1);
                                    S += H * y;
                                }
                                for (double i = xi1 + H / 2; i <= x0 - H / 2; i += H)
                                {
                                    y = fLin(i, k1, b1);
                                    S += 2 * H * y;
                                }
                                S += H * ((fLin(x0, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                for (double i = x0 + H; i <= xi2 - H; i += H)
                                {
                                    y = fLin(i, k2, b2);
                                    S += H * y;
                                }
                                for (double i = x0 + H / 2; i <= xi2 - H / 2; i += H)
                                {
                                    y = fLin(i, k2, b2);
                                    S += 2 * H * y;
                                }
                            }
                        }
                        else
                        {
                            if (k1 > 0 && k2 > 0)
                            {
                                if (-b1 / k1 < -b2 / k2)
                                {
                                    S = H * ((fLin(xi1, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                    for (double i = xi1 + H; i <= xi2 - H; i += H)
                                    {
                                        y = fLin(i, k2, b2);
                                        S += H * y;
                                    }
                                    for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                                    {
                                        y = fLin(i, k2, b2);
                                        S += 2 * H * y;
                                    }
                                    S -= H * ((fLin(xi1, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                    for (double i = xi1 + H; i <= -b1 / k1 - H; i += H)
                                    {
                                        y = fLin(i, k1, b1);
                                        S -= H * y;
                                    }
                                    for (double i = xi1 + H / 2; i <= -b1 / k1 - H / 2; i += H)
                                    {
                                        y = fLin(i, k1, b1);
                                        S -= 2 * H * y;
                                    }
                                }
                            }
                            else
                            {
                                if (k1 < 0 && k2 < 0)
                                {
                                    if (-b1 / k1 < -b2 / k2)
                                    {
                                        S = H * ((fLin(xi1, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                        for (double i = xi1 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S += H * y;
                                        }
                                        for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                                        {
                                            y = fLin(i, k1, b1);
                                            S += 2 * H * y;
                                        }
                                        S -= H * ((fLin(-b2 / k2, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                        for (double i = -b2 / k2 + H; i <= xi2 - H; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S -= H * y;
                                        }
                                        for (double i = -b2 / k2 + H / 2; i <= xi2 - H / 2; i += H)
                                        {
                                            y = fLin(i, k2, b2);
                                            S -= 2 * H * y;
                                        }
                                    }
                                    else
                                    {
                                        if (-b1 / k1 > -b2 / k2)
                                        {
                                            S = H * ((fLin(xi1, k2, b2) + fLin(xi2, k2, b2)) / 2);
                                            for (double i = xi1 + H; i <= xi2 - H; i += H)
                                            {
                                                y = fLin(i, k2, b2);
                                                S += H * y;
                                            }
                                            for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                                            {
                                                y = fLin(i, k2, b2);
                                                S += 2 * H * y;
                                            }
                                            S -= H * ((fLin(-b1 / k1, k1, b1) + fLin(xi2, k1, b1)) / 2);
                                            for (double i = -b1 / k1 + H; i <= xi2 - H; i += H)
                                            {
                                                y = fLin(i, k1, b1);
                                                S -= H * y;
                                            }
                                            for (double i = -b1 / k1 + H / 2; i <= xi2 - H / 2; i += H)
                                            {
                                                y = fLin(i, k1, b1);
                                                S -= 2 * H * y;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    S /= 3;
                    lbl_SFSympson.Text = "S = " + Math.Round(S, 2);
                }
                else
                {
                    if ((linf1 == true && quadf2 == true) || (quadf1 == true && linf2 == true))
                    {
                        S = H * ((fLin(xi1, k2, b2) + fQuad(xi2, a2, b2, c2)) / 2);
                        double xv = -b2 / (2 * a2);

                        if ((fQuad(xv, a2, b2, c2) >= fLin(xv, k1, b1)) && (a2 < 0))
                        {
                            for (double i = xi1 + H; i <= xi2 - H; i += H)
                            {
                                y = fQuad(i, a2, b2, c2) - fLin(i, k1, b1);
                                S += H * y;
                            }
                            for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                            {
                                y = fQuad(i, a2, b2, c2) - fLin(i, k1, b1);
                                S += H * y;
                            }
                        }
                        else
                        {
                            for (double i = xi1 + H; i <= xi2 - H; i += H)
                            {
                                y = fLin(i, k1, b1) - fQuad(i, a2, b2, c2);
                                S += H * y;
                            }

                            for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                            {
                                y = fLin(i, k1, b1) - fQuad(i, a2, b2, c2);
                                S += H * y;
                            }
                        }
                        S /= 2;
                        lbl_SFSympson.Text = "S = " + Math.Round(S, 2);
                    }
                    else
                    {
                        if (quadf1 == true && quadf2 == true)
                        {
                            S = 0;
                            if (a2 < 0 && a1 > 0)
                            {
                                S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                for (double i = xi1 + H; i <= xi2 - H; i += H)
                                {
                                    y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                    S += H * y;
                                }
                                for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                                {
                                    y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                    S += H * y;
                                }
                            }
                            else
                            {
                                if (a1 < 0 && a2 > 0)
                                {
                                    S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                    for (double i = xi1 + H; i <= xi2 - H; i += H)
                                    {
                                        y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                        S += H * y;
                                    }
                                    for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                                    {
                                        y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                        S += H * y;
                                    }
                                }
                                else
                                {
                                    if (a1 > 0 && a2 > 0)
                                    {
                                        double xv = -b2 / (2 * a2);
                                        if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                        {
                                            S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                            for (double i = xi1 + H; i <= xi2 - H; i += H)
                                            {
                                                y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                                S += H * y;
                                            }
                                            for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                                            {
                                                y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                                S += H * y;
                                            }
                                        }
                                        else
                                        {
                                            xv = -b1 / (2 * a1);
                                            if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                            {
                                                S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                                for (double i = xi1 + H; i <= xi2 - H; i += H)
                                                {
                                                    y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                                    S += H * y;
                                                }
                                                for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                                                {
                                                    y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                                    S += H * y;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (a1 < 0 && a2 < 0)
                                        {
                                            double xv = -b2 / (2 * a2);
                                            if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                            {
                                                S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                                for (double i = xi1 + H; i <= xi2 - H; i += H)
                                                {
                                                    y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                                    S += H * y;
                                                }
                                                for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                                                {
                                                    y = fQuad(i, a2, b2, c2) - fQuad(i, a1, b1, c1);
                                                    S += H * y;
                                                }
                                            }
                                            else
                                            {
                                                xv = -b1 / (2 * a1);
                                                if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                                {
                                                    S = H * ((fQuad(xi1, a1, b1, c1) + fQuad(xi2, a2, b2, c2)) / 2);
                                                    for (double i = xi1 + H; i <= xi2 - H; i += H)
                                                    {
                                                        y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                                        S += H * y;
                                                    }
                                                    for (double i = xi1 + H / 2; i <= xi2 - H / 2; i += H)
                                                    {
                                                        y = fQuad(i, a1, b1, c1) - fQuad(i, a2, b2, c2);
                                                        S += H * y;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            S /= 2;
                        }

                        lbl_SFSympson.Text = "S = " + Math.Abs(Math.Round(S, 2));
                    }
                }
                //H = (xi2 - xi1) / N;
                lbl_SFSympson.Text = "S = " + Math.Abs(Math.Round(S, 2));
                fillFigure(H);
            }
            catch
            {
                return;
            }
        }

        private void btn_FIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbHand.Checked == false)
                    set_Limits_Integral();
                btn_Build.PerformClick();
                lbl_SFIntegral.Visible = true;
                if (txt_X1.Text == "" || txt_X2.Text == "")
                {
                    set_Limits_Integral();
                }
                if (txt_N.Text == "")
                {
                    txt_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt_X1.Text);
                    xi2 = double.Parse(txt_X2.Text);
                    N = int.Parse(txt_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректні дані");
                    return;
                }
                myPen = new Pen(Color.Purple, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));
                //label4.Text = "x0 = " + x0 + "\r\ny0 = " + fLin(x0, k1, b1);
                //label4.Text = "k1 = " + k1 + "\r\nk2 = " + k2;
                S = 0;
                if (linf1 == true && linf2 == true)
                {
                    if (fLin(x0, k1, b1) > 0)
                    {
                        if (k1 > 0 && k2 < 0)
                        {
                            S = Math.Abs((k1 / 2 * ((x0 * x0) - (xi1 * xi1)) + b1 * (x0 - xi1)) + (k2 / 2 * ((xi2 * xi2) - (x0 * x0)) + b2 * (xi2 - x0)));
                        }
                        else
                        {
                            if (k1 < 0 && k2 > 0)
                            {
                                S = Math.Abs((k2 / 2 * ((x0 * x0) - (xi1 * xi1)) + b2 * (x0 - xi1)) + (k1 / 2 * ((xi2 * xi2) - (x0 * x0)) + b1 * (xi2 - x0)));
                            }
                            else
                            {

                                if (k1 > 0 && k2 > 0)
                                {
                                    if (fLin(x0, k1, b1) > 0)
                                    {
                                        if (-b1 / k1 < -b2 / k2)
                                        {
                                            S = Math.Abs((k1 / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + b1 * (xi2 - xi1) - (k2 / 2) * (Math.Pow(xi2, 2) - Math.Pow(-b2 / k2, 2)) - b2 * (xi2 + b2 / k2));
                                        }
                                        else
                                        {
                                            if (-b1 / k1 > -b2 / k2)
                                            {
                                                S = Math.Abs((k2 / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + b2 * (xi2 - xi1) - (k1 / 2) * (Math.Pow(xi2, 2) - Math.Pow(-b1 / k1, 2)) - b1 * (xi2 + b1 / k1));
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (k1 < 0 && k2 < 0)
                                    {
                                        if (-b1 / k1 < -b2 / k2)
                                        {
                                            S = Math.Abs((k2 / 2) * (Math.Pow(-b2 / k2, 2) - Math.Pow(x0, 2)) + b2 * (-b2 / k2 - x0) - (k1 / 2) * (Math.Pow(-b1 / k1, 2) - Math.Pow(x0, 2)) - b1 * (-b1 / k1 - x0));
                                        }
                                        else
                                        {
                                            if (-b1 / k1 > -b2 / k2)
                                            {
                                                S = Math.Abs((k1 / 2) * (Math.Pow(-b1 / k1, 2) - Math.Pow(x0, 2)) + b1 * (-b1 / k1 - x0) - (k2 / 2) * (Math.Pow(-b2 / k2, 2) - Math.Pow(x0, 2)) - b2 * (-b2 / k2 - x0));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //if(k1==0)
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (fLin(x0, k1, b1) < 0)
                        {
                            if (k1 > 0 && k2 < 0)
                            {
                                if (-b2 / k2 < -b1 / k1)
                                {
                                    S = Math.Abs(((k2 / 2) * ((x0 * x0) - (xi1 * xi1)) + b2 * (x0 - xi1)) + ((k1 / 2) * ((xi2 * xi2) - (x0 * x0)) + b1 * (xi2 - x0)));
                                }
                            }
                            else
                            {
                                if (k1 < 0 && k2 > 0)
                                {
                                    if (-b1 / k1 < -b2 / k2)
                                    {
                                        S = Math.Abs((k1 / 2 * ((x0 * x0) - (xi1 * xi1)) + b1 * (x0 - xi1)) + (k2 / 2 * ((xi2 * xi2) - (x0 * x0)) + b2 * (xi2 - x0)));
                                    }
                                }
                                else
                                {
                                    if (k1 > 0 && k2 > 0)
                                    {
                                        if (-b1 / k1 < -b2 / k2)
                                        {
                                            S = Math.Abs((k2 / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + b2 * (xi2 - xi1) - (k1 / 2) * (Math.Pow(-b1 / k1, 2) - Math.Pow(xi1, 2)) - b1 * (-b1 / k1 - xi1));
                                        }
                                        else
                                        {
                                            if (-b1 / k1 > -b2 / k2)
                                            {
                                                S = Math.Abs((k1 / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + b1 * (xi2 - xi1) - (k2 / 2) * (Math.Pow(-b2 / k2, 2) - Math.Pow(xi1, 2)) - b2 * (-b2 / k2 - xi1));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (k1 < 0 && k2 < 0)
                                        {
                                            if (-b1 / k1 < -b2 / k2)
                                            {
                                                S = Math.Abs((k1 / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + b1 * (xi2 - xi1) - (k2 / 2) * (Math.Pow(xi2, 2) - Math.Pow(-b2 / k2, 2)) - b2 * (xi2 + b2 / k2));
                                            }
                                            else
                                            {
                                                if (-b1 / k1 > -b2 / k2)
                                                {
                                                    S = Math.Abs((k2 / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + b2 * (xi2 - xi1) - (k1 / 2) * (Math.Pow(xi1, 2) - Math.Pow(-b1 / k1, 2)) - b1 * (xi1 + b1 / k1));
                                                }
                                            }
                                        }
                                    }
                                }

                            }

                        }
                    }
                }
                else
                {
                    if ((linf1 == true && quadf2 == true) || (quadf1 == true && linf2 == true))
                    {
                        if ((k1 > 0 && a2 < 0) || (k1 < 0 && a2 < 0))
                        {
                            S = Math.Abs((a2 / 3) * (Math.Pow(xi2, 3) - Math.Pow(xi1, 3)) + ((b2 - k1) / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + (c2 - b1) * (xi2 - xi1));
                        }
                        else
                        {
                            if ((k1 < 0 && a2 > 0) || (k1 > 0 && a2 > 0))
                            {
                                S = Math.Abs(-(a2 / 3) * (Math.Pow(xi2, 3) - Math.Pow(xi1, 3)) + ((k1 - b2) / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + (b1 - c2) * (xi2 - xi1));
                            }
                        }
                    }
                    else
                    {
                        if (quadf1 = true && quadf2 == true)
                        {
                            if (a2 < 0 && a1 > 0)
                            {
                                S = Math.Abs(((a2 - a1) / 3) * (Math.Pow(xi2, 3) - Math.Pow(xi1, 3)) + ((b2 - b1) / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + (c2 - c1) * (xi2 - xi1));
                            }
                            else
                            {
                                if (a1 < 0 && a2 > 0)
                                {
                                    S = Math.Abs(((a1 - a2) / 3) * (Math.Pow(xi2, 3) - Math.Pow(xi1, 3)) + ((b1 - b2) / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + (c1 - c2) * (xi2 - xi1));
                                }
                                else
                                {
                                    if (a1 > 0 && a2 > 0)
                                    {
                                        double xv = -b2 / (2 * a2);
                                        if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                        {
                                            S = Math.Abs(((a1 - a2) / 3) * (Math.Pow(xi2, 3) - Math.Pow(xi1, 3)) + ((b1 - b2) / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + (c1 - c2) * (xi2 - xi1));
                                        }
                                        else
                                        {
                                            xv = -b1 / (2 * a1);
                                            if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                            {
                                                S = Math.Abs(((a2 - a1) / 3) * (Math.Pow(xi2, 3) - Math.Pow(xi1, 3)) + ((b2 - b1) / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + (c2 - c1) * (xi2 - xi1));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (a1 < 0 && a2 < 0)
                                        {
                                            double xv = -b2 / (2 * a2);
                                            if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                            {
                                                S = Math.Abs(((a2 - a1) / 3) * (Math.Pow(xi2, 3) - Math.Pow(xi1, 3)) + ((b2 - b1) / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + (c2 - c1) * (xi2 - xi1));
                                            }
                                            else
                                            {
                                                xv = -b1 / (2 * a1);
                                                if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                                {
                                                    S = Math.Abs(((a1 - a2) / 3) * (Math.Pow(xi2, 3) - Math.Pow(xi1, 3)) + ((b1 - b2) / 2) * (Math.Pow(xi2, 2) - Math.Pow(xi1, 2)) + (c1 - c2) * (xi2 - xi1));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                lbl_SFIntegral.Text = "S = " + Math.Round(S, 2);
                H = (xi2 - xi1) / 10000;
                fillFigure(H);
            }
            catch
            {
                return;
            }
        }


        void fillFigure( double H)
        {
            try
            {
                if (chbHand.Checked == false)
                    set_Limits_Integral();
                btn_Build.PerformClick();
                if (txt_X1.Text == "" || txt_X2.Text == "")
                {
                    set_Limits_Integral();
                }
                try
                {
                    xi1 = double.Parse(txt_X1.Text);
                    xi2 = double.Parse(txt_X2.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректні дані");
                    return;
                }

                myPen = new Pen(Color.Purple, 3);
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));
                myPen = new Pen(Color.OrangeRed, 1);
                //fill quad fun
                if (quadf1 == true && quadf2 == true)
                {
                    if (a2 < 0 && a1 > 0)
                    {
                        //a2-a1
                        x = xi1;
                        while (x <= xi2)
                        {
                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(fQuad(x, a2, b2, c2)), xtoi(x + H) - xtoi(x), ytoj(fQuad(x, a1, b1, c1)) - ytoj(fQuad(x, a2, b2, c2)));
                            x = (x + H);
                        }
                    }
                    else
                    {
                        if (a1 < 0 && a2 > 0)
                        {
                            //a1-a2
                            x = xi1;
                            while (x <= xi2)
                            {
                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(fQuad(x, a1, b1, c1)), xtoi(x + H) - xtoi(x), ytoj(fQuad(x, a2, b2, c2)) - ytoj(fQuad(x, a1, b1, c1)));
                                x = (x + H);
                            }
                        }
                        else
                        {
                            if (a1 > 0 && a2 > 0)
                            {
                                double xv = -b2 / (2 * a2);
                                if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                {
                                    x = xi1;
                                    while (x < xi2)
                                    {
                                        gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(fQuad(x, a1, b1, c1)), xtoi(x + H) - xtoi(x), ytoj(fQuad(x, a2, b2, c2)) - ytoj(fQuad(x, a1, b1, c1)));
                                        x = (x + H);
                                    }
                                }
                                else
                                {
                                    xv = -b1 / (2 * a1);
                                    if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                    {
                                        x = xi1;
                                        while (x <= xi2)
                                        {
                                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(fQuad(x, a2, b2, c2)), xtoi(x + H) - xtoi(x), ytoj(fQuad(x, a1, b1, c1)) - ytoj(fQuad(x, a2, b2, c2)));
                                            x = (x + H);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (a1 > 0 && a2 > 0)
                                {
                                    double xv = -b2 / (2 * a2);
                                    if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                    {
                                        x = xi1;
                                        while (x <= xi2)
                                        {
                                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(fQuad(x, a1, b1, c1)), xtoi(x + H) - xtoi(x), ytoj(fQuad(x, a2, b2, c2)) - ytoj(fQuad(x, a1, b1, c1)));
                                            x = (x + H);
                                        }
                                    }
                                    else
                                    {
                                        xv = -b1 / (2 * a1);
                                        if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                        {
                                            x = xi1;
                                            while (x <= xi2)
                                            {
                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(fQuad(x, a2, b2, c2)), xtoi(x + H) - xtoi(x), ytoj(fQuad(x, a1, b1, c1)) - ytoj(fQuad(x, a2, b2, c2)));
                                                x = (x + H);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (a1 < 0 && a2 < 0)
                                    {
                                        double xv = -b2 / (2 * a2);
                                        if (fQuad(xv, a1, b1, c1) < fQuad(xv, a2, b2, c2))
                                        {
                                            x = xi1;
                                            while (x <= xi2)
                                            {
                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(fQuad(x, a2, b2, c2)), xtoi(x + H) - xtoi(x), ytoj(fQuad(x, a1, b1, c1)) - ytoj(fQuad(x, a2, b2, c2)));
                                                x = (x + H);
                                            }
                                        }
                                        else
                                        {
                                            xv = -b1 / (2 * a1);
                                            if (fQuad(xv, a1, b1, c1) > fQuad(xv, a2, b2, c2))
                                            {
                                                x = xi1;
                                                while (x <= xi2)
                                                {
                                                    gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(fQuad(x, a1, b1, c1)), xtoi(x + H) - xtoi(x), ytoj(fQuad(x, a2, b2, c2)) - ytoj(fQuad(x, a1, b1, c1)));
                                                    x = (x + H);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    // fill line & quad fun
                    if ((linf1 == true && quadf2 == true) || (quadf1 == true && linf2 == true))
                    {
                        if ((k1 > 0 && a2 < 0) || (k1 < 0 && a2 < 0))
                        {
                            x = xi1;
                            while (x <= xi2)
                            {
                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(fQuad(x, a2, b2, c2)), xtoi(x + H) - xtoi(x), ytoj(fLin(x, k1, b1)) - ytoj(fQuad(x, a2, b2, c2)));
                                x = (x + H);
                            }
                        }
                        else
                        {
                            if ((k1 < 0 && a2 > 0) || (k1 > 0 && a2 > 0))
                            {
                                x = xi1;
                                while (x <= xi2)
                                {
                                    gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(fQuad(x, a2, b2, c2)), xtoi(x + H) - xtoi(x), ytoj(fLin(x, k1, b1)) - ytoj(fQuad(x, a2, b2, c2)));
                                    x = (x + H);
                                }
                            }
                        }
                    }
                    else
                    {
                        //fill lin fun
                        if (linf1 == true && linf2 == true)
                        {
                            if (fLin(x0, k1, b1) > 0)
                            {
                                if (k1 > 0 && k2 < 0)
                                {
                                    x = xi1;
                                    while (x <= x0)
                                    {
                                        y = fLin(x, k1, b1);
                                        if (y < y2 && x <= x2)
                                        {
                                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                        }
                                        x = (x + H);
                                    }
                                    while (x <= xi2 - H)
                                    {
                                        y = fLin(x, k2, b2);
                                        if (y < y2 && x <= x2)
                                        {
                                            //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                        }
                                        x = (x + H);
                                    }
                                }
                                else
                                {
                                    if (k1 < 0 && k2 > 0)
                                    {
                                        x = xi1;
                                        while (x <= x0)
                                        {
                                            y = fLin(x, k2, b2);
                                            if (y < y2 && x <= x2)
                                            {
                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                            }
                                            x = (x + H);
                                        }
                                        while (x <= xi2 - H)
                                        {
                                            y = fLin(x, k1, b1);
                                            if (y < y2 && x <= x2)
                                            {
                                                //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                            }
                                            x = (x + H);
                                        }
                                    }
                                    else
                                    {

                                        if (k1 > 0 && k2 > 0)
                                        {
                                            if (fLin(x0, k1, b1) > 0)
                                            {
                                                if (-b1 / k1 < -b2 / k2)
                                                {
                                                    x = xi1;
                                                    while (x <= -b2 / k2 - H)
                                                    {
                                                        y = fLin(x, k1, b1);
                                                        if (y < y2 && x <= x2)
                                                        {
                                                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                        }
                                                        x = (x + H);
                                                    }
                                                    while (x <= xi2 - H)
                                                    {
                                                        y = fLin(x, k1, b1);
                                                        if (y < y2 && x <= x2)
                                                        {
                                                            //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(fLin(x, k2, b2)) - ytoj(y));
                                                        }
                                                        x = (x + H);
                                                    }
                                                }
                                                else
                                                {
                                                    if (-b1 / k1 > -b2 / k2)
                                                    {
                                                        x = xi1;
                                                        while (x <= -b1 / k1 - H)
                                                        {
                                                            y = fLin(x, k2, b2);
                                                            if (y < y2 && x <= x2)
                                                            {
                                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                            }
                                                            x = (x + H);
                                                        }
                                                        while (x <= xi2 - H)
                                                        {
                                                            y = fLin(x, k2, b2);
                                                            if (y < y2 && x <= x2)
                                                            {
                                                                //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(fLin(x, k1, b1)) - ytoj(y));
                                                            }
                                                            x = (x + H);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (k1 < 0 && k2 < 0)
                                            {
                                                if (-b1 / k1 < -b2 / k2)
                                                {
                                                    x = xi1;
                                                    while (x <= -b1 / k1 - H)
                                                    {
                                                        y = fLin(x, k2, b2);
                                                        if (y < y2 && x <= x2)
                                                        {
                                                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(fLin(x, k1, b1)) - ytoj(y));
                                                        }
                                                        x = (x + H);
                                                    }
                                                    while (x <= xi2 - H)
                                                    {
                                                        y = fLin(x, k2, b2);
                                                        if (y < y2 && x <= x2)
                                                        {
                                                            //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                        }
                                                        x = (x + H);
                                                    }
                                                }
                                                else
                                                {
                                                    if (-b1 / k1 > -b2 / k2)
                                                    {
                                                        x = xi1;
                                                        while (x <= -b2 / k2 - H)
                                                        {
                                                            y = fLin(x, k1, b1);
                                                            if (y < y2 && x <= x2)
                                                            {
                                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(fLin(x, k2, b2)) - ytoj(y));
                                                            }
                                                            x = (x + H);
                                                        }
                                                        while (x <= xi2 - H)
                                                        {
                                                            y = fLin(x, k1, b1);
                                                            if (y < y2 && x <= x2)
                                                            {
                                                                //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                            }
                                                            x = (x + H);
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                //if(k1==0)
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (fLin(x0, k1, b1) < 0)
                                {
                                    if (k1 > 0 && k2 < 0)
                                    {
                                        if (-b2 / k2 < -b1 / k1)
                                        {
                                            x = xi1;
                                            while (x <= x0)
                                            {
                                                y = fLin(x, k2, b2);
                                                if (y < y2 && x <= x2)
                                                {
                                                    gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                                                }
                                                x = (x + H);
                                            }
                                            while (x <= xi2 - H)
                                            {
                                                y = fLin(x, k1, b1);
                                                if (y < y2 && x <= x2)
                                                {
                                                    //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                    gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                                                }
                                                x = (x + H);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (k1 < 0 && k2 > 0)
                                        {
                                            if (-b1 / k1 < -b2 / k2)
                                            {
                                                x = xi1;
                                                while (x <= x0)
                                                {
                                                    y = fLin(x, k1, b1);
                                                    if (y < y2 && x <= x2)
                                                    {
                                                        gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                                                    }
                                                    x = (x + H);
                                                }
                                                while (x <= xi2 - H)
                                                {
                                                    y = fLin(x, k2, b2);
                                                    if (y < y2 && x <= x2)
                                                    {
                                                        //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                        gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                                                    }
                                                    x = (x + H);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (k1 > 0 && k2 > 0)
                                            {
                                                if (-b1 / k1 < -b2 / k2)
                                                {
                                                    x = xi1;
                                                    while (x <= -b1 / k1)
                                                    {
                                                        y = fLin(x, k1, b1);
                                                        if (y < y2 && x <= x2)
                                                        {
                                                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(fLin(x, k2, b2)) - ytoj(y));
                                                        }
                                                        x = (x + H);
                                                    }
                                                    while (x <= xi2 - H)
                                                    {
                                                        y = fLin(x, k2, b2);
                                                        if (y < y2 && x <= x2)
                                                        {
                                                            //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                            gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                                                        }
                                                        x = (x + H);
                                                    }
                                                }
                                                else
                                                {
                                                    if (-b1 / k1 > -b2 / k2)
                                                    {
                                                        x = xi1;
                                                        while (x <= -b2 / k2)
                                                        {
                                                            y = fLin(x, k2, b2);
                                                            if (y < y2 && x <= x2)
                                                            {
                                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(fLin(x, k1, b1)) - ytoj(y));
                                                            }
                                                            x = (x + H);
                                                        }
                                                        while (x <= xi2 - H)
                                                        {
                                                            y = fLin(x, k1, b1);
                                                            if (y < y2 && x <= x2)
                                                            {
                                                                //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                                                            }
                                                            x = (x + H);
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (k1 < 0 && k2 < 0)
                                                {
                                                    if (-b1 / k1 < -b2 / k2)
                                                    {
                                                        x = xi1;
                                                        while (x <= -b2 / k2)
                                                        {
                                                            y = fLin(x, k1, b1);
                                                            if (y < y2 && x <= x2)
                                                            {
                                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                                                            }
                                                            x = (x + H);
                                                        }
                                                        while (x <= xi2 - H)
                                                        {
                                                            y = fLin(x, k2, b2);
                                                            if (y < y2 && x <= x2)
                                                            {
                                                                //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                                gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(fLin(x, k1, b1)) - ytoj(y));
                                                            }
                                                            x = (x + H);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (-b1 / k1 > -b2 / k2)
                                                        {
                                                            x = xi1;
                                                            while (x <= -b1 / k1)
                                                            {
                                                                y = fLin(x, k2, b2);
                                                                if (y < y2 && x <= x2)
                                                                {
                                                                    gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                                                                }
                                                                x = (x + H);
                                                            }
                                                            while (x <= xi2 - H)
                                                            {
                                                                y = fLin(x, k1, b1);
                                                                if (y < y2 && x <= x2)
                                                                {
                                                                    //gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                                                                    gr.FillRectangle(Brushes.LightSalmon, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(fLin(x, k2, b2)) - ytoj(y));
                                                                }
                                                                x = (x + H);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }   
    }
}
