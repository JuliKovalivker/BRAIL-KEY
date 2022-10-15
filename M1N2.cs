using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Reflection;
using System.Threading;

namespace prueba1
{
    public partial class M1N2 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font Font_L;

        public M1N2()
        {
            InitializeComponent();
            byte[] fontdata2 = Properties.Resources.DunbarTall_Medium;
            IntPtr fontPtr2 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontdata2.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontdata2, 0, fontPtr2, fontdata2.Length);
            uint dummy1 = 0;
            fonts.AddMemoryFont(fontPtr2, Properties.Resources.DunbarTall_Medium.Length);
            AddFontMemResourceEx(fontPtr2, (uint)Properties.Resources.DunbarTall_Medium.Length, IntPtr.Zero, ref dummy1);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr2);

            Font_L = new Font(fonts.Families[0], 16.0F);
        }

        int letraElegida;
        int[] letra = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        Random random;
        PictureBox[] letras = new PictureBox[13];
        string[] txtBox = { "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        int[] anteriores = new int[5];
        PictureBox[] hechos_ = new PictureBox[6];
        int vidas = 3;
        int hechos = 0;
        Form f3 = new ABCyEsp();

        private void M1N2_Load(object sender, EventArgs e)
        {
            int w_ = Screen.PrimaryScreen.Bounds.Width;
            int h_ = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w_, h_);
            
            txtLetra.Font = Font_L;

            random = new Random();
            letraElegida = random.Next(1, letra.Length);

            letras[0] = ñ;
            letras[1] = o;
            letras[2] = p;
            letras[3] = q;
            letras[4] = r;
            letras[5] = s;
            letras[6] = t;
            letras[7] = u;
            letras[8] = v;
            letras[9] = w;
            letras[10] = x;
            letras[11] = y;
            letras[12] = z;

            hechos_[0] = barra0;
            hechos_[1] = barra1;
            hechos_[2] = barra2;
            hechos_[3] = barra3;
            hechos_[4] = barra4;
            hechos_[5] = barra5;

            foreach (PictureBox ptbL in letras)
                ptbL.Visible = false;

            letras[letraElegida - 1].Visible = true;

            for (int i = 1; i <= hechos_.Length - 1; i++)
                hechos_[i].Visible = false;

            hechos = 0;
            vidas = 3;
            txtLetra.Text = "";
            vida1.Visible = true;
            vida2.Visible = true;
            vida3.Visible = true;
            hechos_[0].Visible = true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtLetra.Text == txtBox[letraElegida - 1])
            {
                hechos++;
                hechos_[hechos].Visible = true;
                hechos_[hechos - 1].Visible = false;
                anteriores[hechos - 1] = letraElegida;

                if(hechos == 5)
                {
                    barra5.Visible = true;
                    MessageBox.Show("Ganaste!");
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Correcto!");
                    letras[letraElegida - 1].Visible = false;
                    txtLetra.Text = "";
                    letraElegida = random.Next(1, letra.Length);

                    for (int x = 0; x < anteriores.Length - 1; x++)
                    {
                        if (anteriores[x] == letraElegida)
                        {
                            letraElegida = random.Next(1, letra.Length);
                        }
                    }
                }

                foreach (PictureBox ptbL in letras)
                    ptbL.Visible = false;

                letras[letraElegida - 1].Visible = true;
            }
            else
            {
                vidas--;

                if(vidas == 0)
                {
                    vida1.Visible = false;
                    MessageBox.Show("Perdiste!");
                    this.Visible = false;
                  
                }
                else
                {
                    MessageBox.Show("Incorrecto!");

                    if(vidas == 2)
                        vida3.Visible = false;

                    if(vidas == 1)
                        vida2.Visible = false;

                    txtLetra.Text = "";
                }
            }
        }

        private void btnABC_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
            this.Visible = false;
            if (f3.Visible == false)
                this.Visible = true;
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

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            btnAceptar.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_TIC_press2;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_TIC__1_;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

        private void M1N2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}