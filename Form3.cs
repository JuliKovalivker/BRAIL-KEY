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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            especiales.Visible = false;
            btnCambio2.Visible = false;
        }

        private void btnCambio_MouseHover(object sender, EventArgs e)
        {
            btnCambio.BackgroundImage = global::prueba1.Properties.Resources.siguiente_Press;
            btnCambio.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnCambio_MouseLeave(object sender, EventArgs e)
        {
            btnCambio.BackgroundImage = global::prueba1.Properties.Resources.siguiente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abc.Visible = true;
            especiales.Visible = true;
            btnCambio2.Visible = true;
            btnCambio.Visible = true; 
            this.Visible = false;        
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            abc.Visible = false;
            especiales.Visible = true;
            btnCambio2.Visible = true;
            btnCambio.Visible = false;
        }

        private void btnCambio2_Click(object sender, EventArgs e)
        {
            abc.Visible = true;
            especiales.Visible = false;
            btnCambio2.Visible = false;
            btnCambio.Visible = true;
        }

        private void btnAtras_MouseHover(object sender, EventArgs e)
        {
            btnAtras.BackgroundImage = global::prueba1.Properties.Resources.exit_Press;
            btnAtras.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnAtras_MouseLeave(object sender, EventArgs e)
        {
            btnAtras.BackgroundImage = global::prueba1.Properties.Resources.exit;
        }

        private void btnCambio2_MouseHover(object sender, EventArgs e)
        {
            btnCambio2.BackgroundImage = global::prueba1.Properties.Resources.flecha_back_larga_Press;
            btnCambio.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnCambio2_MouseLeave(object sender, EventArgs e)
        {
            btnCambio2.BackgroundImage = global::prueba1.Properties.Resources.flecha_back_larga;
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            abc.Visible = true;
            especiales.Visible = true;
            btnCambio2.Visible = true;
            btnCambio.Visible = true;
            this.Visible = false;
            Form f1 = new Form1();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
