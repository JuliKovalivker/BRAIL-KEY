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
    public partial class M1N3 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font Font_L;

        public M1N3()
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
        int[] letra = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        Random random;
        PictureBox[] letras = new PictureBox[17];
        string[] txtBox = { "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", ",", "?", "!", ":", "(", ")", ";" };
        int[] anteriores = new int[5];
        PictureBox[] hechos_ = new PictureBox[6];
        int vidas = 3;
        int hechos = 0;
        Form f3 = new ABCyEsp();

        private void Form8_Load(object sender, EventArgs e)
        {
            random = new Random();
            letraElegida = random.Next(1, letra.Length);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h_ = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h_); 
            
            txtLetra.Font = Font_L;

            letras[0] = _1_;
            letras[1] = _2_;
            letras[2] = _3_;
            letras[3] = _4_;
            letras[4] = _5_;
            letras[5] = _6_;
            letras[6] = _7_;
            letras[7] = _8_;
            letras[8] = _9_;
            letras[9] = punto;
            letras[10] = coma;
            letras[11] = pregunta;
            letras[12] = exclamacion;
            letras[13] = dosPuntos;
            letras[14] = ap;
            letras[15] = cp;
            letras[16] = pyc;

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

            barra1.Visible = true;
            barra2.Visible = true;
            barra3.Visible = true;
            txtLetra.Text = "";
            letraElegida = random.Next(1, letra.Length);
            vidas = 3;
            hechos = 0;
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
                    barra0.Visible = true;
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
            }
            else
            {
                vidas--;

                if(vidas == 0)
                {
                    barra1.Visible = false;
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
            btnAceptar.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_TIC_press1;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_TIC1;
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

        private void M1N3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}