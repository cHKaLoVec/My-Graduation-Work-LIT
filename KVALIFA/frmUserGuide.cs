using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVALIFA
{
    public partial class frmUserGuide : Form
    {
        public frmUserGuide()
        {
            InitializeComponent();
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
            this.Hide();
        }

        private void pctClose_MouseEnter(object sender, EventArgs e)
        {
            timerPlus.Start();
            timerMinus.Stop();
            this.pctClose.Image = global::KVALIFA.Properties.Resources.closeR;
        }

        private void pctClose_MouseLeave(object sender, EventArgs e)
        {
            timerMinus.Start();
            timerPlus.Stop();
            this.pctClose.Image = global::KVALIFA.Properties.Resources.RedB;
        }

        private void timerPlus_Tick(object sender, EventArgs e)
        {
            if (pctClose.Width <= 30)
            {
                webBrowser1.Visible = false;
                pnlTop.Height += 1;
                pctClose.Width += 1;
                pctClose.Height += 1;
                this.pctClose.Image = global::KVALIFA.Properties.Resources.closeR;
            }
            else
            {
                webBrowser1.Visible = false;
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
                webBrowser1.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pnlLeft.Width<= 560)
            {
                pnlLeft.Width += 20;
            }
            else
            {
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                timer1.Stop();
            }
        }

        bool resize = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (resize == false)
            {
                //webBrowser1.Visible = false;
                resize = true;
                timer1.Start();
                timer2.Stop();
                return;
            }
            else
            {
                if (resize == true)
                {
                    timer2.Start();
                    timer1.Stop();
                    resize = false;
                    return;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pnlLeft.Width > 100)
            {
                pnlLeft.Width -= 20;
            }
            else
            {
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                webBrowser1.Visible = true;
                timer2.Stop();
            }
        }
            
        void OpenFirst()
        {
            webBrowser1.Navigate(Application.StartupPath + "/userGuideCourse.htm");
            lbl1.BackColor = Color.White;
            lbl2.BackColor = Color.FromArgb(136, 216, 105);
            lbl3.BackColor = Color.FromArgb(136, 216, 105);
        }
        void OpenSecond()
        {
            webBrowser1.Navigate(Application.StartupPath + "/userGuideOneGraphic.htm");
            lbl1.BackColor = Color.FromArgb(136, 216, 105);
            lbl2.BackColor = Color.White;
            lbl3.BackColor = Color.FromArgb(136, 216, 105);
        }
        void OpenThird()
        {
            webBrowser1.Navigate(Application.StartupPath + "/userGuideTwoGraphic.htm");
            lbl1.BackColor = Color.FromArgb(136, 216, 105);
            lbl2.BackColor = Color.FromArgb(136, 216, 105);
            lbl3.BackColor = Color.White;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            OpenFirst();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            OpenSecond();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            OpenThird();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void frmUserGuide_Load(object sender, EventArgs e)
        {
            OpenFirst();
            toolTip1.SetToolTip(pctExit, "До головного меню");
            toolTip1.SetToolTip(pictureBox1, "Розгорнути/згорнути меню");
            toolTip1.SetToolTip(pctClose, "Вихід");
        }
    }
}
