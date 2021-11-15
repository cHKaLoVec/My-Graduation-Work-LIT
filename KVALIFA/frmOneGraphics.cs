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
    public partial class frmOneGraphics : Form
    {
        public frmOneGraphics()
        {
            InitializeComponent();
        }
        Pen myPen;
        Graphics gr;
        Bitmap bitmap;
        double k, a, b, c, d, m, n1, b1, b2;
        int i1, i2, j1, j2, n;
        double x1 = -10, x2 = 10, y1 = -10, y2 = 10, h, x, y;
        double xi11, xi12;
        double xi21, xi22;
        double S, H;
        int N;
        double xi1, xi2;
        bool linF = false;
        bool quadF = false;
        bool revF = false;
        bool sqrtF = false;
        bool logF = false;
        bool powF = false;
        bool expF = false;
        bool sinF = false;
        bool cosF = false;
        bool tgF = false;
        bool ctgF = false;

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

        int z = 2;
        void trigonometric_system_koordinat(double x1, double x2, double y1, double y2)
        {
            Font myFont = new Font("Times New Roman", 12, FontStyle.Italic);
            Pen pen_setka = new Pen(Brushes.LightBlue, 1);
            pen_setka.DashStyle = DashStyle.Dash;
            for (double p = 0; p <= (int)x2; p += Math.PI / 6)
            {
                gr.DrawLine(pen_setka, xtoi(p), ytoj(y2), xtoi(p), ytoj(y1));
            }
            for (double p = 0; p >= (int)x1; p -= Math.PI / 6)
            {
                gr.DrawLine(pen_setka, xtoi(p), ytoj(y2), xtoi(p), ytoj(y1));
            }
            for (double p = (int)y1; p <= (int)y2; p += 0.5)
            {
                gr.DrawLine(pen_setka, xtoi(x1), ytoj(p), xtoi(x2), ytoj(p));
            }
            Pen pen_os = new Pen(Brushes.Blue, 1);
            pen_os.EndCap = LineCap.ArrowAnchor;
            pen_os.StartCap = LineCap.Triangle;

            gr.DrawLine(pen_os, xtoi(x1), ytoj(0), xtoi(x2), ytoj(0)); //x
            gr.DrawLine(pen_os, xtoi(0), ytoj(y1), xtoi(0), ytoj(y2)); //y

            Font MyFont = new Font("arial", 8, FontStyle.Regular);
            z = 2;
            for (int p = 3; p <= x2 + 10; p += 3)
            {

                if (p == 3)
                {
                    gr.DrawString("π", MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
                }
                else
                {

                    gr.DrawString(Convert.ToString(z) + "π", MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
                    z++;
                }
            }
            z = 3;
            for (double p = 1.5; p <= x2 + 10; p += 3)
            {

                if (p == 1.5)
                {
                    gr.DrawString("π/2", MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
                }
                else
                {
                    gr.DrawString(Convert.ToString(z) + "π/2", MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
                    z += 2;
                }
            }
            z = -2;
            for (int p = -3; p >= x1; p -= 3)
            {

                if (p == -3)
                {
                    gr.DrawString("-π", MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
                }
                else
                {

                    gr.DrawString(Convert.ToString(z) + "π", MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
                    z--; ;
                }
            }
            z = -3;
            for (double p = -1.5; p >= x1; p -= 3)
            {

                if (p == -1.5)
                {
                    gr.DrawString("-π/2", MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
                }
                else
                {
                    gr.DrawString(Convert.ToString(z) + "π/2", MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
                    z -= 2;
                }
            }

            for (double p = 0; p <= y2; p++)
                gr.DrawString(Convert.ToString(p), MyFont, Brushes.Blue, new Point(xtoi(-0.5), ytoj(p + 0.1)));
            for (double p = -1; p >= y1; p--)
                gr.DrawString(Convert.ToString(p), MyFont, Brushes.Blue, new Point(xtoi(-0.6), ytoj(p + 0.1)));
            gr.DrawString("x", myFont, Brushes.Blue, xtoi(x2 - 0.5), ytoj(-0.2));
            gr.DrawString("y", myFont, Brushes.Blue, xtoi(-0.8), ytoj(y2 - 0.2));

            for (double i = 0; i <= x2; i += Math.PI / 2)
            {
                gr.DrawLine(Pens.Blue, xtoi(i), ytoj(0) - 5, xtoi(i), ytoj(0) + 5);
            }
            for (double i = 0; i >= x1; i -= Math.PI / 2)
            {
                gr.DrawLine(Pens.Blue, xtoi(i), ytoj(0) - 5, xtoi(i), ytoj(0) + 5);
            }
            for (int i = 0; i <= y2; i++)
            {
                gr.DrawLine(Pens.Blue, xtoi(0) - 5, ytoj(i), xtoi(0) + 5, ytoj(i));
            }
            for (int i = 0; i >= y1; i--)
            {
                gr.DrawLine(Pens.Blue, xtoi(0) - 5, ytoj(i), xtoi(0) + 5, ytoj(i));
            }
        }

        //form
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

        void LinFunSelected()
        {
            linF = true;
            quadF = false;
            revF = false;
            sqrtF = false;
            logF = false;
            powF = false;
            expF = false;
            sinF = false;
            cosF = false;
            tgF = false;
            ctgF = false;
            lblGivenFun.Visible = false;
            PB.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(219, 249, 184);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblQuadraticFun.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblReverseFun.BackColor = Color.FromArgb(136, 216, 105);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblSqrtFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblPowFun.BackColor = Color.FromArgb(136, 216, 105);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFun.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);
            lblSinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCosFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblTgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCtgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);
            pnlLinFun.Visible = true;
            pnlLinFun.Location = new Point(206, 82);
            pnlLinFun.Size = new Size(310, 617);
            pnlQuadFun.Visible = false;
            pnlQuadFun.Location = new Point(664, 98);
            pnlQuadFun.Size = new Size(82, 136);
            pnlRevFun.Visible = false;
            pnlRevFun.Location = new Point(800, 98);
            pnlRevFun.Size = new Size(123, 166);
            pnlSqrtFun.Visible = false;
            pnlSqrtFun.Location = new Point(921, 98);
            pnlSqrtFun.Size = new Size(134, 166);
            pnlLogFun.Visible = false;
            pnlLogFun.Location = new Point(1042, 98);
            pnlLogFun.Size = new Size(126, 166);
            pnlPowFun.Visible = false;
            pnlPowFun.Location = new Point(533, 270);
            pnlPowFun.Size=new Size(125, 161);
            pnlExpFun.Visible = false;
            pnlExpFun.Location = new Point(664, 270);
            pnlExpFun.Size = new Size(133, 161);
            pnlSinFun.Visible = false;
            pnlSinFun.Location = new Point(803, 270);
            pnlSinFun.Size = new Size(117, 158);
            pnlCosFun.Visible = false;
            pnlCosFun.Location = new Point(926, 270);
            pnlCosFun.Size = new Size(116, 153);
            pnlTgFun.Visible = false;
            pnlTgFun.Location = new Point(1051, 273);
            pnlTgFun.Size = new Size(117, 150);
            pnlCtgFun.Visible = false;
            pnlCtgFun.Location = new Point(533, 436);
            pnlCtgFun.Size = new Size(123, 206);
        }

        void QuadFunSelected()
        {
            linF = false;
            quadF = true;
            revF = false;
            sqrtF = false;
            logF = false;
            powF = false;
            expF = false;
            sinF = false;
            cosF = false;
            tgF = false;
            ctgF = false; PB.Visible = false;
            lblGivenFun.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblQuadraticFun.BackColor = Color.FromArgb(219, 249, 184);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblReverseFun.BackColor = Color.FromArgb(136, 216, 105);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblSqrtFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);
           
            lblPowFun.BackColor = Color.FromArgb(136, 216, 105);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFun.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);
            lblSinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCosFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblTgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCtgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);
            pnlLinFun.Visible = false;
            pnlLinFun.Location = new Point(544, 98);
            pnlLinFun.Size = new Size(82, 136);
            pnlQuadFun.Visible = true;
            pnlQuadFun.Location = new Point(206, 82);
            pnlQuadFun.Size = new Size(310, 617);
            pnlRevFun.Visible = false;
            pnlRevFun.Location = new Point(682, 98);
            pnlRevFun.Size = new Size(123, 166);
            pnlSqrtFun.Visible = false;
            pnlSqrtFun.Location = new Point(920, 98);
            pnlSqrtFun.Size = new Size(134, 166);
            pnlLogFun.Visible = false;
            pnlLogFun.Location = new Point(1042, 98);
            pnlLogFun.Size = new Size(126, 166);
            pnlPowFun.Visible = false;
            pnlPowFun.Location = new Point(533, 270);
            pnlPowFun.Size = new Size(125, 161);
            pnlExpFun.Visible = false;
            pnlExpFun.Location = new Point(664, 270);
            pnlExpFun.Size = new Size(133, 161);
            pnlSinFun.Visible = false;
            pnlSinFun.Location = new Point(803, 270);
            pnlSinFun.Size = new Size(117, 158);
            pnlCosFun.Visible = false;
            pnlCosFun.Location = new Point(926, 270);
            pnlCosFun.Size = new Size(116, 153);
            pnlTgFun.Visible = false;
            pnlTgFun.Location = new Point(1051, 273);
            pnlTgFun.Size = new Size(117, 150);
            pnlCtgFun.Visible = false;
            pnlCtgFun.Location = new Point(533, 436);
            pnlCtgFun.Size = new Size(123, 206);
        }

        void ReverseFunSelected()
        {
            linF = false;
            quadF = false;
            revF = true;
            sqrtF = false;
            logF = false;
            powF = false;
            expF = false;
            sinF = false;
            cosF = false;
            tgF = false;
            ctgF = false; PB.Visible = false;
            lblGivenFun.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblReverseFun.BackColor = Color.FromArgb(219, 249, 184);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblSqrtFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);
            
            lblPowFun.BackColor = Color.FromArgb(136, 216, 105);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFun.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);
            lblSinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCosFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblTgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCtgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);
            pnlLinFun.Visible = false;
            pnlLinFun.Location = new Point(544, 98);
            pnlLinFun.Size = new Size(82, 136);
            pnlQuadFun.Visible = false;
            pnlQuadFun.Location = new Point(682, 98);
            pnlQuadFun.Size = new Size(123, 166);
            pnlRevFun.Visible = true;
            pnlRevFun.Location = new Point(206, 82);
            pnlRevFun.Size = new Size(310, 617);
            pnlSqrtFun.Visible = false;
            pnlSqrtFun.Location = new Point(920, 98);
            pnlSqrtFun.Size = new Size(134, 166);
            pnlLogFun.Visible = false;
            pnlLogFun.Location = new Point(1042, 98);
            pnlLogFun.Size = new Size(126, 166);
            pnlPowFun.Visible = false;
            pnlPowFun.Location = new Point(533, 270);
            pnlPowFun.Size = new Size(125, 161);
            pnlExpFun.Visible = false;
            pnlExpFun.Location = new Point(664, 270);
            pnlExpFun.Size = new Size(133, 161);
            pnlSinFun.Visible = false;
            pnlSinFun.Location = new Point(803, 270);
            pnlSinFun.Size = new Size(117, 158);
            pnlCosFun.Visible = false;
            pnlCosFun.Location = new Point(926, 270);
            pnlCosFun.Size = new Size(116, 153);
            pnlTgFun.Visible = false;
            pnlTgFun.Location = new Point(1051, 273);
            pnlTgFun.Size = new Size(117, 150);
            pnlCtgFun.Visible = false;
            pnlCtgFun.Location = new Point(533, 436);
            pnlCtgFun.Size = new Size(123, 206);
        }

        void SqrtFunSelected()
        {
            linF = false;
            quadF = false;
            revF = false;
            sqrtF = true;
            logF = false;
            powF = false;
            expF = false;
            sinF = false;
            cosF = false;
            tgF = false;
            ctgF = false; PB.Visible = false;
            lblGivenFun.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblReverseFun.BackColor = Color.FromArgb(136, 216, 105);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblSqrtFun.BackColor = Color.FromArgb(219, 249, 184);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);

            
            lblPowFun.BackColor = Color.FromArgb(136, 216, 105);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFun.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);
            lblSinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCosFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblTgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCtgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);
            pnlLinFun.Visible = false;
            pnlLinFun.Location = new Point(544, 98);
            pnlLinFun.Size = new Size(82, 136);
            pnlQuadFun.Visible = false;
            pnlQuadFun.Location = new Point(682, 98);
            pnlQuadFun.Size = new Size(123, 166);
            pnlRevFun.Visible = false;
            pnlRevFun.Location = new Point(206, 82);
            pnlRevFun.Size = new Size(310, 617);
            pnlSqrtFun.Visible = true;
            pnlSqrtFun.Location = new Point(206, 82);
            pnlSqrtFun.Size = new Size(310, 637);
            pnlLogFun.Visible = false;
            pnlLogFun.Location = new Point(1042, 98);
            pnlLogFun.Size = new Size(126, 166);
            pnlPowFun.Visible = false;
            pnlPowFun.Location = new Point(533, 270);
            pnlPowFun.Size = new Size(125, 161);
            pnlExpFun.Visible = false;
            pnlExpFun.Location = new Point(664, 270);
            pnlExpFun.Size = new Size(133, 161);
            pnlSinFun.Visible = false;
            pnlSinFun.Location = new Point(803, 270);
            pnlSinFun.Size = new Size(117, 158);
            pnlCosFun.Visible = false;
            pnlCosFun.Location = new Point(926, 270);
            pnlCosFun.Size = new Size(116, 153);
            pnlTgFun.Visible = false;
            pnlTgFun.Location = new Point(1051, 273);
            pnlTgFun.Size = new Size(117, 150);
            pnlCtgFun.Visible = false;
            pnlCtgFun.Location = new Point(533, 436);
            pnlCtgFun.Size = new Size(123, 206);
        }

        void LogFunSelected()
        {
            linF = false;
            quadF = false;
            revF = false;
            sqrtF = false;
            logF = true;
            powF = false;
            expF = false;
            sinF = false;
            cosF = false;
            tgF = false;
            ctgF = false; PB.Visible = false;
            lblGivenFun.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblReverseFun.BackColor = Color.FromArgb(136, 216, 105);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblSqrtFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);

            
            lblPowFun.BackColor = Color.FromArgb(136, 216, 105);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFun.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);
            lblSinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCosFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblTgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCtgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);
            pnlLinFun.Visible = false;
            pnlLinFun.Location = new Point(533, 98);
            pnlLinFun.Size = new Size(310, 617);
            pnlQuadFun.Visible = false;
            pnlQuadFun.Location = new Point(664, 98);
            pnlQuadFun.Size = new Size(82, 136);
            pnlRevFun.Visible = false;
            pnlRevFun.Location = new Point(800, 98);
            pnlRevFun.Size = new Size(123, 166);
            pnlSqrtFun.Visible = false;
            pnlSqrtFun.Location = new Point(921, 98);
            pnlSqrtFun.Size = new Size(134, 166);
            pnlLogFun.Visible = true;
            pnlLogFun.Location = new Point(206, 82);
            pnlLogFun.Size = new Size(310, 637);
            pnlPowFun.Visible = false;
            pnlPowFun.Location = new Point(533, 270);
            pnlPowFun.Size = new Size(125, 161);
            pnlExpFun.Visible = false;
            pnlExpFun.Location = new Point(664, 270);
            pnlExpFun.Size = new Size(133, 161);
            pnlSinFun.Visible = false;
            pnlSinFun.Location = new Point(803, 270);
            pnlSinFun.Size = new Size(117, 158);
            pnlCosFun.Visible = false;
            pnlCosFun.Location = new Point(926, 270);
            pnlCosFun.Size = new Size(116, 153);
            pnlTgFun.Visible = false;
            pnlTgFun.Location = new Point(1051, 273);
            pnlTgFun.Size = new Size(117, 150);
            pnlCtgFun.Visible = false;
            pnlCtgFun.Location = new Point(533, 436);
            pnlCtgFun.Size = new Size(123, 206);
        }

        void PowFunSelected()
        {
            linF = false;
            quadF = false;
            revF = false;
            sqrtF = false;
            logF = false;
            powF = true;
            expF = false;
            sinF = false;
            cosF = false;
            tgF = false;
            ctgF = false; PB.Visible = false;
            lblGivenFun.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblReverseFun.BackColor = Color.FromArgb(136, 216, 105);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblSqrtFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);
           

            lblPowFun.BackColor = Color.FromArgb(219, 249, 184);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblExpFun.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);
            lblSinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCosFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblTgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCtgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);
            pnlLinFun.Visible = false;
            pnlLinFun.Location = new Point(533, 98);
            pnlLinFun.Size = new Size(310, 617);
            pnlQuadFun.Visible = false;
            pnlQuadFun.Location = new Point(664, 98);
            pnlQuadFun.Size = new Size(82, 136);
            pnlRevFun.Visible = false;
            pnlRevFun.Location = new Point(800, 98);
            pnlRevFun.Size = new Size(123, 166);
            pnlSqrtFun.Visible = false;
            pnlSqrtFun.Location = new Point(921, 98);
            pnlSqrtFun.Size = new Size(134, 166);
            pnlLogFun.Visible = false;
            pnlLogFun.Location = new Point(1042, 98);
            pnlLogFun.Size = new Size(126, 166);
            pnlPowFun.Visible = true;
            pnlPowFun.Location = new Point(206, 82);
            pnlPowFun.Size = new Size(310, 637);
            pnlExpFun.Visible = false;
            pnlExpFun.Location = new Point(664, 270);
            pnlExpFun.Size = new Size(133, 161);
            pnlSinFun.Visible = false;
            pnlSinFun.Location = new Point(803, 270);
            pnlSinFun.Size = new Size(117, 158);
            pnlCosFun.Visible = false;
            pnlCosFun.Location = new Point(926, 270);
            pnlCosFun.Size = new Size(116, 153);
            pnlTgFun.Visible = false;
            pnlTgFun.Location = new Point(1051, 273);
            pnlTgFun.Size = new Size(117, 150);
            pnlCtgFun.Visible = false;
            pnlCtgFun.Location = new Point(533, 436);
            pnlCtgFun.Size = new Size(123, 206);
        }

        void ExpFunSelected()
        {
            linF = false;
            quadF = false;
            revF = false;
            sqrtF = false;
            logF = false;
            powF = false;
            expF = true;
            sinF = false;
            cosF = false;
            tgF = false;
            ctgF = false;
            PB.Visible = false;
            lblGivenFun.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblReverseFun.BackColor = Color.FromArgb(136, 216, 105);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblSqrtFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);
          
            lblPowFun.BackColor = Color.FromArgb(136, 216, 105);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);
            
            lblExpFun.BackColor = Color.FromArgb(219, 249, 184);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(219, 249, 184);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);

            lblSinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCosFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblTgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCtgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);
            pnlLinFun.Visible = false;
            pnlLinFun.Location = new Point(533, 98);
            pnlLinFun.Size = new Size(310, 617);
            pnlQuadFun.Visible = false;
            pnlQuadFun.Location = new Point(664, 98);
            pnlQuadFun.Size = new Size(82, 136);
            pnlRevFun.Visible = false;
            pnlRevFun.Location = new Point(800, 98);
            pnlRevFun.Size = new Size(123, 166);
            pnlSqrtFun.Visible = false;
            pnlSqrtFun.Location = new Point(921, 98);
            pnlSqrtFun.Size = new Size(134, 166);
            pnlLogFun.Visible = false;
            pnlLogFun.Location = new Point(1042, 98);
            pnlLogFun.Size = new Size(126, 166);
            pnlPowFun.Visible = false;
            pnlPowFun.Location = new Point(533, 270);
            pnlPowFun.Size = new Size(125, 161);
            pnlExpFun.Visible = true;
            pnlExpFun.Location = new Point(206, 82);
            pnlExpFun.Size = new Size(310, 637);
            pnlSinFun.Visible = false;
            pnlSinFun.Location = new Point(803, 270);
            pnlSinFun.Size = new Size(117, 158);
            pnlCosFun.Visible = false;
            pnlCosFun.Location = new Point(926, 270);
            pnlCosFun.Size = new Size(116, 153);
            pnlTgFun.Visible = false;
            pnlTgFun.Location = new Point(1051, 273);
            pnlTgFun.Size = new Size(117, 150);
            pnlCtgFun.Visible = false;
            pnlCtgFun.Location = new Point(533, 436);
            pnlCtgFun.Size = new Size(123, 206);
        }

        void SinFunSelected()
        {
            linF = false;
            quadF = false;
            revF = false;
            sqrtF = false;
            logF = false;
            powF = false;
            expF = false;
            sinF = true;
            cosF = false;
            tgF = false;
            ctgF = false;
            PB.Visible = false;
            lblGivenFun.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblReverseFun.BackColor = Color.FromArgb(136, 216, 105);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblSqrtFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);
            
            lblPowFun.BackColor = Color.FromArgb(136, 216, 105);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFun.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);

            lblSinFun.BackColor = Color.FromArgb(219, 249, 184);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblCosFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblTgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCtgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);
            pnlLinFun.Visible = false;
            pnlLinFun.Location = new Point(533, 98);
            pnlLinFun.Size = new Size(310, 617);
            pnlQuadFun.Visible = false;
            pnlQuadFun.Location = new Point(664, 98);
            pnlQuadFun.Size = new Size(82, 136);
            pnlRevFun.Visible = false;
            pnlRevFun.Location = new Point(800, 98);
            pnlRevFun.Size = new Size(123, 166);
            pnlSqrtFun.Visible = false;
            pnlSqrtFun.Location = new Point(921, 98);
            pnlSqrtFun.Size = new Size(134, 166);
            pnlLogFun.Visible = false;
            pnlLogFun.Location = new Point(1042, 98);
            pnlLogFun.Size = new Size(126, 166);
            pnlPowFun.Visible = false;
            pnlPowFun.Location = new Point(533, 270);
            pnlPowFun.Size = new Size(125, 161);
            pnlExpFun.Visible = false;
            pnlExpFun.Location = new Point(664, 270);
            pnlExpFun.Size = new Size(133, 161);
            pnlSinFun.Visible = true;
            pnlSinFun.Location = new Point(206, 82);
            pnlSinFun.Size = new Size(310, 637);
            pnlCosFun.Visible = false;
            pnlCosFun.Location = new Point(926, 270);
            pnlCosFun.Size = new Size(116, 153);
            pnlTgFun.Visible = false;
            pnlTgFun.Location = new Point(1051, 273);
            pnlTgFun.Size = new Size(117, 150);
            pnlCtgFun.Visible = false;
            pnlCtgFun.Location = new Point(533, 436);
            pnlCtgFun.Size = new Size(123, 206);
        }

        void CosFunSelected()
        {
            linF = false;
            quadF = false;
            revF = false;
            sqrtF = false;
            logF = false;
            powF = false;
            expF = false;
            sinF = false;
            cosF = true;
            tgF = false;
            ctgF = false;
            PB.Visible = false;
            lblGivenFun.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblReverseFun.BackColor = Color.FromArgb(136, 216, 105);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblSqrtFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);
           
            lblPowFun.BackColor = Color.FromArgb(136, 216, 105);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFun.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);
            lblSinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblCosFun.BackColor = Color.FromArgb(219, 249, 184);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblTgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCtgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);
            pnlLinFun.Visible = false;
            pnlLinFun.Location = new Point(533, 98);
            pnlLinFun.Size = new Size(310, 617);
            pnlQuadFun.Visible = false;
            pnlQuadFun.Location = new Point(664, 98);
            pnlQuadFun.Size = new Size(82, 136);
            pnlRevFun.Visible = false;
            pnlRevFun.Location = new Point(800, 98);
            pnlRevFun.Size = new Size(123, 166);
            pnlSqrtFun.Visible = false;
            pnlSqrtFun.Location = new Point(921, 98);
            pnlSqrtFun.Size = new Size(134, 166);
            pnlLogFun.Visible = false;
            pnlLogFun.Location = new Point(1042, 98);
            pnlLogFun.Size = new Size(126, 166);
            pnlPowFun.Visible = false;
            pnlPowFun.Location = new Point(533, 270);
            pnlPowFun.Size = new Size(125, 161);
            pnlExpFun.Visible = false;
            pnlExpFun.Location = new Point(664, 270);
            pnlExpFun.Size = new Size(133, 161);
            pnlSinFun.Visible = false;
            pnlSinFun.Location = new Point(803, 270);
            pnlSinFun.Size = new Size(117, 158);
            pnlCosFun.Visible = true;
            pnlCosFun.Location = new Point(206, 82);
            pnlCosFun.Size = new Size(310, 637);
            pnlTgFun.Visible = false;
            pnlTgFun.Location = new Point(1051, 273);
            pnlTgFun.Size = new Size(117, 150);
            pnlCtgFun.Visible = false;
            pnlCtgFun.Location = new Point(533, 436);
            pnlCtgFun.Size = new Size(123, 206);
        }

        void TgFunSelected()
        {
            linF = false;
            quadF = false;
            revF = false;
            sqrtF = false;
            logF = false;
            powF = false;
            expF = false;
            sinF = false;
            cosF = false;
            tgF = true ;
            ctgF = false;
            PB.Visible = false;
            lblGivenFun.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblReverseFun.BackColor = Color.FromArgb(136, 216, 105);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblSqrtFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);
           
            lblPowFun.BackColor = Color.FromArgb(136, 216, 105);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFun.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);
            lblSinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCosFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblTgFun.BackColor = Color.FromArgb(219, 249, 184);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblCtgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);
            pnlLinFun.Visible = false;
            pnlLinFun.Location = new Point(533, 98);
            pnlLinFun.Size = new Size(310, 617);
            pnlQuadFun.Visible = false;
            pnlQuadFun.Location = new Point(664, 98);
            pnlQuadFun.Size = new Size(82, 136);
            pnlRevFun.Visible = false;
            pnlRevFun.Location = new Point(800, 98);
            pnlRevFun.Size = new Size(123, 166);
            pnlSqrtFun.Visible = false;
            pnlSqrtFun.Location = new Point(921, 98);
            pnlSqrtFun.Size = new Size(134, 166);
            pnlLogFun.Visible = false;
            pnlLogFun.Location = new Point(1042, 98);
            pnlLogFun.Size = new Size(126, 166);
            pnlPowFun.Visible = false;
            pnlPowFun.Location = new Point(533, 270);
            pnlPowFun.Size = new Size(125, 161);
            pnlExpFun.Visible = false;
            pnlExpFun.Location = new Point(664, 270);
            pnlExpFun.Size = new Size(133, 161);
            pnlSinFun.Visible = false;
            pnlSinFun.Location = new Point(803, 270);
            pnlSinFun.Size = new Size(117, 158);
            pnlCosFun.Visible = false;
            pnlCosFun.Location = new Point(926, 270);
            pnlCosFun.Size = new Size(116, 153);
            pnlTgFun.Visible = true;
            pnlTgFun.Location = new Point(206, 82);
            pnlTgFun.Size = new Size(310, 637);
            pnlCtgFun.Visible = false;
            pnlCtgFun.Location = new Point(533, 436);
            pnlCtgFun.Size = new Size(123, 206);
        }

        void CtgFunSelected()
        {
            linF = false;
            quadF = false;
            revF = false;
            sqrtF = false;
            logF = false;
            powF = false;
            expF = false;
            sinF = false;
            cosF = false;
            tgF = false;
            ctgF = true;
            PB.Visible = false;
            lblGivenFun.Visible = false;
            lblLinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblLinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblQuadraticFun.BackColor = Color.FromArgb(136, 216, 105);
            lblQuadraticFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblReverseFun.BackColor = Color.FromArgb(136, 216, 105);
            lblReverseFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblSqrtFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSqrtFun.ForeColor = Color.FromArgb(0, 0, 0);
            
            lblPowFun.BackColor = Color.FromArgb(136, 216, 105);
            lblPowFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFun.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblExpFunX.BackColor = Color.FromArgb(136, 216, 105);
            lblExpFunX.ForeColor = Color.FromArgb(0, 0, 0);
            lblSinFun.BackColor = Color.FromArgb(136, 216, 105);
            lblSinFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblCosFun.BackColor = Color.FromArgb(136, 216, 105);
            lblCosFun.ForeColor = Color.FromArgb(0, 0, 0);
            lblTgFun.BackColor = Color.FromArgb(136, 216, 105);
            lblTgFun.ForeColor = Color.FromArgb(0, 0, 0);

            lblCtgFun.BackColor = Color.FromArgb(219, 249, 184);
            lblCtgFun.ForeColor = Color.FromArgb(0, 0, 0);

            pnlLinFun.Visible = false;
            pnlLinFun.Location = new Point(533, 98);
            pnlLinFun.Size = new Size(310, 617);
            pnlQuadFun.Visible = false;
            pnlQuadFun.Location = new Point(664, 98);
            pnlQuadFun.Size = new Size(82, 136);
            pnlRevFun.Visible = false;
            pnlRevFun.Location = new Point(800, 98);
            pnlRevFun.Size = new Size(123, 166);
            pnlSqrtFun.Visible = false;
            pnlSqrtFun.Location = new Point(921, 98);
            pnlSqrtFun.Size = new Size(134, 166);
            pnlLogFun.Visible = false;
            pnlLogFun.Location = new Point(1042, 98);
            pnlLogFun.Size = new Size(126, 166);
            pnlPowFun.Visible = false;
            pnlPowFun.Location = new Point(533, 270);
            pnlPowFun.Size = new Size(125, 161);
            pnlExpFun.Visible = false;
            pnlExpFun.Location = new Point(664, 270);
            pnlExpFun.Size = new Size(133, 161);
            pnlSinFun.Visible = false;
            pnlSinFun.Location = new Point(803, 270);
            pnlSinFun.Size = new Size(117, 158);
            pnlCosFun.Visible = false;
            pnlCosFun.Location = new Point(926, 270);
            pnlCosFun.Size = new Size(116, 153);
            pnlTgFun.Visible = false;
            pnlTgFun.Location = new Point(1051, 273);
            pnlTgFun.Size = new Size(117, 150);
            pnlCtgFun.Visible = true;
            pnlCtgFun.Location = new Point(206, 82);
            pnlCtgFun.Size = new Size(310, 637);
        }

        //label
        private void lblLinFun_Click(object sender, EventArgs e)
        {
            LinFunSelected();
        }

        private void lblQuadraticFun_Click(object sender, EventArgs e)
        {
            QuadFunSelected();
        }

        private void lblReverseFun_Click(object sender, EventArgs e)
        {
            ReverseFunSelected();
        }

        private void lblSqrtFun_Click(object sender, EventArgs e)
        {
            SqrtFunSelected();
        }

        private void lblLogFun_Click(object sender, EventArgs e)
        {
            LogFunSelected();
        }


        private void pctClose_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                timerMinus.Start();
                timerPlus.Stop();
                this.pctClose.Image = global::KVALIFA.Properties.Resources.closeR;
            }
            catch
            {
                return;
            }
            
        }

        private void timerPlus_Tick(object sender, EventArgs e)
        {
            try
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
            catch
            {
                return;
            }
        }

        private void timerMinus_Tick(object sender, EventArgs e)
        {
            try
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
            catch
            {
                return;
            }
        }

        private void pctClose_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                timerPlus.Start();
                timerMinus.Stop();
                this.pctClose.Image = global::KVALIFA.Properties.Resources.RedB;
                label9.Visible = false;

            }
            catch
            {
                return;
            }
        }

        private void lblPowFun_Click(object sender, EventArgs e)
        {
            PowFunSelected();
        }

        private void lblExpFun_Click(object sender, EventArgs e)
        {
            ExpFunSelected();
        }

        private void lblSinFun_Click(object sender, EventArgs e)
        {
            SinFunSelected();
        }

        private void lblCosFun_Click(object sender, EventArgs e)
        {
            CosFunSelected();
        }

        private void lblTgFun_Click(object sender, EventArgs e)
        {
            TgFunSelected();
        }

        private void lblCtgFun_Click(object sender, EventArgs e)
        {
            CtgFunSelected();
        }
        
        private void btn1_Plus_Click(object sender, EventArgs e)
        {
            try
            {
                if (x1 != 1)
                {
                    x1 += 1;
                    x2 -= 1;
                    y1 += 1;
                    y2 -= 1;
                }
                if (linF)
                    btn1_Build.PerformClick();
                if (quadF)
                    btn2_Build.PerformClick();
                if (revF)
                    btn3_Build.PerformClick();
                if (sqrtF)
                    btn4_Build.PerformClick();
                if (logF)
                    btn5_Build.PerformClick();
                if (powF)
                    btn6_Build.PerformClick();
                if (expF)
                    btn7_Build.PerformClick();
                if (sinF)
                    btn8_Build.PerformClick();
                if (cosF)
                    btn9_Build.PerformClick();
                if (tgF)
                    btn10_Build.PerformClick();
                if (ctgF)
                    btn11_Build.PerformClick();
            }
            catch
            {
                return;
            }
        }

        private void btn1_Minus_Click(object sender, EventArgs e)
        {
            try
            {
                x1 -= 1;
                x2 += 1;
                y1 -= 1;
                y2 += 1;
                if (linF)
                    btn1_Build.PerformClick();
                if (quadF)
                    btn2_Build.PerformClick();
                if (revF)
                    btn3_Build.PerformClick();
                if (sqrtF)
                    btn4_Build.PerformClick();
                if (logF)
                    btn5_Build.PerformClick();
                if (powF)
                    btn6_Build.PerformClick();
                if (expF)
                    btn7_Build.PerformClick();
                if (sinF)
                    btn8_Build.PerformClick();
                if (cosF)
                    btn9_Build.PerformClick();
                if (tgF)
                    btn10_Build.PerformClick();
                if (ctgF)
                    btn11_Build.PerformClick();
            }
            catch
            {
                return;
            }
        }

        private void txt1_B_KeyPress(object sender, KeyPressEventArgs e)
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

        //Linear Function
        double fLin(double xt, double k, double b)
        {
            return k * xt + b;
        }

        private void btn1_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt1_K.Text == "")
                {
                    txt1_K.Text = "1";
                }
                if (txt1_B.Text == "")
                {
                    txt1_B.Text = "0";
                }
                try
                {
                    k = double.Parse(txt1_K.Text);
                    b = double.Parse(txt1_B.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                myPen = new Pen(Color.Red, 3);
                //gr = PB.CreateGraphics();
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
                    y = fLin(x, k, b);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(fLin(x, k, b)), xtoi(x + h), ytoj(fLin(x + h, k, b)));
                    }
                    x = x + h;

                }
                PB.Image = bitmap;
                if(k==1 && b>0)
                {
                    lblGivenFun.Text = "Задана функція: y = x + " + Math.Abs(b);
                }
                else
                {
                    if (k == 1 && b < 0)
                    {
                        lblGivenFun.Text = "Задана функція: y = x - " + Math.Abs(b);
                    }
                    else
                    {
                        if (k != 1 && b > 0)
                        {
                            lblGivenFun.Text = "Задана функція: y = " + k + "x + " + Math.Abs(b);
                        }
                        else
                        {
                            if (k != 1 && b < 0)
                            {
                                lblGivenFun.Text = "Задана функція: y = " + k + "x - " + Math.Abs(b);
                            }
                            else
                            {
                                if (k == 1 && b == 0)
                                {
                                    lblGivenFun.Text = "Задана функція: y = x";
                                }
                                else
                                {
                                    lblGivenFun.Text = "Задана функція: y = " + k + "x";

                                }
                            }
                        }
                    }
                }
                //  PB.Visible = true;
            }
            catch
            {
                return;
            }
        }

        private void btn1_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                btn1_Build.PerformClick();
                if (txt1_X1.Text == "")
                {
                    txt1_X1.Text = "1";
                }
                if (txt1_X2.Text == "")
                {
                    txt1_X2.Text = "3";
                }
                if (txt1_N.Text == "")
                {
                    txt1_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt1_X1.Text);
                    xi2 = double.Parse(txt1_X2.Text);
                    N = int.Parse(txt1_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2) 
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0) 
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }

                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                H = (xi2 - xi1) / N;
                S = 0;
                for (double i = xi1; i <= xi2 - 2 * H; i += H)
                {
                    y = fLin(i, k, b);
                    S += H * y;
                }
                lbl1_SFRect.Visible = true;
                lbl1_SFRect.Text = "S = " + Math.Round(S, 2);

                x = xi1;
                while (x <= xi2)
                {
                    y = fLin(x, k, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn1_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                btn1_Build.PerformClick();
                if (txt1_X1.Text == "")
                {
                    txt1_X1.Text = "1";
                }
                if (txt1_X2.Text == "")
                {
                    txt1_X2.Text = "3";
                }
                if (txt1_N.Text == "")
                {
                    txt1_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt1_X1.Text);
                    xi2 = double.Parse(txt1_X2.Text);
                    N = int.Parse(txt1_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                H = (xi2 - xi1) / N;
                S = H * ((fLin(xi1, k, b) + fLin(xi2, k, b)) / 2);
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = fLin(i, k, b);
                    S += H * y;
                }
                lbl1_SFTrap.Visible = true;
                lbl1_SFTrap.Text = "S = " + Math.Round(S, 2);

                x = xi1;
                while (x <= xi2)
                {
                    y = fLin(x, k, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn1_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                btn1_Build.PerformClick();
                if (txt1_X1.Text == "")
                {
                    txt1_X1.Text = "1";
                }
                if (txt1_X2.Text == "")
                {
                    txt1_X2.Text = "3";
                }
                if (txt1_N.Text == "")
                {
                    txt1_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt1_X1.Text);
                    xi2 = double.Parse(txt1_X2.Text);
                    N = int.Parse(txt1_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                double H1 = (xi2 - xi1) / N;
                H = H1 / 3;
                S = 0;
                double S1 = H * ((fLin(xi1, k, b) + fLin(xi2, k, b)) / 2);
                double S2 = 0;
                double S3 = 0;
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = fLin(i, k, b);
                    S2 += H * y;
                }
                for (double i = (xi1 + H / 2); i <= xi2 - 3 * H / 2; i += H)
                {
                    y = fLin(i, k, b);
                    S3 += 2 * H * y;
                }
                S = S1 + S2 + S3;
                S /= 3;
                lbl1_SFSympson.Visible = true;
                lbl1_SFSympson.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fLin(x, k, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn1_FIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                btn1_Build.PerformClick();
                if (txt1_X1.Text == "")
                {
                    txt1_X1.Text = "1";
                }
                if (txt1_X2.Text == "")
                {
                    txt1_X2.Text = "3";
                }
                if (txt1_N.Text == "")
                {
                    txt1_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt1_X1.Text);
                    xi2 = double.Parse(txt1_X2.Text);
                    N = int.Parse(txt1_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                S = (k * (xi2 * xi2) / 2 + b * xi2) - (k * (xi1 * xi1) / 2 + b * xi1);
                lbl1_SFIntegral.Visible = true;
                lbl1_SFIntegral.Text = "S = " + Math.Round(S, 2);

                x = xi1;
                while (x <= xi2)
                {
                    y = fLin(x, k, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        //Quadratic Function
        double fQuad(double xt, double a, double b, double c)
        {
            double ff = a * xt * xt + b * xt + c;
            return ff;
        }

        private void btn2_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt2_A.Text == "")
                {
                    txt2_A.Text = "-1";
                }
                if (txt2_B.Text == "")
                {
                    txt2_B.Text = "4";
                }
                if (txt2_C.Text == "")
                {
                    txt2_C.Text = "-1";
                }
                try
                {
                    a = double.Parse(txt2_A.Text);
                    b = double.Parse(txt2_B.Text);
                    c = double.Parse(txt2_C.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                myPen = new Pen(Color.Red, 3);
                //gr = PB.CreateGraphics();
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
                    y = fQuad(x, a, b, c);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(fQuad(x, a, b, c)), xtoi(x + h), ytoj(fQuad(x + h, a, b, c)));
                    }
                    x = x + h;

                }
                PB.Image = bitmap;
                
                //   вывод Заданая функция
                lblGivenFun.Text = "Задана функція: y = ";
                if (a == 1) 
                {
                    lblGivenFun.Text += "x\u00B2 ";
                }
                else
                {
                    if (a == -1)
                    {
                        lblGivenFun.Text += "- x\u00B2 ";
                    }
                    else
                    {
                        lblGivenFun.Text += a + "x\u00B2 ";
                    }
                }
                if(b > 0)
                {
                    lblGivenFun.Text += "+ "+Math.Abs(b)+"x ";
                }
                else
                {
                    if (b < 0)
                    {
                        lblGivenFun.Text += "- " + Math.Abs(b) + "x ";
                    }
                }
                if (c > 0)
                {
                    lblGivenFun.Text += "+ " + Math.Abs(c);
                }
                else
                {
                    if (c < 0)
                    {
                        lblGivenFun.Text += "- " + Math.Abs(c);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn2_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                lbl2_SFRect.Visible = true;
                btn2_Build.PerformClick();
                if (txt2_X1.Text == "")
                {
                    txt2_X1.Text = "1";
                }
                if (txt2_X2.Text == "")
                {
                    txt2_X2.Text = "3";
                }
                if (txt2_N.Text == "")
                {
                    txt2_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt2_X1.Text);
                    xi2 = double.Parse(txt2_X2.Text);
                    N = int.Parse(txt2_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                H = (xi2 - xi1) / N;
                S = 0;
                for (double i = xi1; i <= xi2 - 2 * H; i += H)
                {
                    y = fQuad(i, a, b, c);
                    S += H * y;
                }
                lbl2_SFRect.Text = "S = " + Math.Round(S, 2);

                x = xi1;
                while (x <= xi2)
                {
                    y = fQuad(x, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn2_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                lbl2_SFTrap.Visible = true;
                btn2_Build.PerformClick();
                if (txt2_X1.Text == "")
                {
                    txt2_X1.Text = "1";
                }
                if (txt2_X2.Text == "")
                {
                    txt2_X2.Text = "3";
                }
                if (txt2_N.Text == "")
                {
                    txt2_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt2_X1.Text);
                    xi2 = double.Parse(txt2_X2.Text);
                    N = int.Parse(txt2_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                H = (xi2 - xi1) / N;
                S = H * ((fQuad(xi1, a, b, c) + fQuad(xi2, a, b, c)) / 2);
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = fQuad(i, a, b, c);
                    S += H * y;
                }
                lbl2_SFTrap.Text = "S = " + Math.Round(S, 2);

                x = xi1;
                while (x <= xi2)
                {
                    y = fQuad(x, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn2_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                lbl2_SFSympson.Visible = true;
                btn2_Build.PerformClick();
                if (txt2_X1.Text == "")
                {
                    txt2_X1.Text = "1";
                }
                if (txt2_X2.Text == "")
                {
                    txt2_X2.Text = "3";
                }
                if (txt2_N.Text == "")
                {
                    txt2_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt2_X1.Text);
                    xi2 = double.Parse(txt2_X2.Text);
                    N = int.Parse(txt2_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                double H1 = (xi2 - xi1) / N;
                H = H1 / 3;
                S = 0;
                double S1 = H * ((fQuad(xi1, a, b, c) + fQuad(xi2, a, b, c)) / 2);
                double S2 = 0;
                double S3 = 0;
                for (double i = xi1 + H; i <= xi2 - H; i += H)
                {
                    y = fQuad(i, a, b, c);
                    S2 += H * y;
                }
                for (double i = (xi1 + H / 2); i <= xi2 - H / 2; i += H)
                {
                    y = fQuad(i, a, b, c);
                    S3 += 2 * H * y;
                }
                S = S1 + S2 + S3;
                S = S / 3;
                lbl2_SFSympson.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fQuad(x, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn2_FIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                lbl2_SFIntegral.Visible = true;
                btn2_Build.PerformClick();
                if (txt2_X1.Text == "")
                {
                    txt2_X1.Text = "1";
                }
                if (txt2_X2.Text == "")
                {
                    txt2_X2.Text = "3";
                }
                if (txt2_N.Text == "")
                {
                    txt2_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt2_X1.Text);
                    xi2 = double.Parse(txt2_X2.Text);
                    N = int.Parse(txt2_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }

                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                S = (a / 3 * (xi2 * xi2 * xi2) + b / 2 * (xi2 * xi2) + c * xi2) - (a / 3 * (xi1 * xi1 * xi1) + b / 2 * (xi1 * xi1) + c * xi1);
                lbl2_SFIntegral.Text = "S = " + Math.Round(S, 2);

                x = xi1;
                while (x <= xi2)
                {
                    y = fQuad(x, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        //Reverse function
        double fRev(double xt, double k, double a, double b)
        {
            double ff = (k / (xt + a)) + b;
            return ff;
        }

        private void btn3_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt3_K.Text == "")
                {
                    txt3_K.Text = "1";

                }
                if (txt3_A.Text == "")
                {
                    txt3_A.Text = "0";
                }
                if (txt3_B.Text == "")
                {
                    txt3_B.Text = "0";
                }
                try
                {
                    k = double.Parse(txt3_K.Text);
                    a = double.Parse(txt3_A.Text);
                    b = double.Parse(txt3_B.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                myPen = new Pen(Color.Red, 3);
                //gr = PB.CreateGraphics();
                gr.Clear(Color.White);
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                system_koordinat(x1, x2, y1, y2);

                n = PB.Width;
                h = (x2 - x1) / n;

                if (a >= 0)
                {
                    x = x1;
                    while (x <= -a - 0.1)
                    {
                        y = fRev(x, k, a, b);
                        if (y < y2)
                        {
                            gr.DrawLine(myPen, xtoi(x), ytoj(fRev(x, k, a, b)), xtoi(x + h), ytoj(fRev(x + h, k, a, b)));
                        }
                        x = x + h;

                    }

                    x = -a + 0.1;
                    while (x >= -a + 0.1 && x < x2)
                    {
                        y = fRev(x, k, a, b);
                        if (y < y2)
                        {
                            gr.DrawLine(myPen, xtoi(x), ytoj(fRev(x, k, a, b)), xtoi(x + h), ytoj(fRev(x + h, k, a, b)));
                        }
                        x = x + h;

                    }
                }
                else
                {
                    x = x1;
                    while (x < -a - 0.1)
                    {
                        y = fRev(x, k, a, b);
                        if (y < y2)
                        {
                            gr.DrawLine(myPen, xtoi(x), ytoj(fRev(x, k, a, b)), xtoi(x + h), ytoj(fRev(x + h, k, a, b)));
                        }
                        x = x + h;

                    }

                    x = -a + 0.1;
                    while (x >= -a + 0.1 && x < x2)
                    {
                        y = fRev(x, k, a, b);
                        if (y < y2)
                        {
                            gr.DrawLine(myPen, xtoi(x), ytoj(fRev(x, k, a, b)), xtoi(x + h), ytoj(fRev(x + h, k, a, b)));
                        }
                        x = x + h;

                    }
                }
                myPen.Color = Color.Orange;
                myPen.Width = 2;
                myPen.DashStyle = DashStyle.Dash;
                if (b != 0)
                {
                    gr.DrawLine(myPen, xtoi(x1), ytoj(b), xtoi(x2), ytoj(b));
                }
                if (a != 0)
                {
                    gr.DrawLine(myPen, xtoi(-a), ytoj(y1), xtoi(-a), ytoj(y2));
                }
                PB.Image = bitmap;
                lblGivenFun.Text = "Задана функція: y = ";
                if (a == 0)
                {
                    lblGivenFun.Text += k + " / x ";
                }
                else
                {
                    if (a > 0)
                    {
                        lblGivenFun.Text += k + " / (x + " + a + ") ";
                    }
                    else
                    {
                        if (a < 0)
                        {
                            lblGivenFun.Text += k + " / (x - " + Math.Abs(a) + ") ";
                        }
                    }
                }
                if(b > 0)
                {
                    lblGivenFun.Text += "+ " + b;
                }
                else
                {
                    if (b < 0)
                    {
                        lblGivenFun.Text += "- " + Math.Abs(b);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn3_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                lbl3_SFRect.Visible = true;
                btn3_Build.PerformClick();
                if (txt3_X1.Text == "")
                {
                    txt3_X1.Text = "1";
                }
                if (txt3_X2.Text == "")
                {
                    txt3_X2.Text = "3";
                }
                if (txt3_N.Text == "")
                {
                    txt3_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt3_X1.Text);
                    xi2 = double.Parse(txt3_X2.Text);
                    N = int.Parse(txt3_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                H = (xi2 - xi1) / N;
                S = 0;
                for (double i = xi1; i <= xi2 - 2 * H; i += H)
                {
                    y = fRev(i, k, a, b);
                    S += H * y;
                }
                lbl3_SFRect.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fRev(x, k, a, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn3_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                lbl3_SFTrap.Visible = true;
                btn3_Build.PerformClick();
                if (txt3_X1.Text == "")
                {
                    txt3_X1.Text = "1";
                }
                if (txt3_X2.Text == "")
                {
                    txt3_X2.Text = "3";
                }
                if (txt3_N.Text == "")
                {
                    txt3_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt3_X1.Text);
                    xi2 = double.Parse(txt3_X2.Text);
                    N = int.Parse(txt3_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));
                H = (xi2 - xi1) / N;
                S = H * ((fRev(xi1, k, a, b) + fRev(xi2, k, a, b)) / 2);
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = fRev(i, k, a, b);
                    S += H * y;
                }
                lbl3_SFTrap.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fRev(x, k, a, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn3_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                lbl3_SFSympson.Visible = true;
                btn3_Build.PerformClick();
                if (txt3_X1.Text == "")
                {
                    txt3_X1.Text = "1";
                }
                if (txt3_X2.Text == "")
                {
                    txt3_X2.Text = "3";
                }
                if (txt3_N.Text == "")
                {
                    txt3_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt3_X1.Text);
                    xi2 = double.Parse(txt3_X2.Text);
                    N = int.Parse(txt3_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));
                double H1 = (xi2 - xi1) / N;
                H = H1 / 3;
                S = 0;
                double S1 = H * ((fRev(xi1, k, a, b) + fRev(xi2, k, a, b)) / 2);
                double S2 = 0;
                double S3 = 0;
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = fRev(i, k, a, b);
                    S2 += H * y;
                }
                for (double i = (xi1 + H / 2); i <= xi2 - 3 * H / 2; i += H)
                {
                    y = fRev(i, k, a, b);
                    S3 += 2 * H * y;
                }
                S = S1 + S2 + S3;
                S /= 3;
                lbl3_SFSympson.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fRev(x, k, a, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn3_FIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                lbl3_SFIntegral.Visible = true;
                btn3_Build.PerformClick();
                if (txt3_X1.Text == "")
                {
                    txt3_X1.Text = "1";
                }
                if (txt3_X2.Text == "")
                {
                    txt3_X2.Text = "3";
                }
                if (txt2_N.Text == "")
                {
                    txt2_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt3_X1.Text);
                    xi2 = double.Parse(txt3_X2.Text);
                    N = int.Parse(txt3_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                S = k * Math.Log((xi2 + a) / (xi1 + a)) + b * (xi2 - xi1);
                lbl3_SFIntegral.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fRev(x, k, a, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        //Sqrt function
        double fSqrt(double xt, double k, double a, double b)
        {
            double ff = k * (Math.Sqrt(a * xt + b));
            return ff;  //k * Math.Pow(a * x + b, 0.5);
        }

        private void btn4_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt4_K.Text == "")
                {
                    txt4_K.Text = "1";
                }
                if (txt4_A.Text == "")
                {
                    txt4_A.Text = "1";
                }
                if (txt4_B.Text == "")
                {
                    txt4_B.Text = "0";
                }
                try
                {
                    k = double.Parse(txt4_K.Text);
                    a = double.Parse(txt4_A.Text);
                    b = double.Parse(txt4_B.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                myPen = new Pen(Color.Red, 3);
                //gr = PB.CreateGraphics();
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
                    y = fSqrt(x, k, a, b);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(fSqrt(x, k, a, b)), xtoi(x + h), ytoj(fSqrt(x + h, k, a, b)));
                    }
                    x = x + h;
                }
                lblGivenFun.Text = "Задана функція: y = ";
                if (k != 1) 
                {
                    lblGivenFun.Text += "" + k;
                }
                if (a == 0)
                {
                    lblGivenFun.Text += "√( ";
                }
                else
                {
                    if (a == 1)
                    {
                        lblGivenFun.Text += "√( x ";
                    }
                    else
                    {
                        lblGivenFun.Text += "√( " + a + "x ";
                    }
                }
                if (k == 0 && b == 0) 
                {
                    lblGivenFun.Text = "Задана функція: y = 0";
                }
                else
                {
                    if (k == 0 && b != 0)
                    {
                        lblGivenFun.Text = "Задана функція: y = ";
                    }
                    else
                    {

                    }
                }
                if (b > 0)
                {
                    lblGivenFun.Text += "+ " + b;
                }
                else
                {
                    if (b < 0)
                    {
                        lblGivenFun.Text += "- " + Math.Abs(b);
                    }
                }
                if(k!=0)
                    lblGivenFun.Text += ")";
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn4_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                lbl4_SFRect.Visible = true;
                btn4_Build.PerformClick();
                if (txt4_X1.Text == "")
                {
                    txt4_X1.Text = "1";
                }
                if (txt4_X2.Text == "")
                {
                    txt4_X2.Text = "3";
                }
                if (txt4_N.Text == "")
                {
                    txt4_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt4_X1.Text);
                    xi2 = double.Parse(txt4_X2.Text);
                    N = int.Parse(txt4_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                H = (xi2 - xi1) / N;
                S = 0;
                for (double i = xi1; i <= xi2 - 2 * H; i += H)
                {

                    y = fSqrt(i, k, a, b);
                    S += H * y;
                }
                lbl4_SFRect.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2 - H)
                {
                    y = fSqrt(x, k, a, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn4_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                lbl4_SFTrap.Visible = true;
                btn4_Build.PerformClick();
                if (txt4_X1.Text == "")
                {
                    txt4_X1.Text = "1";
                }
                if (txt4_X2.Text == "")
                {
                    txt4_X2.Text = "3";
                }
                if (txt4_N.Text == "")
                {
                    txt4_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt4_X1.Text);
                    xi2 = double.Parse(txt4_X2.Text);
                    N = int.Parse(txt4_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));
                H = (xi2 - xi1) / N;
                S = H * ((fSqrt(xi1, k, a, b) + fSqrt(xi2, k, a, b)) / 2);
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = fSqrt(i, k, a, b);
                    S += H * y;
                }
                lbl4_SFTrap.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fSqrt(x, k, a, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn4_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                lbl4_SFSympson.Visible = true;
                btn4_Build.PerformClick();
                if (txt4_X1.Text == "")
                {
                    txt4_X1.Text = "1";
                }
                if (txt4_X2.Text == "")
                {
                    txt4_X2.Text = "3";
                }
                if (txt4_N.Text == "")
                {
                    txt4_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt4_X1.Text);
                    xi2 = double.Parse(txt4_X2.Text);
                    N = int.Parse(txt4_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));
                double H1 = (xi2 - xi1) / N;
                H = H1 / 3;
                S = 0;
                double S1 = H * ((fSqrt(xi1, k, a, b) + fSqrt(xi2, k, a, b)) / 2);
                double S2 = 0;
                double S3 = 0;
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = fSqrt(i, k, a, b);
                    S2 += H * y;
                }
                for (double i = (xi1 + H / 2); i <= xi2 - 3 * H / 2; i += H)
                {
                    y = fSqrt(i, k, a, b);
                    S3 += 2 * H * y;
                }
                S = S1 + S2 + S3;
                S /= 3;
                lbl4_SFSympson.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fSqrt(x, k, a, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn4_FIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                lbl4_SFIntegral.Visible = true;
                btn4_Build.PerformClick();
                if (txt4_X1.Text == "")
                {
                    txt4_X1.Text = "1";
                }
                if (txt4_X2.Text == "")
                {
                    txt4_X2.Text = "3";
                }
                if (txt4_N.Text == "")
                {
                    txt4_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt4_X1.Text);
                    xi2 = double.Parse(txt4_X2.Text);
                    N = int.Parse(txt4_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                S = ((2 * k) / (3 * a)) * (Math.Pow((a * xi2 + b), 1.5) - Math.Pow((a * xi1 + b), 1.5));
                lbl4_SFIntegral.Text = "S = " + Math.Round(S, 2);
                //lbl4_SFIntegral.Text = Math.Pow(3, 1.5).ToString();

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fSqrt(x, k, a, b);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        //Lof function
        double fLog(double xt, double k, double a, double b, double c)
        {
            double ff = k * Math.Log(xt + b) / Math.Log(a) + c;
            return ff;
        }

        private void btn5_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt5_K.Text == "")
                {
                    txt5_K.Text = "1";
                }
                if (txt5_A.Text == "")
                {
                    txt5_A.Text = "2";
                }
                if (txt5_C.Text == "")
                {
                    txt5_C.Text = "0";
                }
                if (txt5_B.Text == "")
                {
                    txt5_B.Text = "0";
                }
                try
                {
                    k = double.Parse(txt5_K.Text);
                    a = double.Parse(txt5_A.Text);
                    b = double.Parse(txt5_B.Text);
                    c = double.Parse(txt5_C.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                myPen = new Pen(Color.Red, 3);
                //gr = PB.CreateGraphics();
                gr.Clear(Color.White);
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                system_koordinat(x1, x2, y1, y2);

                n = PB.Width;
                h = (x2 - x1) / n;
                x = 0.05 - d;
                while (x < x2)
                {
                    y = fLog(x, k, a, b, c);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(fLog(x, k, a, b, c)), xtoi(x + h), ytoj(fLog(x, k, a, b, c)));
                    }
                    x = x + h;

                }
                myPen.Color = Color.Green;
                myPen.Width = 1;
                myPen.DashStyle = DashStyle.Dash;
                if (d != 0)
                {
                    myPen.Color = Color.Green;
                    gr.DrawLine(myPen, xtoi(-d), ytoj(y1), xtoi(-d), ytoj(y2));
                }
                PB.Image = bitmap;
                lblGivenFun.Text = "y = " + k + "log" + a + " (x + " + b + ") + " + c;
            }
            catch
            {
                return;
            }
        }

        private void btn5_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                lbl5_SFRect.Visible = true;
                btn5_Build.PerformClick();
                if (txt5_X1.Text == "")
                {
                    txt5_X1.Text = "1";
                }
                if (txt5_X2.Text == "")
                {
                    txt5_X2.Text = "3";
                }
                if (txt5_N.Text == "")
                {
                    txt5_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt5_X1.Text);
                    xi2 = double.Parse(txt5_X2.Text);
                    N = int.Parse(txt5_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                H = (xi2 - xi1) / N;
                S = 0;
                for (double i = xi1; i <= xi2 - 2 * H; i += H)
                {
                    y = fLog(i, k, a, b, c);
                    S += H * y;
                }
                lbl5_SFRect.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fLog(x, k, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn5_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                lbl5_SFTrap.Visible = true;
                btn5_Build.PerformClick();
                if (txt5_X1.Text == "")
                {
                    txt5_X1.Text = "1";
                }
                if (txt5_X2.Text == "")
                {
                    txt5_X2.Text = "3";
                }
                if (txt5_N.Text == "")
                {
                    txt5_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt5_X1.Text);
                    xi2 = double.Parse(txt5_X2.Text);
                    N = int.Parse(txt5_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                H = (xi2 - xi1) / N;
                S = H * ((fLog(xi1, k, a, b, c) + fLog(xi2, k, a, b, c)) / 2);
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = fLog(i, k, a, b, c);
                    S += H * y;
                }
                lbl5_SFTrap.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fLog(x, k, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn5_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                lbl5_SFSympson.Visible = true;
                btn5_Build.PerformClick();
                if (txt5_X1.Text == "")
                {
                    txt5_X1.Text = "1";
                }
                if (txt5_X2.Text == "")
                {
                    txt5_X2.Text = "3";
                }
                if (txt5_N.Text == "")
                {
                    txt5_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt5_X1.Text);
                    xi2 = double.Parse(txt5_X2.Text);
                    N = int.Parse(txt5_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                double H1 = (xi2 - xi1) / N;
                H = H1 / 3;
                S = 0;
                double S1 = H * ((fLog(xi1, k, a, b, c) + fLog(xi2, k, a, b, c)) / 2);
                double S2 = 0;
                double S3 = 0;
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = fLog(i, k, a, b, c);
                    S2 += H * y;
                }
                for (double i = (xi1 + H / 2); i <= xi2 - 3 * H / 2; i += H)
                {
                    fLog(i, k, a, b, c);
                    S3 += 2 * H * y;
                }
                S = S1 + S2 + S3;
                S /= 3;
                lbl5_SFSympson.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fLog(x, k, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        //Pow function

        double f(double xt, double a, double m, double n1)
        {
            double ff = a * Math.Pow(xt, m / n1);
            return ff;
        }

        private void btn6_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt6_A.Text == "")
                {
                    txt6_A.Text = "1";
                }
                if (txt6_M.Text == "")
                {
                    txt6_M.Text = "1";
                }
                if (txt6_N.Text == "")
                {
                    txt6_N.Text = "1";
                }
                
                try
                {
                    a = double.Parse(txt6_A.Text);
                    m = double.Parse(txt6_M.Text);
                    n1 = double.Parse(txt6_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (n == 0) 
                {
                    txt6_N.Text = "1";
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Red, 3);
                //gr = PB.CreateGraphics();
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
                    y = f(x, a, m, n1);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(f(x, a, m, n1)), xtoi(x + h), ytoj(f(x + h, a, m, n1)));
                    }
                    x = x + h;

                }
                PB.Image = bitmap;
                lblGivenFun.Text = "Задана функція: y = ";
                if(a==1)
                {
                    lblGivenFun.Text += "x";
                }
                else
                {
                    if (a == -1)
                    {
                        lblGivenFun.Text += "-x";
                    }
                    else
                    {
                        lblGivenFun.Text += a + "x";
                    }
                }
                if (Math.Abs(n1) == 1)
                {
                    if (n1 == 1)
                    {
                        if (m != 1)
                            lblGivenFun.Text += " ^ " + m;
                    }
                    else
                    {
                        if (n1 == -1)
                        {
                            if (m < 0)
                            {
                                lblGivenFun.Text += " ^ " + Math.Abs(m);
                            }
                            else
                            {
                                if (m > 0)
                                {
                                    lblGivenFun.Text += " ^ (-" + Math.Abs(m)+")";
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (m * n1 > 0)
                    {
                        lblGivenFun.Text += "^ (" + Math.Abs(m) + "/" + Math.Abs(n1) + ")";
                    }
                    else
                    {
                        if (m * n1 > 0)
                        {
                            lblGivenFun.Text += "^ (-" + Math.Abs(m) + "; " + Math.Abs(n1) + ")";
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn6_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                lbl6_SFRect.Visible = true;
                btn6_Build.PerformClick();
                if (txt6_X1.Text == "")
                {
                    txt6_X1.Text = "1";
                }
                if (txt6_X2.Text == "")
                {
                    txt6_X2.Text = "3";
                }
                if (txt6_Count.Text == "")
                {
                    txt6_Count.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt6_X1.Text);
                    xi2 = double.Parse(txt6_X2.Text);
                    N = int.Parse(txt6_Count.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                N = int.Parse(txt6_Count.Text);
                H = (xi2 - xi1) / N;
                S = 0;
                for (double i = xi1; i <= xi2 - 2 * H; i += H)
                {
                    y = f(i, a, m, n1);
                    S += H * y;
                }
                lbl6_SFRect.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = f(x, a, m, n1);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn6_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                lbl6_SFTrap.Visible = true;
                btn6_Build.PerformClick();
                if (txt6_X1.Text == "")
                {
                    txt6_X1.Text = "1";
                }
                if (txt6_X2.Text == "")
                {
                    txt6_X2.Text = "3";
                }
                if (txt6_Count.Text == "")
                {
                    txt6_Count.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt6_X1.Text);
                    xi2 = double.Parse(txt6_X2.Text);
                    N = int.Parse(txt6_Count.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                H = (xi2 - xi1) / N;
                S = H * ((f(xi1, a, m, n1) + f(xi2, a, m, n1)) / 2);
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = f(i, a, m, n1);
                    S += H * y;
                }
                lbl6_SFTrap.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = f(x, a, m, n1);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn6_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                lbl6_SFSympson.Visible = true;
                btn6_Build.PerformClick();
                if (txt6_X1.Text == "")
                {
                    txt6_X1.Text = "1";
                }
                if (txt6_X2.Text == "")
                {
                    txt6_X2.Text = "3";
                }
                if (txt6_Count.Text == "")
                {
                    txt6_Count.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt6_X1.Text);
                    xi2 = double.Parse(txt6_X2.Text);
                    N = int.Parse(txt6_Count.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                double H1 = (xi2 - xi1) / N;
                H = H1 / 3;
                S = 0;
                double S1 = H * ((f(xi1, a, m, n1) + f(xi2, a, m, n1)) / 2);
                double S2 = 0;
                double S3 = 0;
                for (double i = xi1 + H; i <= xi2 - H; i += H)
                {
                    y = f(i, a, m, n1);
                    S2 += H * y;
                }
                for (double i = (xi1 + H / 2); i <= xi2 - H / 2; i += H)
                {
                    y = f(i, a, m, n1);
                    S3 += 2 * H * y;
                }
                S = S1 + S2 + S3;
                S = S / 3;
                lbl6_SFSympson.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = f(x, a, m, n1);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn6_FIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                lbl6_SFIntegral.Visible = true;
                btn6_Build.PerformClick();
                if (txt6_X1.Text == "")
                {
                    txt6_X1.Text = "1";
                }
                if (txt6_X2.Text == "")
                {
                    txt6_X2.Text = "3";
                }
                try
                {
                    xi1 = double.Parse(txt6_X1.Text);
                    xi2 = double.Parse(txt6_X2.Text);
                    N = int.Parse(txt6_Count.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                S = (1 / ((m / n1) + 1)) * (Math.Pow(xi2, ((m / n1) + 1)) - Math.Pow(xi1, ((m / n1) + 1)));
                lbl6_SFIntegral.Text = "S = " + Math.Round(S, 2);

                if (txt6_Count.Text == "")
                {
                    txt6_Count.Text = "10";
                }
                N = int.Parse(txt6_Count.Text);
                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = f(x, a, m, n1);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        //Exp function

        double fExp(double xt, double k, double a, double b, double c)
        {
            double ff = k * Math.Pow(a, xt + b) + c;
            return ff;
        }

        private void btn7_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt7_K.Text == "")
                {
                    txt7_K.Text = "1";
                }
                if (txt7_A.Text == "")
                {
                    txt7_A.Text = "2";
                }
                if (txt7_B.Text == "")
                {
                    txt7_B.Text = "0";
                }
                if (txt7_C.Text == "")
                {
                    txt7_C.Text = "0";
                }
                try
                {
                    k = double.Parse(txt7_K.Text);
                    a = double.Parse(txt7_A.Text);
                    b = double.Parse(txt7_B.Text);
                    c = double.Parse(txt7_C.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }

                if (a <= 0 || a == 1)
                {
                    MessageBox.Show("Некоректні дані");
                    txt7_K.Text = "2";
                }

                myPen = new Pen(Color.Red, 3);
                //gr = PB.CreateGraphics();
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
                    y = fExp(x, k, a, b, c);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(fExp(x, k, a, b, c)), xtoi(x + h), ytoj(fExp(x + h, k, a, b, c)));
                    }
                    x = x + h;

                }

                myPen.Color = Color.Green;
                myPen.Width = 1;
                myPen.DashStyle = DashStyle.Dash;
                if (c != 0)
                {
                    gr.DrawLine(myPen, xtoi(x1), ytoj(c), xtoi(x2), ytoj(c));
                }
                PB.Image = bitmap;
                lblGivenFun.Text = "Задана функція: y = ";
                if (k * a > 0)
                {
                    if (k != 1)
                    {
                        lblGivenFun.Text += k + " ∙ ";
                    }
                    lblGivenFun.Text += a;
                }
                else
                {
                    if (k * a < 0)
                    {
                        if (k != 1)
                        {
                            lblGivenFun.Text += " - " + Math.Abs(k) + " ∙ ";
                        }
                        lblGivenFun.Text += Math.Abs(a);
                    }
                }
                lblGivenFun.Text += " ^ (x ";
                if (b>0)
                {
                    lblGivenFun.Text += "+ " + b;
                }
                else
                {
                    if (b < 0)
                    {
                        lblGivenFun.Text += "- " + Math.Abs(b);
                    }
                }
                lblGivenFun.Text += ") ";
                if (c > 0)
                {
                    lblGivenFun.Text += "+ " + c;
                }
                else
                {
                    if (c < 0)
                    {
                        lblGivenFun.Text += "- " + Math.Abs(c);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn7_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                lbl7_SFRect.Visible = true;
                btn7_Build.PerformClick();
                if (txt7_X1.Text == "")
                {
                    txt7_X1.Text = "1";
                }
                if (txt7_X2.Text == "")
                {
                    txt7_X2.Text = "3";
                }
                if (txt7_N.Text == "")
                {
                    txt7_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt7_X1.Text);
                    xi2 = double.Parse(txt7_X2.Text);
                    N = int.Parse(txt7_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                N = int.Parse(txt7_N.Text);
                H = (xi2 - xi1) / N;
                S = 0;
                for (double i = xi1; i <= xi2 - 2 * H; i += H)
                {
                    y = fExp(i, k, a, b, c);
                    S += H * y;
                }
                lbl7_SFRect.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fExp(x, k, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn7_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                lbl7_SFTrap.Visible = true;
                btn7_Build.PerformClick();
                if (txt7_X1.Text == "")
                {
                    txt7_X1.Text = "1";
                }
                if (txt7_X2.Text == "")
                {
                    txt7_X2.Text = "3";
                }
                if (txt7_N.Text == "")
                {
                    txt7_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt7_X1.Text);
                    xi2 = double.Parse(txt7_X2.Text);
                    N = int.Parse(txt7_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                N = int.Parse(txt7_N.Text);
                H = (xi2 - xi1) / N;
                S = H * ((fExp(xi1, k, a, b, c) + fExp(xi2, k, a, b, c)) / 2);
                for (double i = xi1 + H; i <= xi2 - 2 * H; i += H)
                {
                    y = fExp(i, k, a, b, c);
                    S += H * y;
                }
                lbl7_SFTrap.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fExp(x, k, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn7_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                lbl7_SFSympson.Visible = true;
                btn7_Build.PerformClick();
                if (txt7_X1.Text == "")
                {
                    txt7_X1.Text = "1";
                }
                if (txt7_X2.Text == "")
                {
                    txt7_X2.Text = "3";
                }
                if (txt7_N.Text == "")
                {
                    txt7_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt7_X1.Text);
                    xi2 = double.Parse(txt7_X2.Text);
                    N = int.Parse(txt7_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));

                N = int.Parse(txt7_N.Text);
                double H1 = (xi2 - xi1) / N;
                H = H1 / 3;
                S = 0;
                double S1 = H * ((fExp(xi1, k, a, b, c) + fExp(xi2, k, a, b, c)) / 2);
                double S2 = 0;
                double S3 = 0;
                for (double i = xi1 + H; i <= xi2 - H; i += H)
                {
                    y = fExp(i, k, a, b, c);
                    S2 += H * y;
                }
                for (double i = (xi1 + H / 2); i <= xi2 - H / 2; i += H)
                {
                    y = fExp(i, k, a, b, c);
                    S3 += 2 * H * y;
                }
                S = S1 + S2 + S3;
                S = S / 3;
                lbl7_SFSympson.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fExp(x, k, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        private void btn7_FIntegrtal_Click(object sender, EventArgs e)
        {
            try
            {
                lbl7_SFIntegral.Visible = true;
                btn7_Build.PerformClick();
                if (txt7_X1.Text == "")
                {
                    txt7_X1.Text = "1";
                }
                if (txt7_X2.Text == "")
                {
                    txt7_X2.Text = "3";
                }
                if (txt7_N.Text == "")
                {
                    txt7_N.Text = "10";
                }
                try
                {
                    xi1 = double.Parse(txt7_X1.Text);
                    xi2 = double.Parse(txt7_X2.Text);
                    N = int.Parse(txt7_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (xi1 > xi2)
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(xi1), ytoj(y1), xtoi(xi1), ytoj(y2));
                gr.DrawLine(myPen, xtoi(xi2), ytoj(y1), xtoi(xi2), ytoj(y2));
                N = int.Parse(txt7_N.Text);
                S = (k / Math.Log(a)) * (Math.Pow(a, xi2 + b) - Math.Pow(a, xi1 + b)) + c * (xi2 - xi1);
                lbl7_SFIntegral.Text = "S = " + Math.Round(S, 2);

                H = (xi2 - xi1) / N;
                x = xi1;
                while (x <= xi2)
                {
                    y = fExp(x, k, a, b, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                PB.Image = bitmap;
            }
            catch
            {
                return;
            }
        }

        //Sin fun

        double fSin(double xt, double a, double b1, double b2, double c)
        {
            double ff = a * Math.Sin(xt + (b1 * Math.PI / b2)) + c;
            return ff;
        }

        double fk(double k1, double k2)
        {
            return k1 * Math.PI / k2;
        }

        private void btn8_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt8_A.Text == "")
                {
                    txt8_A.Text = "1";
                }
                if (txt8_B1.Text == "")
                {
                    txt8_B1.Text = "0";
                }
                if (txt8_B2.Text == "")
                {
                    txt8_B2.Text = "1";
                }
                if (txt8_C.Text == "")
                {
                    txt8_C.Text = "0";
                }
                try
                {
                    a = double.Parse(txt8_A.Text);
                    b1 = double.Parse(txt8_B1.Text);
                    b2 = double.Parse(txt8_B2.Text);
                    c = double.Parse(txt8_C.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (b2 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Red, 3);
                gr.Clear(Color.White);
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                trigonometric_system_koordinat(x1, x2, y1, y2);

                n = PB.Width;
                h = (x2 - x1) / n;
                x = x1;
                while (x < x2)
                {
                    y = fSin(x, a, b1, b2, c);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(fSin(x, a, b1, b2, c)), xtoi(x + h), ytoj(fSin(x, a, b1, b2, c)));
                    }
                    x = x + h;
                }
                //if (b1 == 0)
                //    lblGivenFun.Text = "Задана функція: y = " + a + " sin(x) + " + c;
                //else
                //    lblGivenFun.Text = "Задана функція: y = " + a + " sin(x + " + b1 + "π/" + b2 + ") + " + c;
                PB.Image = bitmap;
                lblGivenFun.Text = "Задана функція: y = ";
                if(a!=1)
                {
                    if (a == -1)
                    {
                        lblGivenFun.Text += " - ";
                    }
                    else
                    {
                        lblGivenFun.Text += a + " ";
                    }
                }
                lblGivenFun.Text +="sin (x";
                if (b1 * b2 > 0)
                {
                    if(b2==1)
                    {
                        if (b1 != 1)
                        {
                            lblGivenFun.Text += " + " + Math.Abs(b1) + "π";
                        }
                        else
                        {
                            if (b1 == 1)
                            {
                                lblGivenFun.Text += " + π";
                            }
                        }
                    }
                    else
                    {
                        if (Math.Abs(b1) == 1)
                        {
                            lblGivenFun.Text += " + π / " + Math.Abs(b2);
                        }
                        else
                        {
                            lblGivenFun.Text += " + " + Math.Abs(b1) + "π / " + Math.Abs(b2);
                        }
                    }
                }
                else
                {
                    if (b1 * b2 < 0)
                    {
                        if (b2 == 1)
                        {
                            if (b1 != 1)
                            {
                                lblGivenFun.Text += " - " + Math.Abs(b1) + "π";
                            }
                            else
                            {
                                if (Math.Abs(b1) == 1)
                                {
                                    lblGivenFun.Text += " - π";
                                }
                            }
                        }
                        else
                        {
                            if (Math.Abs(b1) == 1)
                            {
                                lblGivenFun.Text += " - π / " + Math.Abs(b2);
                            }
                            else
                            {
                                lblGivenFun.Text += " - " + Math.Abs(b1) + "π / " + Math.Abs(b2);
                            }
                        }
                    }
                }
                lblGivenFun.Text += ")";
                if (c > 0)
                {
                    lblGivenFun.Text += " + "+c;
                }
                else
                {
                    if (c < 0)
                    {
                        lblGivenFun.Text += " - " + Math.Abs(c);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void frmOneGraphics_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pctExit, "До програмної частини");
            toolTip1.SetToolTip(pctHelp, "Довідник користувача");
            toolTip1.SetToolTip(pctClose, "Вихід");
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            frmProgramMenu programMenu = new frmProgramMenu();
            programMenu.Show();
            this.Hide();
        }

        private void lblLinFun_MouseEnter(object sender, EventArgs e)
        {
            lblLinFun.Text = "y = kx + b";
        }

        private void lblLinFun_MouseLeave(object sender, EventArgs e)
        {
            lblLinFun.Text = "y=kx+b";
        }

        private void lblQuadraticFun_MouseEnter(object sender, EventArgs e)
        {
            lblQuadraticFun.Text = "y = ax² + bx + c";
        }

        private void lblQuadraticFun_MouseLeave(object sender, EventArgs e)
        {
            lblQuadraticFun.Text = "y=ax²+bx+c";
        }

        private void lblReverseFun_MouseEnter(object sender, EventArgs e)
        {
            lblReverseFun.Text = "y = k / x";
        }

        private void lblReverseFun_MouseLeave(object sender, EventArgs e)
        {
            lblReverseFun.Text = "y=k/x";
        }

        private void lblSqrtFun_MouseEnter(object sender, EventArgs e)
        {
            lblSqrtFun.Text = "y = √x";
        }

        private void lblSqrtFun_MouseLeave(object sender, EventArgs e)
        {
            lblSqrtFun.Text = "y=√x";
        }

        private void lblPowFun_MouseEnter(object sender, EventArgs e)
        {
            lblPowFun.Text = "y = xⁿ";
        }

        private void lblPowFun_MouseLeave(object sender, EventArgs e)
        {
            lblPowFun.Text = "y=xⁿ";
        }

        private void lblExpFun_MouseEnter(object sender, EventArgs e)
        {
            lblExpFun.Text = "y = a";
            lblExpFunX.Location = new Point(70, 371);
        }

        private void lblExpFun_MouseLeave(object sender, EventArgs e)
        {
            lblExpFun.Text = "y=a";
            lblExpFunX.Location=new Point(57, 371);
        }

        private void lblSinFun_MouseEnter(object sender, EventArgs e)
        {
            lblSinFun.Text = "y = sin  x";
        }

        private void lblSinFun_MouseLeave(object sender, EventArgs e)
        {
            lblSinFun.Text = "y=sin x";
        }

        private void lblCosFun_MouseEnter(object sender, EventArgs e)
        {
            lblCosFun.Text = "y = cos  x";
        }

        private void lblCosFun_MouseLeave(object sender, EventArgs e)
        {
            lblCosFun.Text = "y=cos x";
        }

        private void lblTgFun_MouseEnter(object sender, EventArgs e)
        {
            lblTgFun.Text = "y = tg  x";
        }

        private void lblTgFun_MouseLeave(object sender, EventArgs e)
        {
            lblTgFun.Text = "y=tg x";
        }

        private void lblCtgFun_MouseEnter(object sender, EventArgs e)
        {
            lblCtgFun.Text = "y =  ctg  x";
        }

        private void lblCtgFun_MouseLeave(object sender, EventArgs e)
        {
            lblCtgFun.Text = "y=ctg x";
        }

        private void pctHelp_Click(object sender, EventArgs e)
        {
            frmUserGuide userGuide = new frmUserGuide();
            userGuide.ShowDialog();
        }

        private void btn8_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                btn8_Build.PerformClick();
                if (txt8_X11.Text == "")
                {
                    txt8_X11.Text = "1";
                }
                if (txt8_X12.Text == "")
                {
                    txt8_X12.Text = "6";
                }
                if (txt8_X21.Text == "")
                {
                    txt8_X21.Text = "2";
                }
                if (txt8_X22.Text == "")
                {
                    txt8_X22.Text = "3";
                }
                if (txt8_N.Text == "")
                {
                    txt8_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt8_X11.Text);
                    xi12 = float.Parse(txt8_X12.Text);
                    xi21 = float.Parse(txt8_X21.Text);
                    xi22 = float.Parse(txt8_X22.Text);
                    N = int.Parse(txt8_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22)) 
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));


                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                S = 0;
                for (double i = fk(xi11, xi12); i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fSin(i, a, b1, b2, c));
                    S += H * y;
                }
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fSin(x, a, b1, b2, c);
                    try
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректі межі інтегрування");
                        return;
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fSin(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl8_SFRect.Visible = true;
                lbl8_SFRect.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn8_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                btn8_Build.PerformClick();
                if (txt8_X11.Text == "")
                {
                    txt8_X11.Text = "1";
                }
                if (txt8_X12.Text == "")
                {
                    txt8_X12.Text = "6";
                }
                if (txt8_X21.Text == "")
                {
                    txt8_X21.Text = "2";
                }
                if (txt8_X22.Text == "")
                {
                    txt8_X22.Text = "3";
                }
                if (txt8_N.Text == "")
                {
                    txt8_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt8_X11.Text);
                    xi12 = float.Parse(txt8_X12.Text);
                    xi21 = float.Parse(txt8_X21.Text);
                    xi22 = float.Parse(txt8_X22.Text);
                    N = int.Parse(txt8_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                S = H * (Math.Abs((fSin(fk(xi11, xi12), a, b1, b2, c)) + Math.Abs(fSin(fk(xi11, xi12), a, b1, b2, c))) / 2);
                for (double i = fk(xi11, xi12) + H; i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fSin(i, a, b1, b2, c));
                    S += H * y;
                }
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fSin(x, a, b1, b2, c);
                    try
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректі межі інтегрування");
                        return;
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fSin(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl8_SFTrap.Visible = true;
                lbl8_SFTrap.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn8_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                btn8_Build.PerformClick();
                if (txt8_X11.Text == "")
                {
                    txt8_X11.Text = "1";
                }
                if (txt8_X12.Text == "")
                {
                    txt8_X12.Text = "6";
                }
                if (txt8_X21.Text == "")
                {
                    txt8_X21.Text = "2";
                }
                if (txt8_X22.Text == "")
                {
                    txt8_X22.Text = "3";
                }
                if (txt8_N.Text == "")
                {
                    txt8_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt8_X11.Text);
                    xi12 = float.Parse(txt8_X12.Text);
                    xi21 = float.Parse(txt8_X21.Text);
                    xi22 = float.Parse(txt8_X22.Text);
                    N = int.Parse(txt8_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                H = H / 3;
                S = H * (Math.Abs((fSin(fk(xi11, xi12), a, b1, b2, c)) + Math.Abs(fSin(fk(xi11, xi12), a, b1, b2, c))) / 2);
                for (double i = fk(xi11, xi12) + H; i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fSin(i, a, b1, b2, c));
                    S += H * y;
                }
                for (double i = (fk(xi11, xi12) + H / 2); i <= fk(xi21, xi22) - 3 * H / 2; i += H)
                {
                    y = Math.Abs(fSin(i, a, b1, b2, c));
                    S += 2 * H * y;
                }
                S /= 3;
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fSin(x, a, b1, b2, c);
                    try
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректі межі інтегрування");
                        return;
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fSin(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl8_SFSympson.Visible = true;
                lbl8_SFSympson.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn8_FIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                btn8_Build.PerformClick();
                if (txt8_X11.Text == "")
                {
                    txt8_X11.Text = "1";
                }
                if (txt8_X12.Text == "")
                {
                    txt8_X12.Text = "6";
                }
                if (txt8_X21.Text == "")
                {
                    txt8_X21.Text = "2";
                }
                if (txt8_X22.Text == "")
                {
                    txt8_X22.Text = "3";
                }
                if (txt8_N.Text == "")
                {
                    txt8_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt8_X11.Text);
                    xi12 = float.Parse(txt8_X12.Text);
                    xi21 = float.Parse(txt8_X21.Text);
                    xi22 = float.Parse(txt8_X22.Text);
                    N = int.Parse(txt8_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                S = -a * (Math.Cos(fk(xi21, xi22) + fk(b1, b2)) - Math.Cos(fk(xi11, xi12) + fk(b1, b2))) + c * (fk(xi21, xi22 - fk(xi11, xi12)));
                lbl8_SFIntegral.Visible = true;
                lbl8_SFIntegral.Text = "S = " + Math.Round(S, 2);

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x <= fk(xi21, xi22) - H)
                {
                    y = fSin(x, a, b1, b2, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
            }
            catch
            {
                return;
            }
        }

        //Cos fun

        double fCos(double xt, double a, double b1, double b2, double c)
        {
            double ff = a * Math.Cos(xt + (b1 * Math.PI / b2)) + c;
            return ff;
        }

        private void btn9_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt9_A.Text == "")
                {
                    txt9_A.Text = "1";
                }
                if (txt9_B1.Text == "")
                {
                    txt9_B1.Text = "0";
                }
                if (txt9_B2.Text == "")
                {
                    txt9_B2.Text = "1";
                }
                if (txt9_C.Text == "")
                {
                    txt9_C.Text = "0";
                }
                try
                {
                    a = double.Parse(txt9_A.Text);
                    b1 = double.Parse(txt9_B1.Text);
                    b2 = double.Parse(txt9_B2.Text);
                    c = double.Parse(txt9_C.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (b2 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Red, 3);
                gr.Clear(Color.White);
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                trigonometric_system_koordinat(x1, x2, y1, y2);

                n = PB.Width;
                h = (x2 - x1) / n;
                x = x1;
                while (x < x2)
                {
                    y = fCos(x, a, b1, b2, c);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(fCos(x, a, b1, b2, c)), xtoi(x + h), ytoj(fCos(x, a, b1, b2, c)));
                    }
                    x = x + h;
                }
                PB.Image = bitmap;
                lblGivenFun.Text = "Задана функція: y = ";
                if (a != 1)
                {
                    if (a == -1)
                    {
                        lblGivenFun.Text += " - ";
                    }
                    else
                    {
                        lblGivenFun.Text += a + " ";
                    }
                }
                lblGivenFun.Text += "cos (x";
                if (b1 * b2 > 0)
                {
                    if (b2 == 1)
                    {
                        if (b1 != 1)
                        {
                            lblGivenFun.Text += " + " + Math.Abs(b1) + "π";
                        }
                        else
                        {
                            if (b1 == 1)
                            {
                                lblGivenFun.Text += " + π";
                            }
                        }
                    }
                    else
                    {
                        if (Math.Abs(b1) == 1)
                        {
                            lblGivenFun.Text += " + π / " + Math.Abs(b2);
                        }
                        else
                        {
                            lblGivenFun.Text += " + " + Math.Abs(b1) + "π / " + Math.Abs(b2);
                        }
                    }
                }
                else
                {
                    if (b1 * b2 < 0)
                    {
                        if (b2 == 1)
                        {
                            if (b1 != 1)
                            {
                                lblGivenFun.Text += " - " + Math.Abs(b1) + "π";
                            }
                            else
                            {
                                if (Math.Abs(b1) == 1)
                                {
                                    lblGivenFun.Text += " - π";
                                }
                            }
                        }
                        else
                        {
                            if (Math.Abs(b1) == 1)
                            {
                                lblGivenFun.Text += " - π / " + Math.Abs(b2);
                            }
                            else
                            {
                                lblGivenFun.Text += " - " + Math.Abs(b1) + "π / " + Math.Abs(b2);
                            }
                        }
                    }
                }
                lblGivenFun.Text += ")";
                if (c > 0)
                {
                    lblGivenFun.Text += " + " + c;
                }
                else
                {
                    if (c < 0)
                    {
                        lblGivenFun.Text += " - " + Math.Abs(c);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn9_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                btn9_Build.PerformClick();
                if (txt9_X11.Text == "")
                {
                    txt9_X11.Text = "1";
                }
                if (txt9_X12.Text == "")
                {
                    txt9_X12.Text = "6";
                }
                if (txt9_X21.Text == "")
                {
                    txt9_X21.Text = "2";
                }
                if (txt9_X22.Text == "")
                {
                    txt9_X22.Text = "3";
                }
                if (txt9_N.Text == "")
                {
                    txt9_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt9_X11.Text);
                    xi12 = float.Parse(txt9_X12.Text);
                    xi21 = float.Parse(txt9_X21.Text);
                    xi22 = float.Parse(txt9_X22.Text);
                    N = int.Parse(txt9_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                S = 0;
                for (double i = fk(xi11, xi12); i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fCos(i, a, b1, b2, c));
                    S += H * y;
                }
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fCos(x, a, b1, b2, c);
                    try
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректі межі інтегрування");
                        return;
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fCos(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl9_SFRect.Visible = true;
                lbl9_SFRect.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn9_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                btn9_Build.PerformClick();
                if (txt9_X11.Text == "")
                {
                    txt9_X11.Text = "1";
                }
                if (txt9_X12.Text == "")
                {
                    txt9_X12.Text = "6";
                }
                if (txt9_X21.Text == "")
                {
                    txt9_X21.Text = "2";
                }
                if (txt9_X22.Text == "")
                {
                    txt9_X22.Text = "3";
                }
                if (txt9_N.Text == "")
                {
                    txt9_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt9_X11.Text);
                    xi12 = float.Parse(txt9_X12.Text);
                    xi21 = float.Parse(txt9_X21.Text);
                    xi22 = float.Parse(txt9_X22.Text);
                    N = int.Parse(txt9_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                S = H * ((Math.Abs(fCos(fk(xi11, xi12), a, b1, b2, c)) + Math.Abs(fCos(fk(xi11, xi12), a, b1, b2, c))) / 2);
                for (double i = fk(xi11, xi12) + H; i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fCos(i, a, b1, b2, c));
                    S += H * y;
                }
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fCos(x, a, b1, b2, c);
                    try
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректі межі інтегрування");
                        return;
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fCos(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl9_SFTrap.Visible = true;
                lbl9_SFTrap.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn9_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                btn9_Build.PerformClick();
                if (txt9_X11.Text == "")
                {
                    txt9_X11.Text = "1";
                }
                if (txt9_X12.Text == "")
                {
                    txt9_X12.Text = "6";
                }
                if (txt9_X21.Text == "")
                {
                    txt9_X21.Text = "2";
                }
                if (txt9_X22.Text == "")
                {
                    txt9_X22.Text = "3";
                }
                if (txt9_N.Text == "")
                {
                    txt9_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt9_X11.Text);
                    xi12 = float.Parse(txt9_X12.Text);
                    xi21 = float.Parse(txt9_X21.Text);
                    xi22 = float.Parse(txt9_X22.Text);
                    N = int.Parse(txt9_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                H = H / 3;
                S = H * ((Math.Abs(fCos(fk(xi11, xi12), a, b1, b2, c)) + Math.Abs(fCos(fk(xi11, xi12), a, b1, b2, c))) / 2);
                for (double i = fk(xi11, xi12) + H; i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fCos(i, a, b1, b2, c));
                    S += H * y;
                }
                for (double i = (fk(xi11, xi12) + H / 2); i <= fk(xi21, xi22) - 3 * H / 2; i += H)
                {
                    y = Math.Abs(fCos(i, a, b1, b2, c));
                    S += 2 * H * y;
                }
                S /= 3;
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x <= fk(xi21, xi22))
                {
                    y = fCos(x, a, b1, b2, c);
                    try
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректі межі інтегрування");
                        return;
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fCos(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl9_SFSympson.Visible = true;
                lbl9_SFSympson.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn9_FIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                btn9_Build.PerformClick();
                if (txt9_X11.Text == "")
                {
                    txt9_X11.Text = "1";
                }
                if (txt9_X12.Text == "")
                {
                    txt9_X12.Text = "6";
                }
                if (txt9_X21.Text == "")
                {
                    txt9_X21.Text = "2";
                }
                if (txt9_X22.Text == "")
                {
                    txt9_X22.Text = "3";
                }
                if (txt9_N.Text == "")
                {
                    txt9_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt9_X11.Text);
                    xi12 = float.Parse(txt9_X12.Text);
                    xi21 = float.Parse(txt9_X21.Text);
                    xi22 = float.Parse(txt9_X22.Text);
                    N = int.Parse(txt9_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                S = a * (Math.Sin(fk(xi21, xi22) + fk(b1, b2)) - Math.Sin(fk(xi11, xi12) + fk(b1, b2))) + c * (fk(xi21, xi22) - fk(xi11, xi12));
                lbl9_SFIntegral.Visible = true;
                lbl9_SFIntegral.Text = "S = " + Math.Round(S, 2);

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x <= fk(xi21, xi22))
                {
                    y = fCos(x, a, b1, b2, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
            }
            catch
            {
                return;
            }
        }

        // Tg fun

        double fTg(double xt, double a, double b1, double b2, double c)
        {
            return a * Math.Tan(xt + (b1 * Math.PI / b2)) + c;
        }

        private void btn10_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt10_A.Text == "")
                {
                    txt10_A.Text = "1";
                }
                if (txt10_B1.Text == "")
                {
                    txt10_B1.Text = "0";
                }
                if (txt10_B2.Text == "")
                {
                    txt10_B2.Text = "1";
                }
                if (txt10_C.Text == "")
                {
                    txt10_C.Text = "0";
                }
                try
                {
                    a = double.Parse(txt10_A.Text);
                    b1 = double.Parse(txt10_B1.Text);
                    b2 = double.Parse(txt10_B2.Text);
                    c = double.Parse(txt10_C.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (b2 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Red, 4);
                gr.Clear(Color.White);
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                trigonometric_system_koordinat(x1, x2, y1, y2);
                int r = 0;
                n = PB.Width;
                h = (x2 - x1) / n;
                x = x1;
                while (x < x2)
                {
                    y = fTg(x, a, b1, b2, c);
                    if (y < y2)
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(fTg(x, a, b1, b2, c)), xtoi(x + h), ytoj(fTg(x + h, a, b1, b2, c)));
                    }
                    x = x + h;

                    if (x >= 1.5)
                    {
                        r = 1;
                        if ((int)x == (double)x)
                        {
                            r++;
                            label7.Text = r.ToString();
                        }
                    }
                }
                
                for (double i = Math.PI / 2; i < x2+Math.PI; i += Math.PI)
                {
                    myPen = new Pen(Color.White, 5);
                    gr.DrawLine(myPen, xtoi(i - fk(b1, b2)), ytoj(y1), xtoi(i - fk(b1, b2)), ytoj(y2));
                    myPen = new Pen(Color.Purple, 2);
                    myPen.DashStyle = DashStyle.Dash;
                    gr.DrawLine(myPen, xtoi(i - fk(b1, b2)), ytoj(y1), xtoi(i - fk(b1, b2)), ytoj(y2));
                }
                for (double i = -Math.PI / 2; i > x1-5*Math.PI; i -= Math.PI)
                {
                    myPen = new Pen(Color.White, 5);
                    gr.DrawLine(myPen, xtoi(i - fk(b1, b2)), ytoj(y1), xtoi(i - fk(b1, b2)), ytoj(y2));
                    myPen = new Pen(Color.Purple, 2);
                    myPen.DashStyle = DashStyle.Dash;
                    gr.DrawLine(myPen, xtoi(i - fk(b1, b2)), ytoj(y1), xtoi(i - fk(b1, b2)), ytoj(y2));
                }
                if (c != 0)
                {
                    myPen.Color = Color.Blue;
                    gr.DrawLine(myPen, xtoi(x1), ytoj(c), xtoi(x2), ytoj(c));
                }
               
                PB.Image = bitmap;
                lblGivenFun.Text = "Задана функція: y = ";
                if (a != 1)
                {
                    if (a == -1)
                    {
                        lblGivenFun.Text += " - ";
                    }
                    else
                    {
                        lblGivenFun.Text += a + " ";
                    }
                }
                lblGivenFun.Text += "tg (x";
                if (b1 * b2 > 0)
                {
                    if (b2 == 1)
                    {
                        if (b1 != 1)
                        {
                            lblGivenFun.Text += " + " + Math.Abs(b1) + "π";
                        }
                        else
                        {
                            if (b1 == 1)
                            {
                                lblGivenFun.Text += " + π";
                            }
                        }
                    }
                    else
                    {
                        if (Math.Abs(b1) == 1)
                        {
                            lblGivenFun.Text += " + π / " + Math.Abs(b2);
                        }
                        else
                        {
                            lblGivenFun.Text += " + " + Math.Abs(b1) + "π / " + Math.Abs(b2);
                        }
                    }
                }
                else
                {
                    if (b1 * b2 < 0)
                    {
                        if (b2 == 1)
                        {
                            if (b1 != 1)
                            {
                                lblGivenFun.Text += " - " + Math.Abs(b1) + "π";
                            }
                            else
                            {
                                if (Math.Abs(b1) == 1)
                                {
                                    lblGivenFun.Text += " - π";
                                }
                            }
                        }
                        else
                        {
                            if (Math.Abs(b1) == 1)
                            {
                                lblGivenFun.Text += " - π / " + Math.Abs(b2);
                            }
                            else
                            {
                                lblGivenFun.Text += " - " + Math.Abs(b1) + "π / " + Math.Abs(b2);
                            }
                        }
                    }
                }
                lblGivenFun.Text += ")";
                if (c > 0)
                {
                    lblGivenFun.Text += " + " + c;
                }
                else
                {
                    if (c < 0)
                    {
                        lblGivenFun.Text += " - " + Math.Abs(c);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn10_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                btn10_Build.PerformClick();
                if (txt10_X11.Text == "")
                {
                    txt10_X11.Text = "1";
                }
                if (txt10_X12.Text == "")
                {
                    txt10_X12.Text = "6";
                }
                if (txt10_X21.Text == "")
                {
                    txt10_X21.Text = "1";
                }
                if (txt10_X22.Text == "")
                {
                    txt10_X22.Text = "3";
                }
                if (txt10_N.Text == "")
                {
                    txt10_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt10_X11.Text);
                    xi12 = float.Parse(txt10_X12.Text);
                    xi21 = float.Parse(txt10_X21.Text);
                    xi22 = float.Parse(txt10_X22.Text);
                    N = int.Parse(txt10_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                //if (Math.Abs(fk(xi11, xi12)) - fk(xi21, xi22)<Math.PI)
                //{
                //    MessageBox.Show("Введено некоректі межі інтегрування");
                //    return;
                //}


                //double[] aa;
                //aa = new double[18];
                //for (int i = 0; i < 18; i++)
                //{

                //    aa[i] = Math.PI / 2 + Math.PI * (-9 + i) - fk(b1, b2);
                //    listBox2.Items.Add(i+" = " + aa[i]);
                //}
                ////-------------------------------------

                //listBox2.Items.Add(xi11 + " p/" + xi12);


                //for (int i = 0; i < 18; i++)
                //{
                //    listBox2.Items.Add("0");
                //    if (fk(xi11, xi12) > aa[i] && fk(xi11, xi12) < aa[i + 1])
                //    {
                //        listBox2.Items.Add("a");
                //        if (fk(xi21, xi22) > aa[i] && fk(xi21, xi22) < aa[i + 1])
                //        {
                //            listBox2.Items.Add("b");
                //            MessageBox.Show("Введено некоректі межі інтегрування");
                //            return;
                //        }
                //    }
                //}
                //listBox2.Items.Add("------------");
                //if (fk(xi1, xi2) < Math.PI / 2 - fk(b1, b2))
                //{
                //    MessageBox.Show("Введено некоректі межі інтегрування");
                //    return;
                //}

                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }

                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                S = 0;
                for (double i = fk(xi11, xi12); i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fTg(i, a, b1, b2, c));
                    S += H * y;
                }
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fTg(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fTg(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl10_SFRect.Visible = true;
                lbl10_SFRect.Text = "S = " + Math.Abs(Math.Round(S, 2));
            }
            catch
            {
                return;
            }
        }

        private void btn10_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                btn10_Build.PerformClick();
                if (txt10_X11.Text == "")
                {
                    txt10_X11.Text = "1";
                }
                if (txt10_X12.Text == "")
                {
                    txt10_X12.Text = "6";
                }
                if (txt10_X21.Text == "")
                {
                    txt10_X21.Text = "1";
                }
                if (txt10_X22.Text == "")
                {
                    txt10_X22.Text = "3";
                }
                if (txt10_N.Text == "")
                {
                    txt10_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt10_X11.Text);
                    xi12 = float.Parse(txt10_X12.Text);
                    xi21 = float.Parse(txt10_X21.Text);
                    xi22 = float.Parse(txt10_X22.Text);
                    N = int.Parse(txt10_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                N = int.Parse(txt10_N.Text);
                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                S = H * ((Math.Abs(fTg(fk(xi11, xi12), a, b1, b2, c)) + Math.Abs(fTg(fk(xi21, xi22), a, b1, b2, c))) / 2);
                for (double i = fk(xi11, xi12) + H; i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fTg(i, a, b1, b2, c));
                    S += H * y;
                }
                
                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x <= fk(xi21, xi22))
                {
                    y = fTg(x, a, b1, b2, c);
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fTg(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl10_SFTrap.Visible = true;
                lbl10_SFTrap.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn10_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                btn10_Build.PerformClick();
                if (txt10_X11.Text == "")
                {
                    txt10_X11.Text = "1";
                }
                if (txt10_X12.Text == "")
                {
                    txt10_X12.Text = "6";
                }
                if (txt10_X21.Text == "")
                {
                    txt10_X21.Text = "1";
                }
                if (txt10_X22.Text == "")
                {
                    txt10_X22.Text = "3";
                }
                if (txt10_N.Text == "")
                {
                    txt10_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt10_X11.Text);
                    xi12 = float.Parse(txt10_X12.Text);
                    xi21 = float.Parse(txt10_X21.Text);
                    xi22 = float.Parse(txt10_X22.Text);
                    N = int.Parse(txt10_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                H /= 3;
                S = H * ((Math.Abs(fTg(fk(xi11, xi12), a, b1, b2, c)) + Math.Abs(fTg(fk(xi21, xi22), a, b1, b2, c))) / 2);
                for (double i = fk(xi11, xi12) + H; i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fTg(i, a, b1, b2, c));
                    S += H * y;
                }
                for (double i = (fk(xi11, xi12) + H / 2); i <= fk(xi21, xi22) - 3 * H / 2; i += H)
                {
                    y = Math.Abs(fTg(i, a, b1, b2, c));
                    S += 2 * H * y;
                }
                S /= 3;
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x <= fk(xi21, xi22))
                {
                    y = fTg(x, a, b1, b2, c);
                    try
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректі межі інтегрування");
                        return;
                    }
                    x = (x + H);
                    
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fTg(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl10_SFSympson.Visible = true;
                lbl10_SFSympson.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn10_FIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                btn10_Build.PerformClick();
                if (txt10_X11.Text == "")
                {
                    txt10_X11.Text = "1";
                }
                if (txt10_X12.Text == "")
                {
                    txt10_X12.Text = "6";
                }
                if (txt10_X21.Text == "")
                {
                    txt10_X21.Text = "1";
                }
                if (txt10_X22.Text == "")
                {
                    txt10_X22.Text = "3";
                }
                if (txt10_N.Text == "")
                {
                    txt10_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt10_X11.Text);
                    xi12 = float.Parse(txt10_X12.Text);
                    xi21 = float.Parse(txt10_X21.Text);
                    xi22 = float.Parse(txt10_X22.Text);
                    N = 1000000;
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));
                if (fk(xi11, xi12) > fk(b1, b2))
                {
                    S = -a * Math.Log((Math.Abs(Math.Cos(fk(xi21, xi22) + fk(b1, b2)))) / (Math.Abs(Math.Cos(fk(xi11, xi12) + fk(b1, b2))))) + c * Math.Abs((fk(xi21, xi22) - fk(xi11, xi12)));
                }
                else
                {
                    H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                    H /= 3;
                    S = H * ((Math.Abs(fTg(fk(xi11, xi12), a, b1, b2, c)) + Math.Abs(fTg(fk(xi21, xi22), a, b1, b2, c))) / 2);
                    for (double i = fk(xi11, xi12) + H; i <= fk(xi21, xi22) - 2 * H; i += H)
                    {
                        y = Math.Abs(fTg(i, a, b1, b2, c));
                        S += H * y;
                    }
                    for (double i = (fk(xi11, xi12) + H / 2); i <= fk(xi21, xi22) - 3 * H / 2; i += H)
                    {
                        y = Math.Abs(fTg(i, a, b1, b2, c));
                        S += 2 * H * y;
                    }
                    S /= 3;
                }
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fTg(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fTg(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl10_SFIntegral.Visible = true;
                lbl10_SFIntegral.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        //Ctg fun

        double fCtg(double xt, double a, double b1, double b2, double c)
        {
            return a * (1 / Math.Tan(xt + (b1 * Math.PI / b2))) + c;
        }

        private void btn11_Build_Click(object sender, EventArgs e)
        {
            try
            {
                PB.Visible = true;
                lblGivenFun.Visible = true;
                bitmap = new Bitmap(PB.Width, PB.Height);
                gr = Graphics.FromImage(bitmap);
                if (txt11_A.Text == "")
                {
                    txt11_A.Text = "1";
                }
                if (txt11_B1.Text == "")
                {
                    txt11_B1.Text = "0";
                }
                if (txt11_B2.Text == "")
                {
                    txt11_B2.Text = "1";
                }
                if (txt11_C.Text == "")
                {
                    txt11_C.Text = "0";
                }
                try
                {
                    a = double.Parse(txt11_A.Text);
                    b1 = double.Parse(txt11_B1.Text);
                    b2 = double.Parse(txt11_B2.Text);
                    c = double.Parse(txt11_C.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (b2 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Red, 4);
                gr.Clear(Color.White);
                i1 = 0;
                j1 = 0;
                i2 = PB.Width - 1;
                j2 = PB.Height - 1;
                n = PB.Width;
                trigonometric_system_koordinat(x1, x2, y1, y2);
                int r = 0;
                n = PB.Width;
                h = (x2 - x1) / n;
                x = x1;
                while (x < x2)
                {
                    y = fCtg(x, a, b1, b2, c);
                    if ((y < y2 && x < -0.1) || (y < y2 && x > 0.1))
                    {
                        gr.DrawLine(myPen, xtoi(x), ytoj(fCtg(x, a, b1, b2, c)), xtoi(x + h), ytoj(fCtg(x + h, a, b1, b2, c)));
                    }
                    x = x + h;
                }

                
                for (double i = 0; i < x2; i += Math.PI)
                {
                    myPen = new Pen(Color.White, 5);
                    gr.DrawLine(myPen, xtoi(i - fk(b1, b2)), ytoj(y1), xtoi(i - fk(b1, b2)), ytoj(y2));
                    myPen = new Pen(Color.Purple, 2);
                    myPen.DashStyle = DashStyle.Dash;
                    gr.DrawLine(myPen, xtoi(i - fk(b1, b2)), ytoj(y1), xtoi(i - fk(b1, b2)), ytoj(y2));
                }
                for (double i = 0; i > x1; i -= Math.PI)
                {
                    myPen = new Pen(Color.White, 5);
                    gr.DrawLine(myPen, xtoi(i - fk(b1, b2)), ytoj(y1), xtoi(i - fk(b1, b2)), ytoj(y2));
                    myPen = new Pen(Color.Purple, 2);
                    myPen.DashStyle = DashStyle.Dash;
                    gr.DrawLine(myPen, xtoi(i - fk(b1, b2)), ytoj(y1), xtoi(i - fk(b1, b2)), ytoj(y2));
                }
                if (c != 0)
                {
                    myPen.Color = Color.Blue;
                    gr.DrawLine(myPen, xtoi(x1), ytoj(c), xtoi(x2), ytoj(c));
                }
                
                PB.Image = bitmap;

                lblGivenFun.Text = "Задана функція: y = ";
                if (a != 1)
                {
                    if (a == -1)
                    {
                        lblGivenFun.Text += " - ";
                    }
                    else
                    {
                        lblGivenFun.Text += a + " ";
                    }
                }
                lblGivenFun.Text += "ctg (x";
                if (b1 * b2 > 0)
                {
                    if (b2 == 1)
                    {
                        if (b1 != 1)
                        {
                            lblGivenFun.Text += " + " + Math.Abs(b1) + "π";
                        }
                        else
                        {
                            if (b1 == 1)
                            {
                                lblGivenFun.Text += " + π";
                            }
                        }
                    }
                    else
                    {
                        if (Math.Abs(b1) == 1)
                        {
                            lblGivenFun.Text += " + π / " + Math.Abs(b2);
                        }
                        else
                        {
                            lblGivenFun.Text += " + " + Math.Abs(b1) + "π / " + Math.Abs(b2);
                        }
                    }
                }
                else
                {
                    if (b1 * b2 < 0)
                    {
                        if (b2 == 1)
                        {
                            if (b1 != 1)
                            {
                                lblGivenFun.Text += " - " + Math.Abs(b1) + "π";
                            }
                            else
                            {
                                if (Math.Abs(b1) == 1)
                                {
                                    lblGivenFun.Text += " - π";
                                }
                            }
                        }
                        else
                        {
                            if (Math.Abs(b1) == 1)
                            {
                                lblGivenFun.Text += " - π / " + Math.Abs(b2);
                            }
                            else
                            {
                                lblGivenFun.Text += " - " + Math.Abs(b1) + "π / " + Math.Abs(b2);
                            }
                        }
                    }
                }
                lblGivenFun.Text += ")";
                if (c > 0)
                {
                    lblGivenFun.Text += " + " + c;
                }
                else
                {
                    if (c < 0)
                    {
                        lblGivenFun.Text += " - " + Math.Abs(c);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn11_FRect_Click(object sender, EventArgs e)
        {
            try
            {
                btn11_Build.PerformClick();
                if (txt11_X11.Text == "")
                {
                    txt11_X11.Text = "1";
                }
                if (txt11_X12.Text == "")
                {
                    txt11_X12.Text = "6";
                }
                if (txt11_X21.Text == "")
                {
                    txt11_X21.Text = "1";
                }
                if (txt11_X22.Text == "")
                {
                    txt11_X22.Text = "3";
                }
                if (txt11_N.Text == "")
                {
                    txt11_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt11_X11.Text);
                    xi12 = float.Parse(txt11_X12.Text);
                    xi21 = float.Parse(txt11_X21.Text);
                    xi22 = float.Parse(txt11_X22.Text);
                    N = int.Parse(txt11_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                S = 0;
                for (double i = fk(xi11, xi12); i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fCtg(i, a, b1, b2, c));
                    S += H * y;
                }
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x <= fk(xi21, xi22))
                {
                    y = fCtg(x, a, b1, b2, c);
                    try
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректі межі інтегрування");
                        return;
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fCtg(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl11_SFRect.Visible = true;
                lbl11_SFRect.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn11_FTrap_Click(object sender, EventArgs e)
        {
            try
            {
                btn11_Build.PerformClick();
                if (txt11_X11.Text == "")
                {
                    txt11_X11.Text = "1";
                }
                if (txt11_X12.Text == "")
                {
                    txt11_X12.Text = "6";
                }
                if (txt11_X21.Text == "")
                {
                    txt11_X21.Text = "1";
                }
                if (txt11_X22.Text == "")
                {
                    txt11_X22.Text = "3";
                }
                if (txt11_N.Text == "")
                {
                    txt11_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt11_X11.Text);
                    xi12 = float.Parse(txt11_X12.Text);
                    xi21 = float.Parse(txt11_X21.Text);
                    xi22 = float.Parse(txt11_X22.Text);
                    N = int.Parse(txt11_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                S = H * ((Math.Abs(fCtg(fk(xi11, xi12), a, b1, b2, c)) + Math.Abs(fCtg(fk(xi21, xi22), a, b1, b2, c))) / 2);
                for (double i = fk(xi11, xi12); i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fCtg(i, a, b1, b2, c));
                    S += H * y;
                }
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x <= fk(xi21, xi22))
                {
                    y = fCtg(x, a, b1, b2, c);
                    try
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректі межі інтегрування");
                        return;
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fCtg(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl11_SFTrap.Visible = true;
                lbl11_SFTrap.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn11_FSympson_Click(object sender, EventArgs e)
        {
            try
            {
                btn11_Build.PerformClick();
                if (txt11_X11.Text == "")
                {
                    txt11_X11.Text = "1";
                }
                if (txt11_X12.Text == "")
                {
                    txt11_X12.Text = "6";
                }
                if (txt11_X21.Text == "")
                {
                    txt11_X21.Text = "1";
                }
                if (txt11_X22.Text == "")
                {
                    txt11_X22.Text = "3";
                }
                if (txt11_N.Text == "")
                {
                    txt11_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt11_X11.Text);
                    xi12 = float.Parse(txt11_X12.Text);
                    xi21 = float.Parse(txt11_X21.Text);
                    xi22 = float.Parse(txt11_X22.Text);
                    N = int.Parse(txt11_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0)
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                H /= 3;
                S = H * ((Math.Abs(fCtg(fk(xi11, xi12), a, b1, b2, c)) + Math.Abs(fCtg(fk(xi21, xi22), a, b1, b2, c))) / 2);
                for (double i = fk(xi11, xi12) + H; i <= fk(xi21, xi22) - 2 * H; i += H)
                {
                    y = Math.Abs(fCtg(i, a, b1, b2, c));
                    S += H * y;
                }
                for (double i = (fk(xi11, xi12) + H / 2); i <= fk(xi21, xi22) - 3 * H / 2; i += H)
                {
                    y = Math.Abs(fCtg(i, a, b1, b2, c));
                    S += 2 * H * y;
                }
                S /= 3;
                

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x <= fk(xi21, xi22))
                {
                    y = fCtg(x, a, b1, b2, c);
                    try
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                    }
                    catch
                    {
                        MessageBox.Show("Введено некоректі межі інтегрування");
                        return;
                    }
                    x = (x + H);
                }
                x = fk(xi11, xi12);
                while (x < fk(xi21, xi22))
                {
                    y = fCtg(x, a, b1, b2, c);
                    //if ( y >= 0)
                    {
                        try
                        {
                            gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(0), xtoi(x + H) - xtoi(x), ytoj(y) - ytoj(0));
                        }
                        catch
                        {
                            MessageBox.Show("Введено некоректі межі інтегрування");
                            return;
                        }
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
                lbl11_SFSympson.Visible = true;
                lbl11_SFSympson.Text = "S = " + Math.Round(S, 2);
            }
            catch
            {
                return;
            }
        }

        private void btn11_FIntegral_Click(object sender, EventArgs e)
        {

            try
            {
                btn11_Build.PerformClick();
                if (txt11_X11.Text == "")
                {
                    txt11_X11.Text = "1";
                }
                if (txt11_X12.Text == "")
                {
                    txt11_X12.Text = "6";
                }
                if (txt11_X21.Text == "")
                {
                    txt11_X21.Text = "1";
                }
                if (txt11_X22.Text == "")
                {
                    txt11_X22.Text = "3";
                }
                if (txt11_N.Text == "")
                {
                    txt11_N.Text = "10";
                }
                try
                {
                    xi11 = float.Parse(txt11_X11.Text);
                    xi12 = float.Parse(txt11_X12.Text);
                    xi21 = float.Parse(txt11_X21.Text);
                    xi22 = float.Parse(txt11_X22.Text);
                    N = int.Parse(txt11_N.Text);
                }
                catch
                {
                    MessageBox.Show("Введено некоректі дані");
                    return;
                }
                if (fk(xi11, xi12) > fk(xi21, xi22))
                {
                    MessageBox.Show("Введено некоректі межі інтегрування");
                    return;
                }
                if (N == 0)
                {
                    MessageBox.Show("Кількість ординат N не може дорівнювати 0");
                    return;
                }
                if (N < 0)
                {
                    MessageBox.Show("Кількість ординат N не може бути менше 0");
                    return;
                }
                if (xi12 == 0 || xi22 == 0) 
                {
                    MessageBox.Show("Ділення на 0!");
                    return;
                }
                myPen = new Pen(Color.Green, 3);
                int hp = PB.Height;
                gr.DrawLine(myPen, xtoi(fk(xi11, xi12)), ytoj(y1), xtoi(fk(xi11, xi12)), ytoj(y2));
                gr.DrawLine(myPen, xtoi(fk(xi21, xi22)), ytoj(y1), xtoi(fk(xi21, xi22)), ytoj(y2));

                S = a * Math.Log((Math.Sin(fk(xi21, xi22) + fk(b1, b2))) / (Math.Sin(fk(xi11, xi12) + fk(b1, b2)))) + c * (fk(xi21, xi22) - fk(xi11, xi12));
                lbl11_SFIntegral.Visible = true;
                lbl11_SFIntegral.Text = "S = " + Math.Round(S, 2);

                H = (fk(xi21, xi22) - fk(xi11, xi12)) / N;
                x = fk(xi11, xi12);
                while (x <= fk(xi21, xi22))
                {
                    y = fCtg(x, a, b1, b2, c);
                    if (y < y2 && y >= 0 && x <= x2)
                    {
                        gr.DrawRectangle(Pens.Purple, xtoi(x), ytoj(y), xtoi(x + H) - xtoi(x), ytoj(0) - ytoj(y));
                        //gr.FillRectangle(Brushes.LightGreen, xtoi(x), ytoj(y), xtoi(x+H)-xtoi(x), ytoj(0)-ytoj(y));
                    }
                    x = (x + H);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
