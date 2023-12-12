using ProjLeds.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjLeds
{
    public partial class Form1 : Form
    {
        private Leds leds;
        public Form1()
        {
            InitializeComponent();
            leds = new Leds();
            AtualizarEstadoLeds();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            leds.acender(1);
            AtualizarEstadoLeds();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            leds.apagar(1);
            AtualizarEstadoLeds();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            leds.acender(2);
            AtualizarEstadoLeds();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            leds.apagar(2);
            AtualizarEstadoLeds();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            leds.acender(3);
            AtualizarEstadoLeds();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            leds.apagar(3);
            AtualizarEstadoLeds();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            leds.acender(4);
            AtualizarEstadoLeds();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            leds.apagar(4);
            AtualizarEstadoLeds();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            leds.acender(5);
            AtualizarEstadoLeds();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            leds.apagar(5);
            AtualizarEstadoLeds();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            leds.acender(6);
            AtualizarEstadoLeds();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            leds.apagar(6);
            AtualizarEstadoLeds();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            leds.acender(7);
            AtualizarEstadoLeds();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            leds.apagar(7);
            AtualizarEstadoLeds();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            leds.acender(8);
            AtualizarEstadoLeds();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            leds.apagar(8);
            AtualizarEstadoLeds();
        }

        ///Atualizar interface

        private void AtualizarEstadoLeds()
        {
            label9.Text = leds.getEstado().ToString();

            checkBox1.Checked = (leds.getEstado(1) ? true : false);

            checkBox2.Checked = (leds.getEstado(2) ? true : false);

            checkBox3.Checked = (leds.getEstado(3) ? true : false);

            checkBox4.Checked = (leds.getEstado(4) ? true : false);

            checkBox5.Checked = (leds.getEstado(5) ? true : false);

            checkBox6.Checked = (leds.getEstado(6) ? true : false);

            checkBox7.Checked = (leds.getEstado(7) ? true : false);

            checkBox8.Checked = (leds.getEstado(8) ? true : false);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int x;

            x = int.Parse(textBox1.Text);
            
                bool estado = leds.getEstado(x);

                if (estado)
                {
                    label11.Text = "Aceso";
                }
                else
                {
                    label11.Text = "Apagado";
                }
            }
        }
    }

   

    


       