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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        PictureBox[] x = new PictureBox[5];
        int i = 0;
        Form f3 = new ABCyEsp();

        private void Form4_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            x[0] = diapo1;
            x[1] = diapo2;
            x[2] = diapo3;
            x[3] = diapo4;
            x[4] = diapo5;

            foreach (PictureBox p in x)
                p.Visible = false;

            x[0].Visible = true;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void next_Click(object sender, EventArgs e)
        {
            i--;
            if (i >= 0 && i < 4)
            {
                x[i].Visible = true;
                x[i + 1].Visible = false;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            i++;
            if (i > 0 && i <= 4)
            {
                x[i].Visible = true;
                x[i - 1].Visible = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnABC_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            f3.ShowDialog();
            if (f3.Visible == false)
                this.Visible = true;
        }

        private void next_MouseHover(object sender, EventArgs e)
        {
            next.BackgroundImage = global::prueba1.Properties.Resources.POSTA_flecha_back_Press1;
            next.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void next_MouseLeave(object sender, EventArgs e)
        {
            next.BackgroundImage = global::prueba1.Properties.Resources.POSTA_flecha_back;
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            back.BackgroundImage = global::prueba1.Properties.Resources.POSTA_flecha_forward_Press1;
            back.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.BackgroundImage = global::prueba1.Properties.Resources.POSTA_flecha_forward;
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

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackgroundImage = global::prueba1.Properties.Resources.Group_home_press;
            btnHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
           btnHome.BackgroundImage = global::prueba1.Properties.Resources.Group__1_1;
        }
    }
}
