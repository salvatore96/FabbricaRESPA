using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabbrica
{
    public partial class FabbricaForm1 : Form
    {
        private int durata1;
        private int delta;
        private int posX;
        private int posY;
        private int posX2;
        private int posY2;
        private int posX3;
        private int posY3;
        private int posX4;
        private int posY4;
        private int posX5;
        private int posY5;
        private int posX6;
        private int posY6;
        private int targetX;
        private int targetY;
        private int targetX2;
        private int targetY2;
        private int targetX_Asc;
        private int targetY_Asc;
        private int spost;
        private int delta2;
        private int durata2;
        private int delta3;
        private int durata3;

        public FabbricaForm1()
        {
            InitializeComponent();
        }

        private void FabbricaForm_Load(object sender, EventArgs e)
        {
            durata1 = 1000;                      //durata prima del bivio
            delta = MasterTime1.Interval;        //valore intervallo
            posX = Carta1.Location.X;            //posizione x
            posY = Carta1.Location.Y;            //posizione y
            posX2 = Carta2.Location.X;           //posizione x
            posY2 = Carta2.Location.Y;           //posizione y
            posX3 = Carta3.Location.X;           //posizione x
            posY3 = Carta3.Location.Y;           //posizione y
            posX4 = Carta4.Location.X;           //posizione x
            posY4 = Carta4.Location.Y;           //posizione y
            posX5 = Carta5.Location.X;           //posizione x
            posY5 = Carta5.Location.Y;           //posizione y
            posX6 = Carta6.Location.X;           //posizione x
            posY6 = Carta6.Location.Y;           //posizione y
            targetX = StampSx.Location.X;        //obiettivo x
            targetY = StampSx.Location.Y;        //obiettivo y
            targetX2 = StampDx.Location.X;       //obiettivo x
            targetY2 = StampDx.Location.Y;       //obiettivo y
            targetX_Asc = Asciugatura.Location.X;
            targetY_Asc = Asciugatura.Location.Y;
            Carta2.Visible = false;
            Carta3.Visible = false;
            Carta4.Visible = false;
            Carta5.Visible = false;
            Carta6.Visible = false;
            spost = 30;
            delta2 = TimerUscita.Interval;
            durata2 = 200;
            delta3 = TimerUscita.Interval;
            durata3 = 1000;
            //ciao ciao
        }

        private void ButtStart_Click(object sender, EventArgs e)
        {
            TimerDelay.Enabled = true;
            TbComandoStart.Text = "True";
        }

        private void TimerDelay_Tick(object sender, EventArgs e)
        {
            if (TbComandoStart.Text.Equals("True"))
            {
                TbComandoStart.Text = "False";
                MasterTime1.Enabled = true;
            }

            if (TbComandoReset.Text.Equals("True"))
            {
                TbComandoReset.Text = "";
                TbComandoStart.Text = "";
                MasterTime1.Enabled = true;
            }
        }

        private void MasterTimer1_Tick(object sender, EventArgs e)
        {
            if (TimerDelay.Equals(durata1))
            {
                MasterTime1.Start();
            }

            //carta va a sinistra
            if (TbCartaSx.Text.Equals("True"))
            {
                if (TbSensCDx.Text.Equals("True"))
                {
                    posX2 = targetX2 - 30;
                    posY2 = targetY2;
                    TbCartaDx.Text = "";
                }
                else
                {
                    Carta2.Visible = false;
                }

                Carta1.Visible = true;

                posX = posX + (int)((targetX - posX) * delta / durata1);
                Carta1.Left = posX;
                posY = posY + (int)((targetY - posY) * delta / durata1);
                Carta1.Top = posY;
            }

            if (posX >= (targetX - 30) && posY >= (targetY - 30))
            {
                posX = targetX - 20;
                posY = targetY + 2;
                if (TbComandoStart.Text.Equals("False"))
                {
                    TbSensCSx.Text = "True";
                    cartaSx.BackColor = System.Drawing.Color.Lime;
                }
            }

            //carta va a destra
            if (TbCartaDx.Text.Equals("True"))
            {
                if (TbSensCSx.Text.Equals("True"))
                {
                    posX = targetX - 30;
                    posY = targetY + 10;
                    TbCartaSx.Text = "";
                }
                else
                {
                    Carta1.Visible = false;
                }

                Carta2.Visible = true;

                posY2 = posY2 + (int)((targetY2 - posY2 + 10) * delta / durata1);
                Carta2.Top = posY2;
                posX2 = posX2 + (int)((targetX2 - posX2 - 20) * delta / durata1);
                Carta2.Left = posX2;
            }

            if (posX2 >= (targetX2 - 30) && posY2 >= (targetY2 - 30))
            {
                posX2 = targetX2 - 20;
                posY2 = targetY2;
                if (TbComandoStart.Text.Equals("False"))
                {
                    TbSensCDx.Text = "True";
                    cartaDx.BackColor = System.Drawing.Color.Lime;
                }
            }

            //stampaggio
            if (TbSensCDx.Text.Equals("True") && TbSensCSx.Text.Equals("True"))
            {
                TimerStampa.Enabled = true;
                Carta1.Visible = false;
                Carta2.Visible = false;
            }
        }

        private void TimerStampa_Tick(object sender, EventArgs e)
        {
            Carta3.Visible = true;
            Carta4.Visible = true;
            posX3 = posX3 + (int)(spost * delta2 / durata2);
            Carta3.Left = posX3;
            posX4 = posX4 + (int)(spost * delta2 / durata2);
            Carta4.Left = posX4;
            if (posX3 >= 490 && posX4 >= 490)
            {
                posX3 = 490;
                posX4 = 490;
                SensCartaAsciugatura.BackColor = System.Drawing.Color.Lime;
                TbSensAsc.Text = "True";
                Carta3.Visible = false;
                Carta3.Enabled = false;
                Carta4.Visible = false;
                Carta4.Enabled = false;
            }
            TimerUscita.Enabled = true;
        }

        private void TimerUscita_Tick(object sender, EventArgs e)
        {
            if (TbSensAsc.Text.Equals("True"))
            {
                Carta5.Visible = true;
                Carta6.Visible = true;
                posX5 = posX5 + (int)((629 - posX5) * delta3 / durata3);
                Carta5.Left = posX5;
                posY5 = posY5 + (int)((289 - posY5) * delta3 / durata3);
                Carta5.Top = posY5;

                posX6 = posX6 + (int)((570 - posX6) * delta3 / durata3);
                Carta6.Left = posX6;
                posY6 = posY6 + (int)((271 - posY6) * delta3 / durata3);
                Carta6.Top = posY6;
                FineProcesso.BackColor = System.Drawing.Color.Lime;
            }
        }
    }
}