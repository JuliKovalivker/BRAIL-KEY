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
    public partial class Form2 : Form
    {
        Dictionary<char, int> charToDecimal = new Dictionary<char, int>();
        char[] decimalToChar = new char[64];

        string PUERTO_DISPLAY = "COM5";
        string PUERTO_BOTONERA = "COM3";

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font Font_B, Font_L;

        Form f3 = new Form3();
        string mensaje;
        bool sending;
        int count = 0;
        int done = 0;
        string serial;

        public Form2()
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

            byte[] fontdata2 = Properties.Resources.DunbarTall_Medium;
            IntPtr fontPtr2 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontdata2.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontdata2, 0, fontPtr2, fontdata2.Length);
            uint dummy1 = 0;
            fonts.AddMemoryFont(fontPtr2, Properties.Resources.DunbarTall_Medium.Length);
            AddFontMemResourceEx(fontPtr2, (uint)Properties.Resources.DunbarTall_Medium.Length, IntPtr.Zero, ref dummy1);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr2);

            Font_L = new Font(fonts.Families[1], 16.0F);

            System.ComponentModel.IContainer components = new System.ComponentModel.Container();
            port_botonera = new System.IO.Ports.SerialPort(components);
            port_botonera.DataReceived += new SerialDataReceivedEventHandler(port_botonera_DataReceived);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            txt2.Font = Font_B;
            txt1.Font = Font_L;
            pictureBox1.BackgroundImage = global::prueba1.Properties.Resources.Grupo_Braille_Header;
            pictureBox2.BackgroundImage = global::prueba1.Properties.Resources.Grup_Latin_Header;

            var tempSistEsc = pictureBox1.BackgroundImage;
            pictureBox1.BackgroundImage = pictureBox2.BackgroundImage;
            pictureBox2.BackgroundImage = tempSistEsc;

            if (!charToDecimal.ContainsKey(' '))
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

            if (decimalToChar[1] != 'a')
            {
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
                decimalToChar[22] = '!';
                decimalToChar[23] = 'r';
                decimalToChar[25] = 'd';
                decimalToChar[26] = 'j';
                decimalToChar[27] = 'g';
                decimalToChar[28] = ')';
                decimalToChar[29] = 'n';
                decimalToChar[30] = 't';
                decimalToChar[31] = 'q';
                decimalToChar[34] = '?';
                decimalToChar[35] = '(';
                decimalToChar[36] = '-';
                decimalToChar[37] = 'u';
                decimalToChar[38] = '"';
                decimalToChar[39] = 'v';
                decimalToChar[44] = 'ó';
                decimalToChar[45] = 'x';
                decimalToChar[46] = 'é';
                decimalToChar[48] = 'é'; //48
                decimalToChar[51] = 'ü';
                decimalToChar[53] = 'z';
                decimalToChar[55] = 'á';
                decimalToChar[58] = 'w';
                decimalToChar[59] = 'ñ';
                decimalToChar[61] = 'y';
                decimalToChar[62] = 'ú';
            }
                
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            port_botonera.Close();
            port_display.Close();
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            Font tempFont = new Font(txt1.Font, FontStyle.Regular);
            Font tempFont2 = new Font(txt2.Font, FontStyle.Regular);
            txt1.Font = tempFont2;
            txt2.Font = tempFont;

            var tempSistEsc = pictureBox1.BackgroundImage;
            pictureBox1.BackgroundImage = pictureBox2.BackgroundImage;
            pictureBox2.BackgroundImage = tempSistEsc;

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            txt2.Text = txt1.Text;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            mensaje = txt1.Text;
            sending = true;
        }

        private void port_botonera_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (this.Visible)
            {
                Char output;
                int input = 0;
                string data = port_botonera.ReadExisting();
                input = Convert.ToInt32(data);
                output = (decimalToChar[input]);
                txt1.BeginInvoke(new Action(() => { txt1.Text += Convert.ToString(output); }));
            }
        }

        private void port_display_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serial = port_display.ReadLine();
            if (txt1.Focus())
                txt1.Text += serial;
        }

        private void btnABC_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            f3.ShowDialog();
            if (f3.Visible == false)
                this.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sending)
            {
                try
                {
                    if(done == 0)
                    {
                        if(count < mensaje.Length)
                        {
                            port_display.Write(Convert.ToString(charToDecimal[mensaje[count]]));
                            count++;
                            done++;
                        }
                        else
                        {
                            count = 0;
                            sending = false;
                        }
                    }
                    else
                    {
                        port_display.Write("0");
                        done = 0;
                    }
                }
                catch 
                {
                    MessageBox.Show("El display no se encuentra conectado");
                    sending = false;
                    count = 0;
                    done = 0;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
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
            catch
            {
                //MessageBox.Show("agghd");
            }
            if (this.Visible)
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
                    //MessageBox.Show("agghb");
                }
            }
        }

        private void btnCambio_MouseHover(object sender, EventArgs e)
        {
            btnCambio.BackgroundImage = global::prueba1.Properties.Resources.Grupo_cambio_Press;
            btnCambio.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnCambio_MouseLeave(object sender, EventArgs e)
        {
            btnCambio.BackgroundImage = global::prueba1.Properties.Resources.Grupo_cambio;
        }

        private void btnDisplay_MouseHover(object sender, EventArgs e)
        {
            btnDisplay.BackgroundImage = global::prueba1.Properties.Resources.Display_Press;
            btnDisplay.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnDisplay_MouseLeave(object sender, EventArgs e)
        {
            btnDisplay.BackgroundImage = global::prueba1.Properties.Resources.Display__2_;
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

        private void btnABC_MouseHover(object sender, EventArgs e)
        {
            btnABC.BackgroundImage = global::prueba1.Properties.Resources.Grupo_ABC_Press;
            btnABC.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnABC_MouseLeave(object sender, EventArgs e)
        {
            btnABC.BackgroundImage = global::prueba1.Properties.Resources.Grupo_ABC__3_;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

