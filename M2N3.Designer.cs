namespace prueba1
{
    partial class M2N3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M2N3));
            this.port_botonera = new System.IO.Ports.SerialPort(this.components);
            this.ap = new System.Windows.Forms.PictureBox();
            this.cp = new System.Windows.Forms.PictureBox();
            this.pyc = new System.Windows.Forms.PictureBox();
            this.btnABC = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.dosPuntos = new System.Windows.Forms.PictureBox();
            this.exclamacion = new System.Windows.Forms.PictureBox();
            this.pregunta = new System.Windows.Forms.PictureBox();
            this.coma = new System.Windows.Forms.PictureBox();
            this.punto = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pyc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exclamacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto)).BeginInit();
            this.SuspendLayout();
            // 
            // port_botonera
            // 
            this.port_botonera.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_botonera_DataReceived);
            // 
            // ap
            // 
            this.ap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ap.BackColor = System.Drawing.Color.Transparent;
            this.ap.BackgroundImage = global::prueba1.Properties.Resources.abre_parentesis;
            this.ap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ap.Location = new System.Drawing.Point(495, 116);
            this.ap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(404, 353);
            this.ap.TabIndex = 79;
            this.ap.TabStop = false;
            // 
            // cp
            // 
            this.cp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cp.BackColor = System.Drawing.Color.Transparent;
            this.cp.BackgroundImage = global::prueba1.Properties.Resources.cierra_parentesis;
            this.cp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cp.Location = new System.Drawing.Point(495, 116);
            this.cp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(404, 353);
            this.cp.TabIndex = 78;
            this.cp.TabStop = false;
            // 
            // pyc
            // 
            this.pyc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pyc.BackColor = System.Drawing.Color.Transparent;
            this.pyc.BackgroundImage = global::prueba1.Properties.Resources.punto_y_coma;
            this.pyc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pyc.Location = new System.Drawing.Point(495, 94);
            this.pyc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pyc.Name = "pyc";
            this.pyc.Size = new System.Drawing.Size(404, 375);
            this.pyc.TabIndex = 77;
            this.pyc.TabStop = false;
            // 
            // btnABC
            // 
            this.btnABC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnABC.BackColor = System.Drawing.Color.Transparent;
            this.btnABC.BackgroundImage = global::prueba1.Properties.Resources.Grupo_ABC;
            this.btnABC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnABC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnABC.FlatAppearance.BorderSize = 0;
            this.btnABC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABC.Location = new System.Drawing.Point(984, 74);
            this.btnABC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnABC.Name = "btnABC";
            this.btnABC.Size = new System.Drawing.Size(181, 78);
            this.btnABC.TabIndex = 76;
            this.btnABC.UseVisualStyleBackColor = false;
            this.btnABC.Click += new System.EventHandler(this.btnABC_Click);
            this.btnABC.MouseLeave += new System.EventHandler(this.btnABC_MouseLeave);
            this.btnABC.MouseHover += new System.EventHandler(this.btnABC_MouseHover);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_FLECHA;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Location = new System.Drawing.Point(713, 582);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(177, 71);
            this.btnSiguiente.TabIndex = 74;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            this.btnSiguiente.MouseLeave += new System.EventHandler(this.btnSiguiente_MouseLeave);
            this.btnSiguiente.MouseHover += new System.EventHandler(this.btnSiguiente_MouseHover);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_TIC;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(510, 582);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(177, 71);
            this.btnAceptar.TabIndex = 73;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // txtLetra
            // 
            this.txtLetra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLetra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.txtLetra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLetra.Location = new System.Drawing.Point(550, 513);
            this.txtLetra.Margin = new System.Windows.Forms.Padding(4);
            this.txtLetra.Multiline = true;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(305, 37);
            this.txtLetra.TabIndex = 72;
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::prueba1.Properties.Resources.GRUPO_TEXT_BOX;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(510, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 75);
            this.button1.TabIndex = 75;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::prueba1.Properties.Resources.coracon_pe_21;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(257, 141);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(84, 65);
            this.pictureBox8.TabIndex = 71;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::prueba1.Properties.Resources.coracon_pe_21;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(170, 141);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(84, 65);
            this.pictureBox7.TabIndex = 70;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::prueba1.Properties.Resources.coracon_pe_21;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(89, 141);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(84, 65);
            this.pictureBox6.TabIndex = 69;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::prueba1.Properties.Resources.barra_5;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(63, 77);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(307, 59);
            this.pictureBox5.TabIndex = 68;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::prueba1.Properties.Resources.barra_4;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(63, 77);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(307, 59);
            this.pictureBox4.TabIndex = 67;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::prueba1.Properties.Resources.barra_3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(63, 77);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(307, 59);
            this.pictureBox3.TabIndex = 66;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::prueba1.Properties.Resources.barra_2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(63, 77);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 59);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::prueba1.Properties.Resources.barra_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(63, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 59);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::prueba1.Properties.Resources.barra_0;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(63, 68);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(340, 79);
            this.pictureBox9.TabIndex = 63;
            this.pictureBox9.TabStop = false;
            // 
            // dosPuntos
            // 
            this.dosPuntos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dosPuntos.BackColor = System.Drawing.Color.Transparent;
            this.dosPuntos.BackgroundImage = global::prueba1.Properties.Resources.dos_puntos;
            this.dosPuntos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dosPuntos.Location = new System.Drawing.Point(498, 116);
            this.dosPuntos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dosPuntos.Name = "dosPuntos";
            this.dosPuntos.Size = new System.Drawing.Size(401, 353);
            this.dosPuntos.TabIndex = 49;
            this.dosPuntos.TabStop = false;
            // 
            // exclamacion
            // 
            this.exclamacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exclamacion.BackColor = System.Drawing.Color.Transparent;
            this.exclamacion.BackgroundImage = global::prueba1.Properties.Resources.exclamacion;
            this.exclamacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exclamacion.Location = new System.Drawing.Point(498, 116);
            this.exclamacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exclamacion.Name = "exclamacion";
            this.exclamacion.Size = new System.Drawing.Size(401, 353);
            this.exclamacion.TabIndex = 50;
            this.exclamacion.TabStop = false;
            // 
            // pregunta
            // 
            this.pregunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pregunta.BackColor = System.Drawing.Color.Transparent;
            this.pregunta.BackgroundImage = global::prueba1.Properties.Resources.pregunta;
            this.pregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pregunta.Location = new System.Drawing.Point(498, 116);
            this.pregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(401, 353);
            this.pregunta.TabIndex = 51;
            this.pregunta.TabStop = false;
            // 
            // coma
            // 
            this.coma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coma.BackColor = System.Drawing.Color.Transparent;
            this.coma.BackgroundImage = global::prueba1.Properties.Resources.coma;
            this.coma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coma.Location = new System.Drawing.Point(495, 51);
            this.coma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(401, 418);
            this.coma.TabIndex = 52;
            this.coma.TabStop = false;
            // 
            // punto
            // 
            this.punto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.punto.BackColor = System.Drawing.Color.Transparent;
            this.punto.BackgroundImage = global::prueba1.Properties.Resources.coma_1;
            this.punto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.punto.Location = new System.Drawing.Point(495, 61);
            this.punto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(401, 408);
            this.punto.TabIndex = 53;
            this.punto.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::prueba1.Properties.Resources.exit;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(1190, 71);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(88, 81);
            this.btnAtras.TabIndex = 80;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            this.btnAtras.MouseLeave += new System.EventHandler(this.btnAtras_MouseLeave);
            this.btnAtras.MouseHover += new System.EventHandler(this.btnAtras_MouseHover);
            // 
            // M2N3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prueba1.Properties.Resources.FONDO_1__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.pyc);
            this.Controls.Add(this.btnABC);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.coma);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.exclamacion);
            this.Controls.Add(this.dosPuntos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "M2N3";
            this.Text = "Brail፧Key";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form12_FormClosed);
            this.Load += new System.EventHandler(this.Form12_Load);
            this.Shown += new System.EventHandler(this.Form12_Shown);
            this.Leave += new System.EventHandler(this.Form12_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.ap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pyc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exclamacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort port_botonera;
        private System.Windows.Forms.PictureBox ap;
        private System.Windows.Forms.PictureBox cp;
        private System.Windows.Forms.PictureBox pyc;
        private System.Windows.Forms.Button btnABC;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox dosPuntos;
        private System.Windows.Forms.PictureBox exclamacion;
        private System.Windows.Forms.PictureBox pregunta;
        private System.Windows.Forms.PictureBox coma;
        private System.Windows.Forms.PictureBox punto;
        private System.Windows.Forms.Button btnAtras;
    }
}