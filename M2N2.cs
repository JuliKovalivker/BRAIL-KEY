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
    public partial class M2N2 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font Font_B;

        Dictionary<char, int> charToDecimal = new Dictionary<char, int>();
        char[] decimalToChar = new char[64];

        string PUERTO_BOTONERA = "COM3";

        public M2N2()
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
        Form f3 = new ABCyEsp();
        int vidas = 3;
        int hechos = 0;

        private void M2N2_Load(object sender, EventArgs e)
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

            if (this.Visible)
            {
                try
                {
                    if(!port_botonera.IsOpen)
                    {
                        port_botonera.PortName = PUERTO_BOTONERA;
                        port_botonera.BaudRate = 9600;
                        port_botonera.Open();
                    }

                }
                catch
                { }
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

            hechos_[0] = barra0;
            hechos_[1] = barra1;
            hechos_[2] = barra2;
            hechos_[3] = barra3;
            hechos_[4] = barra4;
            hechos_[5] = barra5;

            foreach (PictureBox ptbL in letras)
                ptbL.Visible = false;

            for (int i = 1; i <= hechos_.Length - 1; i++)
                hechos_[i].Visible = false;

            letras[letraElegida - 1].Visible = true;

            hechos = 0;
            vidas = 3;
            txtLetra.Text = "";
            vida1.Visible = true;
            vida2.Visible = true;
            vida3.Visible = true;
            hechos_[0].Visible = true;
            
        }

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
                            letraElegida = random.Next(1, letra.Length);
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
                    barra5.Visible = false;
                    MessageBox.Show("Perdiste!");
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

        private void M2N2_Shown(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                try
                {
                    if (!port_botonera.IsOpen)
                    {
                        port_botonera.PortName = PUERTO_BOTONERA;
                        port_botonera.BaudRate = 9600;
                        port_botonera.Open();
                    }

                }
                catch { }
            }

        }

        private void M2N2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}
