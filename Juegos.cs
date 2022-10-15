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
    public partial class Juegos : Form
    {
        public Juegos()
        {
            InitializeComponent();
        }

        Form f6 = new M1N1();
        Form f7 = new M1N2();
        Form f8 = new M1N3();
        

        private void Form5_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void btnModo1Lvl1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            f6.ShowDialog();
            if (f6.Visible == false)
            {
                this.Visible = true;
            }

        }

        private void btnModo1Lvl2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            f7.ShowDialog();
            if (f7.Visible == false)
            {
                this.Visible = true;
            }
        }

        private void btnModo1Lvl3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            f8.ShowDialog();
            if (f8.Visible == false)
            {
                this.Visible = true;
            }
        }

        private void btnModo1Lvl1_MouseHover(object sender, EventArgs e)
        {
            btnModo1Lvl1.BackgroundImage = global::prueba1.Properties.Resources.nivel_1_Press;
            btnModo1Lvl1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnModo1Lvl1_MouseLeave(object sender, EventArgs e)
        {
            btnModo1Lvl1.BackgroundImage = global::prueba1.Properties.Resources.nivel_1;
        }

        private void btnModo1Lvl2_MouseHover(object sender, EventArgs e)
        {
            btnModo1Lvl2.BackgroundImage = global::prueba1.Properties.Resources.NIVEL_2_Press;
            btnModo1Lvl2.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnModo1Lvl2_MouseLeave(object sender, EventArgs e)
        {
            btnModo1Lvl2.BackgroundImage = global::prueba1.Properties.Resources.NIVEL_2;
        }

        private void btnModo1Lvl3_MouseHover(object sender, EventArgs e)
        {
            btnModo1Lvl3.BackgroundImage = global::prueba1.Properties.Resources.NIVEL_3_Press;
            btnModo1Lvl3.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnModo1Lvl3_MouseLeave(object sender, EventArgs e)
        {
            btnModo1Lvl3.BackgroundImage = global::prueba1.Properties.Resources.NIVEL_3;
        }

        private void btnModo2Lvl1_MouseHover(object sender, EventArgs e)
        {
            btnModo2Lvl1.BackgroundImage = global::prueba1.Properties.Resources.nivel_1_Press;
            btnModo2Lvl1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnModo2Lvl1_MouseLeave(object sender, EventArgs e)
        {
            btnModo2Lvl1.BackgroundImage = global::prueba1.Properties.Resources.nivel_1;
        }

        private void btnModo2Lvl2_MouseHover(object sender, EventArgs e)
        {
            btnModo2Lvl2.BackgroundImage = global::prueba1.Properties.Resources.NIVEL_2_Press;
            btnModo2Lvl2.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnModo2Lvl2_MouseLeave(object sender, EventArgs e)
        {
            btnModo2Lvl2.BackgroundImage = global::prueba1.Properties.Resources.NIVEL_2;
        }

        private void btnModo2Lvl3_MouseHover(object sender, EventArgs e)
        {
            btnModo2Lvl3.BackgroundImage = global::prueba1.Properties.Resources.NIVEL_3_Press;
            btnModo2Lvl3.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnModo2Lvl3_MouseLeave(object sender, EventArgs e)
        {
            btnModo2Lvl3.BackgroundImage = global::prueba1.Properties.Resources.NIVEL_3;
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackgroundImage = global::prueba1.Properties.Resources.Group_home_press;
            btnHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackgroundImage = global::prueba1.Properties.Resources.Group__1_;
        }

        private void btnABC_MouseHover(object sender, EventArgs e)
        {
            btnABC.BackgroundImage = global::prueba1.Properties.Resources.Grupo_ABC_Press;
            btnABC.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnABC_MouseLeave(object sender, EventArgs e)
        {
            btnABC.BackgroundImage = global::prueba1.Properties.Resources.Grupo_ABC;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;           
        }

        Form f9 = new M2N1();

        private void btnModo2Lvl1_Click(object sender, EventArgs e)
        {
            f9.ShowDialog();
            this.Visible = false;
            if (f9.Visible == false)
            {
                this.Visible = true;
            }
        }

        Form f11 = new M2N2();

        private void btnModo2Lvl2_Click(object sender, EventArgs e)
        {
            f11.ShowDialog();
            this.Visible = false;
            if (f11.Visible == false)
            {
                this.Visible = true;
            }
        }

        Form f3 = new ABCyEsp();

        private void btnABC_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            f3.ShowDialog();
            if (f3.Visible == false)
            {
                this.Visible = true;
            }
        }

        Form f12 = new M2N3();

        private void btnModo2Lvl3_Click(object sender, EventArgs e)
        {
            f12.ShowDialog();
            this.Visible = false;
            if (f12.Visible == false)
            {
                this.Visible = true;
            }
        }
    }
}
