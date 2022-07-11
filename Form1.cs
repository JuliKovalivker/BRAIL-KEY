using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form f2 = new Form2();
        Form f3 = new Form3();
        Form f4 = new Form4();
        Form f5 = new Form5();
        Form f6 = new Form6();
        Form f10 = new Form10();

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            f10.ShowDialog();
            if (f10.Visible == false)
                this.Visible = true;
        }

        private void btnJuegos_Click(object sender, EventArgs e)
        {
            this.Hide();
            f5.ShowDialog();
            if (f5.Visible == false)
                this.Visible = true;
        }

        private void btnTraductor_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.ShowDialog();
            if (f2.Visible == false)
                this.Visible = true;
        }

        private void btnABC_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3.ShowDialog(this);
            if (f3.Visible == false)
                this.Visible = true;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            f4.ShowDialog();
            if (f4.Visible == false)
                this.Visible = true;
        }

        private void btnJuegos_MouseHover_1(object sender, EventArgs e)
        {
            btnJuegos.BackgroundImage = global::prueba1.Properties.Resources.Group_Juegos_PRESS__1_;
            btnJuegos.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnJuegos_MouseLeave(object sender, EventArgs e)
        {
            btnJuegos.BackgroundImage = global::prueba1.Properties.Resources.Group_Juegos__1_;
        }

        private void btnTraductor_MouseHover(object sender, EventArgs e)
        {
            btnTraductor.BackgroundImage = global::prueba1.Properties.Resources.Group_Traductor_Press;
            btnTraductor.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnTraductor_MouseLeave(object sender, EventArgs e)
        {
            btnTraductor.BackgroundImage = global::prueba1.Properties.Resources.Group_Traductor__1_;
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            btnInfo.BackgroundImage = global::prueba1.Properties.Resources.Grupo_Info_Press;
            btnInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            btnInfo.BackgroundImage = global::prueba1.Properties.Resources.Grupo_Info__1_;
        }

        private void btnTutorial_MouseHover(object sender, EventArgs e)
        {
            btnTutorial.BackgroundImage = global::prueba1.Properties.Resources.Group_Tutorial_Press;
            btnTutorial.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnTutorial_MouseLeave(object sender, EventArgs e)
        {
            btnTutorial.BackgroundImage = global::prueba1.Properties.Resources.Group_Tutorial;
        }

        private void btnABC_MouseHover(object sender, EventArgs e)
        {
            btnABC.BackgroundImage = global::prueba1.Properties.Resources.Grupo_ABC_Press;
            btnABC.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnABC_MouseLeave(object sender, EventArgs e)
        {
            btnABC.BackgroundImage = global::prueba1.Properties.Resources.Grupo_ABC__3_;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
