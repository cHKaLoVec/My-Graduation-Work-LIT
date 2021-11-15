using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVALIFA
{
    public partial class frmTeory : Form
    {
        public frmTeory()
        {
            InitializeComponent();
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

        private void pctClose_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                timerPlus.Start();
                timerMinus.Stop();
                this.pctClose.Image = global::KVALIFA.Properties.Resources.RedB;

            }
            catch
            {
                return;
            }
        }

        bool resize = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pnlLeft.Width < 290)
            {
                pnlLeft.Width += 10;
            }
            else
            {
                label1.Visible = true;
                lblTitle.Visible = true;
                lblVstup.Visible = true;
                lblTeory.Visible = true;
                lblVysnovok.Visible = true;
                timer1.Stop();
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
                label1.Visible = false;
                lblTitle.Visible = false;
                lblVstup.Visible = false;
                lblTeory.Visible = false;
                lblVysnovok.Visible = false;
                timer1.Stop();
            }
        }

        void Open1()
        {
            try
            {
                webBrowser1.Navigate(Application.StartupPath + "/teoryTitle.htm");
                lblTitle.BackColor = Color.White;
                lblVstup.BackColor = Color.FromArgb(136, 216, 105);
                lblTeory.BackColor = Color.FromArgb(136, 216, 105);
                lblVysnovok.BackColor = Color.FromArgb(136, 216, 105);
            }
            catch
            {
                return;
            }
        }
        void Open2()
        {
            try
            {
                webBrowser1.Navigate(Application.StartupPath + "/teoryVstup.htm");
                lblTitle.BackColor = Color.FromArgb(136, 216, 105);
                lblVstup.BackColor = Color.White;
                lblTeory.BackColor = Color.FromArgb(136, 216, 105);
                lblVysnovok.BackColor = Color.FromArgb(136, 216, 105);
            }
            catch
            {
                return;
            }
        }
        void Open3()
        {
            try
            {
                webBrowser1.Navigate(Application.StartupPath + "/teoryTeory.htm");
                lblTitle.BackColor = Color.FromArgb(136, 216, 105);
                lblVstup.BackColor = Color.FromArgb(136, 216, 105);
                lblVysnovok.BackColor = Color.FromArgb(136, 216, 105);
                lblTeory.BackColor = Color.White;
            }
            catch
            {
                return;
            }
        }
        void Open4()
        {
            try
            {
                webBrowser1.Navigate(Application.StartupPath + "/teoryVisnovok.htm");
                lblVysnovok.BackColor = Color.White;
                lblTitle.BackColor = Color.FromArgb(136, 216, 105);
                lblVstup.BackColor = Color.FromArgb(136, 216, 105);
                lblTeory.BackColor = Color.FromArgb(136, 216, 105);
            }
            catch
            {
                return;
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            Open1();
            
        }

        private void lblVstup_Click(object sender, EventArgs e)
        {
            Open2();
            
        }

        private void lblTeory_Click(object sender, EventArgs e)
        {
            Open3();
           
        }

        private void lblVysnovok_Click(object sender, EventArgs e)
        {
            Open4();
        }

        private void frmTeory_Load(object sender, EventArgs e)
        {
            Open1();
            toolTip1.SetToolTip(pctExit, "До головного меню");
            toolTip1.SetToolTip(pictureBox1, "Розгорнути/згорнути меню");
            toolTip1.SetToolTip(pctClose, "Вихід");
        }

        private void pctExit_ClientSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void pnlLeft_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pnlLeft_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pnlLeft_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pnlLeft_Leave(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}