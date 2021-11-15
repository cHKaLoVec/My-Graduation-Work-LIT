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
    public partial class frmTitle : Form
    {
        public frmTitle()
        {
            InitializeComponent();
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

            }
            catch
            {
                return;
            }
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

        private void label1_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void frmTitle_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "До головного меню");
        }
        int x = 72, y=33;

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Width >= 150 && pictureBox1.Height >= 150)
            {
                pictureBox1.Height -= 1;
                pictureBox1.Width -= 1;
                y++;
                x++;
                pictureBox1.Location = new Point(x, y);
            }
            else
            {
                timer2.Stop();
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
            timer2.Start();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Width <= 160 && pictureBox1.Height <= 160)
            {
                pictureBox1.Height += 1;
                pictureBox1.Width += 1;
                y--;
                x--;
                pictureBox1.Location = new Point(x, y);
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
