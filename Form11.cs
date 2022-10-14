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
    public partial class Form11 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font Font_B;

        Dictionary<char, int> charToDecimal = new Dictionary<char, int>();
        char[] decimalToChar = new char[64];

        string PUERTO_BOTONERA = "COM3";

        public Form11()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.Braille_Type;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Braille_Type.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Braille_Type.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            Font_B = new Font(fonts.Families[0], 16.0F);
        }

        int letraElegida;
        int[] letra = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        Random random;
        PictureBox[] letras = new PictureBox[12];
        string[] txtBox = { "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        int[] anteriores = new int[5];
        PictureBox[] hechos_ = new PictureBox[6];

        private void Form11_Load(object sender, EventArgs e)
        {
            System.ComponentModel.IContainer components = new System.ComponentModel.Container();
            port_botonera = new System.IO.Ports.SerialPort(components);
            port_botonera.DataReceived += new SerialDataReceivedEventHandler(port_botonera_DataReceived);

            decimalToChar[0] = ' ';
            decimalToChar[1] = 'a';
            decimalToChar[2] = ',';
            decimalToChar[3] = 'b';
            decimalToChar[4] = '.';
            decimalToChar[5] = 'k';
            decimalToChar[6] = ';';
            decimalToChar[7] = 'l';
            decimalToChar[9] = 'c';
            decimalToChar[10] = 'i';
            decimalToChar[11] = 'f';
            decimalToChar[12] = 'í';
            decimalToChar[13] = 'm';
            decimalToChar[14] = 's';
            decimalToChar[15] = 'p';
            decimalToChar[17] = 'e';
            decimalToChar[18] = ':';
            decimalToChar[19] = 'h';
            decimalToChar[21] = 'o';
            decimalToChar[22] = '!';//
            decimalToChar[23] = 'r';
            decimalToChar[25] = 'd';
            decimalToChar[26] = 'j';
            decimalToChar[27] = 'g';
            decimalToChar[28] = ')';
            decimalToChar[29] = 'n';
            decimalToChar[30] = 't';
            decimalToChar[31] = 'q';
            decimalToChar[34] = '?'; //
            decimalToChar[35] = '(';
            decimalToChar[36] = '-';
            decimalToChar[37] = 'u';
            decimalToChar[38] = '"';
            decimalToChar[39] = 'v';
            decimalToChar[44] = 'ó';
            decimalToChar[45] = 'x';
            decimalToChar[48] = 'é';
            decimalToChar[53] = 'z';
            decimalToChar[55] = 'á';
            decimalToChar[58] = 'w';
            decimalToChar[59] = 'ñ';
            decimalToChar[61] = 'y';
            decimalToChar[62] = 'ú';

            if (this.Visible == true)
            {
                try
                {
                    if (port_botonera.IsOpen == false)
                    {
                        port_botonera.PortName = PUERTO_BOTONERA;
                        port_botonera.BaudRate = 9600;
                        port_botonera.Open();
                    }

                }
                catch
                {
                    // MessageBox.Show("agghb");
                }
            }


            random = new Random();
            letraElegida = random.Next(1, letra.Length + 1);

            txtLetra.Font = Font_B;

            int w_ = Screen.PrimaryScreen.Bounds.Width;
            int h_ = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w_, h_);


            letras[0] = o;
            letras[1] = p;
            letras[2] = q;
            letras[3] = r;
            letras[4] = s;
            letras[5] = t;
            letras[6] = u;
            letras[7] = v;
            letras[8] = w;
            letras[9] = x;
            letras[10] = y;
            letras[11] = z;

            hechos_[0] = pictureBox4;
            hechos_[1] = pictureBox5;
            hechos_[2] = pictureBox6;
            hechos_[3] = pictureBox7;
            hechos_[4] = pictureBox8;
            hechos_[5] = pictureBox9;

            foreach (PictureBox ptbL in letras)
            {
                ptbL.Visible = false;
            }



            for (int i = 1; i <= hechos_.Length - 1; i++)
            {
                hechos_[i].Visible = false;
            }

            letras[letraElegida - 1].Visible = true;

        }

        int vidas = 3;
        int hechos = 0;

        private void port_botonera_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Char output;
            int input = 0;
            string data = port_botonera.ReadExisting();
            input = Convert.ToInt32(data);
            output = (decimalToChar[input]);
            txtLetra.BeginInvoke(new Action(() => { txtLetra.Text += Convert.ToString(output); }));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtLetra.Text == txtBox[letraElegida - 1])
            {
                hechos++;
                hechos_[hechos].Visible = true;
                hechos_[hechos - 1].Visible = false;
                anteriores[hechos - 1] = letraElegida;

                if (hechos == 5)
                {
                    pictureBox9.Visible = true;
                    MessageBox.Show("Ganaste!");
                    this.Visible = false;
                    pictureBox15.Visible = true;
                    pictureBox16.Visible = true;
                    pictureBox17.Visible = true;
                    txtLetra.Text = "";
                    letraElegida = random.Next(1, letra.Length);
                    vidas = 3;
                    hechos = 0;
                    hechos_[0].Visible = true;
                }

                else
                {
                    MessageBox.Show("Correcto! Cierra para hacer el siguiente");
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
                vidas = vidas - 1;

                if (vidas == 0)
                {
                    pictureBox9.Visible = false;
                    MessageBox.Show("Perdiste! Cierra para volver a comenzar");
                    hechos = 0;
                    vidas = 3;
                    txtLetra.Text = "";
                    this.Visible = false;
                    pictureBox15.Visible = true;
                    pictureBox16.Visible = true;
                    pictureBox17.Visible = true;
                    hechos_[0].Visible = true;
                }

                else
                {
                    MessageBox.Show("Incorrecto! Cierra para volver a intentar");

                    if (vidas == 2)
                    {
                        pictureBox17.Visible = false;
                    }

                    if (vidas == 1)
                    {
                        pictureBox16.Visible = false;
                    }

                    txtLetra.Text = "";
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ptbL in letras)
            {
                ptbL.Visible = false;
            }

            letras[letraElegida - 1].Visible = true;
        }

        Form f3 = new Form3();

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
            btnAceptar.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_TIC;
        }

        private void btnSiguiente_MouseHover(object sender, EventArgs e)
        {
            btnSiguiente.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_FLECHA_Press;
            btnSiguiente.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnSiguiente_MouseLeave(object sender, EventArgs e)
        {
            btnSiguiente.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_FLECHA;
        }

        private void Form11_Leave(object sender, EventArgs e)
        {
            port_botonera.Close();
        }

        private void Form11_Shown(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                try
                {
                    if (port_botonera.IsOpen == false)
                    {
                        port_botonera.PortName = PUERTO_BOTONERA;
                        port_botonera.BaudRate = 9600;
                        port_botonera.Open();
                    }

                }
                catch
                {
                    // MessageBox.Show("agghb");
                }
            }

        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            port_botonera.Close();
        }
    }
}
