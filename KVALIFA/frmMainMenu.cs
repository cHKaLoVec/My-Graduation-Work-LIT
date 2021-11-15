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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void pctClose_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                timerMinus.Start();
                timerPlus.Stop();
                this.pctClose.Image = global::KVALIFA.Properties.Resources.RedB;
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
                pnlTop.Height += 1;
                pctClose.Width += 1;
                pctClose.Height += 1;
                this.pctClose.Image = global::KVALIFA.Properties.Resources.closeR;
            }
            else
            {
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
            }
        }

        private void pctClose_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                timerPlus.Start();
                timerMinus.Stop();
                this.pctClose.Image = global::KVALIFA.Properties.Resources.closeR;


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
            frmTitle titleForm = new frmTitle();
            titleForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmProgramMenu programMenu = new frmProgramMenu();
            programMenu.Show();
            this.Hide();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pctClose, "Вихід");
            toolTip1.SetToolTip(pictureBox1,"Перейти до теоретичної частини");
            toolTip1.SetToolTip(pictureBox2, "Перейти до програмної частини");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmTeory teoryForm = new frmTeory();
            teoryForm.Show();
            this.Hide();
        }
    }
}
