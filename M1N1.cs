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
    public partial class M1N1 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font Font_L;

        string PUERTO_DISPLAY = "COM4";
        char mensaje;
        Dictionary<char, int> charToDecimal = new Dictionary<char, int>();

        public M1N1()
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
        PictureBox[] letras = new PictureBox[14];
        string[] txtBox = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" };
        int[] anteriores = new int[5];
        PictureBox[] hechos_ = new PictureBox[7]; 
        int vidas = 3;
        int hechos = 0;
        Form f3 = new ABCyEsp();
        bool start = false;

        private void M1N1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h_ = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h_);

            txtLetra.Font = Font_L;

            random = new Random();
            letraElegida = random.Next(1, letra.Length + 1);

            letras[0] = a;
            letras[1] = b;
            letras[2] = c;
            letras[3] = d;
            letras[4] = e_;
            letras[5] = f;
            letras[6] = g;
            letras[7] = h;
            letras[8] = i;
            letras[9] = j;
            letras[10] = k;
            letras[11] = l;
            letras[12] = m;
            letras[13] = n;

            hechos_[0] = barra0;
            hechos_[1] = barra1;
            hechos_[2] = barra2;
            hechos_[3] = barra3;
            hechos_[4] = barra4;
            hechos_[5] = barra4;
            hechos_[6] = barra5;

            foreach(PictureBox ptbL in letras)
                ptbL.Visible = false;

            letras[letraElegida - 1].Visible = true;

            for(int i = 1; i <= hechos_.Length - 1; i++)
                hechos_[i].Visible = false;

            hechos = 0;
            vidas = 3;
            txtLetra.Text = "";
            vida1.Visible = true;
            vida2.Visible = true;
            vida3.Visible = true;
            hechos_[0].Visible = true;

            if(!charToDecimal.ContainsKey(' '))
            {
                charToDecimal.Add(' ', 0);
                charToDecimal.Add('a', 1);
                charToDecimal.Add('b', 3);
                charToDecimal.Add('c', 9);
                charToDecimal.Add('d', 25);
                charToDecimal.Add('e', 17);
                charToDecimal.Add('f', 11);
                charToDecimal.Add('g', 27);
                charToDecimal.Add('h', 19);
                charToDecimal.Add('i', 10);
                charToDecimal.Add('j', 26);
                charToDecimal.Add('k', 5);
                charToDecimal.Add('l', 7);
                charToDecimal.Add('m', 13);
                charToDecimal.Add('n', 29);
                charToDecimal.Add('ñ', 59);
                charToDecimal.Add('o', 21);
                charToDecimal.Add('p', 15);
                charToDecimal.Add('q', 31);
                charToDecimal.Add('r', 23);
                charToDecimal.Add('s', 14);
                charToDecimal.Add('t', 30);
                charToDecimal.Add('u', 37);
                charToDecimal.Add('v', 39);
                charToDecimal.Add('w', 58);
                charToDecimal.Add('x', 45);
                charToDecimal.Add('y', 61);
                charToDecimal.Add('z', 53);
                charToDecimal.Add('á', 55);
                charToDecimal.Add('é', 46);
                charToDecimal.Add('í', 12);
                charToDecimal.Add('ó', 44);
                charToDecimal.Add('ú', 62);
                charToDecimal.Add('ü', 51);
                charToDecimal.Add('.', 4);
                charToDecimal.Add(',', 2);
                charToDecimal.Add('?', 34);
                //charToDecimal.Add('¿', 34);
                charToDecimal.Add(';', 6);
                charToDecimal.Add(':', 18);
                charToDecimal.Add('!', 22);
                //charToDecimal.Add('¡', 22);
                charToDecimal.Add('"', 38);
                charToDecimal.Add('(', 35);
                charToDecimal.Add(')', 28);
                charToDecimal.Add('-', 36);

            }

                try
                {
                    if (!port_display.IsOpen)
                    {
                        port_display.PortName = PUERTO_DISPLAY;
                        port_display.BaudRate = 9600;
                        port_display.Open();
                    }

                }
                catch { }

                mensaje = char.Parse(txtBox[letraElegida - 1]);
                port_display.Write(Convert.ToString(charToDecimal[mensaje]));

            }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtLetra.Text == txtBox[letraElegida - 1])
            {
                hechos++;
                hechos_[hechos].Visible = true;
                hechos_[hechos-1].Visible = false;
                anteriores[hechos - 1] = letraElegida;

                if(hechos == 5)
                {
                    barra5.Visible = true;
                    MessageBox.Show("Ganaste!");
                    port_display.Write("0");
                    port_display.Close();
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
                        if(anteriores[x] == letraElegida)
                            letraElegida = random.Next(1, letra.Length);
                    }
                    
                    foreach (PictureBox ptbL in letras)
                    ptbL.Visible = false;

                    letras[letraElegida - 1].Visible = true;
                    mensaje = char.Parse(txtBox[letraElegida - 1]);
                    port_display.Write(Convert.ToString(charToDecimal[mensaje]));

                }
            }
            else
            {
                vidas --;

                if(vidas == 0)
                {
                    vida1.Visible = false;
                    MessageBox.Show("Perdiste!");
                    port_display.Write("0");
                    port_display.Close();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Incorrecto!");

                    if (vidas == 2)
                        vida3.Visible = false;

                    if (vidas == 1)
                        vida2.Visible = false;

                    txtLetra.Text = "";
                }
            }

        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            btnAceptar.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_TIC_press1;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_TIC;
        }

        private void btnABC_Click_1(object sender, EventArgs e)
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

        private void M1N1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            port_display.Write("0");
            port_display.Close();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                try
                {
                    if (!port_display.IsOpen)
                    {
                        port_display.PortName = PUERTO_DISPLAY;
                        port_display.BaudRate = 9600;
                        port_display.Open();
                    }

                }
                catch {  }

            }
        }
    }
}