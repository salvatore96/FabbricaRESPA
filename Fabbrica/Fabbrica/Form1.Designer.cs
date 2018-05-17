namespace Fabbrica
{
    partial class FabbricaForm1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FabbricaForm1));
            this.Panel = new System.Windows.Forms.Panel();
            this.TbSensAsc = new System.Windows.Forms.TextBox();
            this.labelAsci = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAllarme = new System.Windows.Forms.Label();
            this.TbSensCDx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbCartaDx = new System.Windows.Forms.TextBox();
            this.LabelCartaDx = new System.Windows.Forms.Label();
            this.TbSensCSx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbComandoReset = new System.Windows.Forms.TextBox();
            this.labelReset = new System.Windows.Forms.Label();
            this.TbComandoStart = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.TbCartaSx = new System.Windows.Forms.TextBox();
            this.LabelCartaSx = new System.Windows.Forms.Label();
            this.ButtReset = new System.Windows.Forms.Button();
            this.ButtStart = new System.Windows.Forms.Button();
            this.Carta1 = new System.Windows.Forms.PictureBox();
            this.cartaDx = new System.Windows.Forms.PictureBox();
            this.StampSx = new System.Windows.Forms.PictureBox();
            this.StampDx = new System.Windows.Forms.PictureBox();
            this.cartaSx = new System.Windows.Forms.PictureBox();
            this.MasterTime1 = new System.Windows.Forms.Timer(this.components);
            this.Carta2 = new System.Windows.Forms.PictureBox();
            this.TimerDelay = new System.Windows.Forms.Timer(this.components);
            this.Asciugatura = new System.Windows.Forms.PictureBox();
            this.TimerStampa = new System.Windows.Forms.Timer(this.components);
            this.Carta3 = new System.Windows.Forms.PictureBox();
            this.Carta4 = new System.Windows.Forms.PictureBox();
            this.SensCartaAsciugatura = new System.Windows.Forms.PictureBox();
            this.TimerUscita = new System.Windows.Forms.Timer(this.components);
            this.FineProcesso = new System.Windows.Forms.PictureBox();
            this.Carta5 = new System.Windows.Forms.PictureBox();
            this.Carta6 = new System.Windows.Forms.PictureBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaDx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StampSx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StampDx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaSx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Asciugatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensCartaAsciugatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FineProcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta6)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.Window;
            this.Panel.Controls.Add(this.TbSensAsc);
            this.Panel.Controls.Add(this.labelAsci);
            this.Panel.Controls.Add(this.textBox1);
            this.Panel.Controls.Add(this.labelAllarme);
            this.Panel.Controls.Add(this.TbSensCDx);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.TbCartaDx);
            this.Panel.Controls.Add(this.LabelCartaDx);
            this.Panel.Controls.Add(this.TbSensCSx);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.TbComandoReset);
            this.Panel.Controls.Add(this.labelReset);
            this.Panel.Controls.Add(this.TbComandoStart);
            this.Panel.Controls.Add(this.labelStart);
            this.Panel.Controls.Add(this.TbCartaSx);
            this.Panel.Controls.Add(this.LabelCartaSx);
            this.Panel.Controls.Add(this.ButtReset);
            this.Panel.Controls.Add(this.ButtStart);
            this.Panel.Location = new System.Drawing.Point(12, 3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(660, 197);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // TbSensAsc
            // 
            this.TbSensAsc.Location = new System.Drawing.Point(517, 140);
            this.TbSensAsc.Name = "TbSensAsc";
            this.TbSensAsc.Size = new System.Drawing.Size(93, 20);
            this.TbSensAsc.TabIndex = 18;
            // 
            // labelAsci
            // 
            this.labelAsci.AutoSize = true;
            this.labelAsci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAsci.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsci.Location = new System.Drawing.Point(425, 140);
            this.labelAsci.Name = "labelAsci";
            this.labelAsci.Size = new System.Drawing.Size(82, 16);
            this.labelAsci.TabIndex = 17;
            this.labelAsci.Text = "SensoreAsc";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 16;
            // 
            // labelAllarme
            // 
            this.labelAllarme.AutoSize = true;
            this.labelAllarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAllarme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllarme.Location = new System.Drawing.Point(26, 142);
            this.labelAllarme.Name = "labelAllarme";
            this.labelAllarme.Size = new System.Drawing.Size(58, 16);
            this.labelAllarme.TabIndex = 15;
            this.labelAllarme.Text = "Allarme";
            // 
            // TbSensCDx
            // 
            this.TbSensCDx.Location = new System.Drawing.Point(517, 106);
            this.TbSensCDx.Name = "TbSensCDx";
            this.TbSensCDx.Size = new System.Drawing.Size(93, 20);
            this.TbSensCDx.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "SensoreCDx";
            // 
            // TbCartaDx
            // 
            this.TbCartaDx.Location = new System.Drawing.Point(117, 105);
            this.TbCartaDx.Name = "TbCartaDx";
            this.TbCartaDx.Size = new System.Drawing.Size(93, 20);
            this.TbCartaDx.TabIndex = 12;
            // 
            // LabelCartaDx
            // 
            this.LabelCartaDx.AutoSize = true;
            this.LabelCartaDx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCartaDx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCartaDx.Location = new System.Drawing.Point(26, 106);
            this.LabelCartaDx.Name = "LabelCartaDx";
            this.LabelCartaDx.Size = new System.Drawing.Size(59, 16);
            this.LabelCartaDx.TabIndex = 11;
            this.LabelCartaDx.Text = "CartaDx";
            // 
            // TbSensCSx
            // 
            this.TbSensCSx.Location = new System.Drawing.Point(517, 74);
            this.TbSensCSx.Name = "TbSensCSx";
            this.TbSensCSx.Size = new System.Drawing.Size(93, 20);
            this.TbSensCSx.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "SensoreCSx";
            // 
            // TbComandoReset
            // 
            this.TbComandoReset.Location = new System.Drawing.Point(304, 124);
            this.TbComandoReset.Name = "TbComandoReset";
            this.TbComandoReset.Size = new System.Drawing.Size(93, 20);
            this.TbComandoReset.TabIndex = 8;
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReset.Location = new System.Drawing.Point(232, 125);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(43, 16);
            this.labelReset.TabIndex = 7;
            this.labelReset.Text = "Reset";
            // 
            // TbComandoStart
            // 
            this.TbComandoStart.Location = new System.Drawing.Point(304, 89);
            this.TbComandoStart.Name = "TbComandoStart";
            this.TbComandoStart.Size = new System.Drawing.Size(93, 20);
            this.TbComandoStart.TabIndex = 6;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(232, 89);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(38, 16);
            this.labelStart.TabIndex = 5;
            this.labelStart.Text = "Start";
            // 
            // TbCartaSx
            // 
            this.TbCartaSx.Location = new System.Drawing.Point(117, 69);
            this.TbCartaSx.Name = "TbCartaSx";
            this.TbCartaSx.Size = new System.Drawing.Size(93, 20);
            this.TbCartaSx.TabIndex = 4;
            // 
            // LabelCartaSx
            // 
            this.LabelCartaSx.AutoSize = true;
            this.LabelCartaSx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCartaSx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCartaSx.Location = new System.Drawing.Point(26, 70);
            this.LabelCartaSx.Name = "LabelCartaSx";
            this.LabelCartaSx.Size = new System.Drawing.Size(59, 16);
            this.LabelCartaSx.TabIndex = 2;
            this.LabelCartaSx.Text = "CartaSx";
            // 
            // ButtReset
            // 
            this.ButtReset.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtReset.Location = new System.Drawing.Point(367, 18);
            this.ButtReset.Name = "ButtReset";
            this.ButtReset.Size = new System.Drawing.Size(109, 32);
            this.ButtReset.TabIndex = 1;
            this.ButtReset.Text = "RESET";
            this.ButtReset.UseVisualStyleBackColor = false;
            // 
            // ButtStart
            // 
            this.ButtStart.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtStart.Location = new System.Drawing.Point(200, 18);
            this.ButtStart.Name = "ButtStart";
            this.ButtStart.Size = new System.Drawing.Size(109, 32);
            this.ButtStart.TabIndex = 0;
            this.ButtStart.Text = "START";
            this.ButtStart.UseVisualStyleBackColor = false;
            this.ButtStart.Click += new System.EventHandler(this.ButtStart_Click);
            // 
            // Carta1
            // 
            this.Carta1.BackColor = System.Drawing.Color.White;
            this.Carta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Carta1.Location = new System.Drawing.Point(21, 290);
            this.Carta1.Name = "Carta1";
            this.Carta1.Size = new System.Drawing.Size(53, 33);
            this.Carta1.TabIndex = 1;
            this.Carta1.TabStop = false;
            // 
            // cartaDx
            // 
            this.cartaDx.BackColor = System.Drawing.SystemColors.Desktop;
            this.cartaDx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartaDx.Location = new System.Drawing.Point(184, 372);
            this.cartaDx.Name = "cartaDx";
            this.cartaDx.Size = new System.Drawing.Size(20, 19);
            this.cartaDx.TabIndex = 3;
            this.cartaDx.TabStop = false;
            // 
            // StampSx
            // 
            this.StampSx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StampSx.Image = ((System.Drawing.Image)(resources.GetObject("StampSx.Image")));
            this.StampSx.InitialImage = null;
            this.StampSx.Location = new System.Drawing.Point(204, 238);
            this.StampSx.Name = "StampSx";
            this.StampSx.Size = new System.Drawing.Size(49, 38);
            this.StampSx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StampSx.TabIndex = 4;
            this.StampSx.TabStop = false;
            // 
            // StampDx
            // 
            this.StampDx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StampDx.Image = ((System.Drawing.Image)(resources.GetObject("StampDx.Image")));
            this.StampDx.InitialImage = null;
            this.StampDx.Location = new System.Drawing.Point(204, 326);
            this.StampDx.Name = "StampDx";
            this.StampDx.Size = new System.Drawing.Size(49, 38);
            this.StampDx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StampDx.TabIndex = 7;
            this.StampDx.TabStop = false;
            // 
            // cartaSx
            // 
            this.cartaSx.BackColor = System.Drawing.SystemColors.Desktop;
            this.cartaSx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartaSx.Location = new System.Drawing.Point(184, 213);
            this.cartaSx.Name = "cartaSx";
            this.cartaSx.Size = new System.Drawing.Size(20, 19);
            this.cartaSx.TabIndex = 8;
            this.cartaSx.TabStop = false;
            // 
            // MasterTime1
            // 
            this.MasterTime1.Tick += new System.EventHandler(this.MasterTimer1_Tick);
            // 
            // Carta2
            // 
            this.Carta2.BackColor = System.Drawing.Color.White;
            this.Carta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Carta2.Location = new System.Drawing.Point(21, 281);
            this.Carta2.Name = "Carta2";
            this.Carta2.Size = new System.Drawing.Size(53, 33);
            this.Carta2.TabIndex = 9;
            this.Carta2.TabStop = false;
            // 
            // TimerDelay
            // 
            this.TimerDelay.Interval = 500;
            this.TimerDelay.Tick += new System.EventHandler(this.TimerDelay_Tick);
            // 
            // Asciugatura
            // 
            this.Asciugatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Asciugatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Asciugatura.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Asciugatura.ErrorImage")));
            this.Asciugatura.Image = ((System.Drawing.Image)(resources.GetObject("Asciugatura.Image")));
            this.Asciugatura.InitialImage = ((System.Drawing.Image)(resources.GetObject("Asciugatura.InitialImage")));
            this.Asciugatura.Location = new System.Drawing.Point(385, 230);
            this.Asciugatura.Name = "Asciugatura";
            this.Asciugatura.Size = new System.Drawing.Size(108, 142);
            this.Asciugatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Asciugatura.TabIndex = 10;
            this.Asciugatura.TabStop = false;
            // 
            // TimerStampa
            // 
            this.TimerStampa.Interval = 1500;
            this.TimerStampa.Tick += new System.EventHandler(this.TimerStampa_Tick);
            // 
            // Carta3
            // 
            this.Carta3.BackColor = System.Drawing.Color.White;
            this.Carta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Carta3.Image = ((System.Drawing.Image)(resources.GetObject("Carta3.Image")));
            this.Carta3.Location = new System.Drawing.Point(204, 240);
            this.Carta3.Name = "Carta3";
            this.Carta3.Size = new System.Drawing.Size(53, 33);
            this.Carta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carta3.TabIndex = 11;
            this.Carta3.TabStop = false;
            // 
            // Carta4
            // 
            this.Carta4.BackColor = System.Drawing.Color.White;
            this.Carta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Carta4.Image = ((System.Drawing.Image)(resources.GetObject("Carta4.Image")));
            this.Carta4.Location = new System.Drawing.Point(204, 328);
            this.Carta4.Name = "Carta4";
            this.Carta4.Size = new System.Drawing.Size(53, 33);
            this.Carta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carta4.TabIndex = 12;
            this.Carta4.TabStop = false;
            // 
            // SensCartaAsciugatura
            // 
            this.SensCartaAsciugatura.BackColor = System.Drawing.SystemColors.Desktop;
            this.SensCartaAsciugatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SensCartaAsciugatura.Location = new System.Drawing.Point(505, 372);
            this.SensCartaAsciugatura.Name = "SensCartaAsciugatura";
            this.SensCartaAsciugatura.Size = new System.Drawing.Size(20, 19);
            this.SensCartaAsciugatura.TabIndex = 13;
            this.SensCartaAsciugatura.TabStop = false;
            // 
            // TimerUscita
            // 
            this.TimerUscita.Tick += new System.EventHandler(this.TimerUscita_Tick);
            // 
            // FineProcesso
            // 
            this.FineProcesso.BackColor = System.Drawing.SystemColors.Desktop;
            this.FineProcesso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FineProcesso.Location = new System.Drawing.Point(652, 372);
            this.FineProcesso.Name = "FineProcesso";
            this.FineProcesso.Size = new System.Drawing.Size(20, 19);
            this.FineProcesso.TabIndex = 16;
            this.FineProcesso.TabStop = false;
            // 
            // Carta5
            // 
            this.Carta5.BackColor = System.Drawing.Color.White;
            this.Carta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Carta5.Image = ((System.Drawing.Image)(resources.GetObject("Carta5.Image")));
            this.Carta5.Location = new System.Drawing.Point(505, 240);
            this.Carta5.Name = "Carta5";
            this.Carta5.Size = new System.Drawing.Size(53, 33);
            this.Carta5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carta5.TabIndex = 17;
            this.Carta5.TabStop = false;
            // 
            // Carta6
            // 
            this.Carta6.BackColor = System.Drawing.Color.White;
            this.Carta6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Carta6.Image = ((System.Drawing.Image)(resources.GetObject("Carta6.Image")));
            this.Carta6.Location = new System.Drawing.Point(505, 326);
            this.Carta6.Name = "Carta6";
            this.Carta6.Size = new System.Drawing.Size(53, 33);
            this.Carta6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carta6.TabIndex = 18;
            this.Carta6.TabStop = false;
            // 
            // FabbricaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 409);
            this.Controls.Add(this.Carta6);
            this.Controls.Add(this.Carta5);
            this.Controls.Add(this.FineProcesso);
            this.Controls.Add(this.SensCartaAsciugatura);
            this.Controls.Add(this.Asciugatura);
            this.Controls.Add(this.StampDx);
            this.Controls.Add(this.Carta2);
            this.Controls.Add(this.cartaSx);
            this.Controls.Add(this.StampSx);
            this.Controls.Add(this.cartaDx);
            this.Controls.Add(this.Carta1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Carta3);
            this.Controls.Add(this.Carta4);
            this.Name = "FabbricaForm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FabbricaForm_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaDx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StampSx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StampDx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaSx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Asciugatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensCartaAsciugatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FineProcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carta6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button ButtStart;
        private System.Windows.Forms.Button ButtReset;
        private System.Windows.Forms.TextBox TbCartaSx;
        private System.Windows.Forms.Label LabelCartaSx;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.TextBox TbComandoStart;
        private System.Windows.Forms.TextBox TbComandoReset;
        private System.Windows.Forms.TextBox TbSensCSx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Carta1;
        private System.Windows.Forms.PictureBox cartaDx;
        private System.Windows.Forms.PictureBox StampSx;
        private System.Windows.Forms.PictureBox StampDx;
        private System.Windows.Forms.PictureBox cartaSx;
        private System.Windows.Forms.Label LabelCartaDx;
        private System.Windows.Forms.TextBox TbCartaDx;
        private System.Windows.Forms.TextBox TbSensCDx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer MasterTime1;
        private System.Windows.Forms.PictureBox Carta2;
        private System.Windows.Forms.Timer TimerDelay;
        private System.Windows.Forms.PictureBox Asciugatura;
        private System.Windows.Forms.Timer TimerStampa;
        private System.Windows.Forms.PictureBox Carta3;
        private System.Windows.Forms.PictureBox Carta4;
        private System.Windows.Forms.PictureBox SensCartaAsciugatura;
        private System.Windows.Forms.Timer TimerUscita;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAllarme;
        private System.Windows.Forms.Label labelAsci;
        private System.Windows.Forms.TextBox TbSensAsc;
        private System.Windows.Forms.PictureBox FineProcesso;
        private System.Windows.Forms.PictureBox Carta5;
        private System.Windows.Forms.PictureBox Carta6;
    }
}

