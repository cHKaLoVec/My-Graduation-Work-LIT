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
    public partial class frmProgramMenu : Form
    {
        public frmProgramMenu()
        {
            InitializeComponent();
        }

        private void pctClose_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                timerMinus.Interval = 10;
                timerPlus.Interval = 10;
                timerMinus.Start();
                timerPlus.Stop();
                this.pctClose.Image = global::KVALIFA.Properties.Resources.RedB;
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
                timerMinus.Interval = 10;
                timerPlus.Interval = 10;
                timerPlus.Start();
                timerMinus.Stop();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCourse courseForm = new frmCourse();
            courseForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmOneGraphics oneGraphicsForm = new frmOneGraphics();
            oneGraphicsForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmTwoGraphics twoGraphicsForm = new frmTwoGraphics();
            twoGraphicsForm.Show();
            this.Hide();
        }

        private void frmProgramMenu_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pctClose, "Вихід");
            toolTip1.SetToolTip(pictureBox1, "Розв'язування нерівностей");
            toolTip1.SetToolTip(pictureBox2, "Знаходження площ фігур, обмежених одним графіком функції");
            toolTip1.SetToolTip(pictureBox3, "Знаходження площ фігур, обмежених двома графікамм функцій");
            toolTip1.SetToolTip(pictureBox4, "До головного меню");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(200, 255, 255, 255);
            pictureBox1.BackColor= System.Drawing.Color.Transparent;
            pictureBox2.BackColor= System.Drawing.Color.Transparent;
            pictureBox3.BackColor= System.Drawing.Color.Transparent;
            pictureBox4.BackColor= System.Drawing.Color.Transparent;
            label1.BackColor= System.Drawing.Color.Transparent;
            this.BackgroundImage = global::KVALIFA.Properties.Resources.frmCourse;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(219, 249, 184);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(200, 255, 255, 255);
            this.BackgroundImage = global::KVALIFA.Properties.Resources.One_Graphics;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(200, 255, 255, 255);
            this.BackgroundImage = global::KVALIFA.Properties.Resources.Two_Graphics;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}