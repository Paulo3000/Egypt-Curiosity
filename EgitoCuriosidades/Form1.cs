using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Globalization;
using System.IO;
using System.Media;


namespace EgitoCuriosidades
{
    
    public partial class Form1 : Form
        
    {
        private SoundPlayer sound = new SoundPlayer(@"C:\Users\1988p\Desktop\programação\EgitoCuriosidades\projeto36\musicas\theme2.wav");
        SpeechSynthesizer resposta = new SpeechSynthesizer();
        List<string> testo_egito = new List<string>();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Parent = fundo;
            pictureBox1.BackColor = Color.Transparent;
            sound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
        private void desliga()
        {
            doly.Visible = false;
            beard.Visible = false;
            cats.Visible = false;
            persas.Visible = false;
        }
        private void liga()
        {
            doly.Visible = true;
            beard.Visible = true;
            cats.Visible = true;
            persas.Visible = true;
        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            desliga();
            fundo.Load(@"C:\Users\1988p\Desktop\programação\EgitoCuriosidades\projeto36\fotos\2.jpg");
            using (StreamReader ler = new StreamReader(@"C:\Users\1988p\Desktop\programação\EgitoCuriosidades\projeto36\testos\gatoDoEgito.txt"))
            {
                string linha = ler.ReadLine();
                string[] valor = linha.Split('*');
                testo_egito.Add(valor[0]);
                foreach (var item in valor)
                {
                    resposta.SpeakAsync(item);
                }
            }

        }

        private void doly_Click(object sender, EventArgs e)
        {
            desliga();
            fundo.Load(@"C:\Users\1988p\Desktop\programação\EgitoCuriosidades\projeto36\fotos\3d.jpg");
            using (StreamReader ler = new StreamReader(@"C:\Users\1988p\Desktop\programação\EgitoCuriosidades\projeto36\testos\boneca.txt"))
            {
                string linha = ler.ReadLine();
                string[] valor = linha.Split('*');
                testo_egito.Add(valor[0]);
                foreach (var item in valor)
                {
                    resposta.SpeakAsync(item);
                }
            }
        }

        private void beard_Click(object sender, EventArgs e)
        {
            desliga();
            fundo.Load(@"C:\Users\1988p\Desktop\programação\EgitoCuriosidades\projeto36\fotos\3b.jpg");
            using (StreamReader ler =new StreamReader(@"C:\Users\1988p\Desktop\programação\EgitoCuriosidades\projeto36\textos\boneca.txt"))
            {
                string linha = ler.ReadLine();
                string[] valor = linha.Split('*');
                testo_egito.Add(valor[0]);
                foreach (var item in valor)
                {
                    resposta.SpeakAsync(item);
                }
            }
            

        }

        private void persas_Click(object sender, EventArgs e)
        {
            desliga();
            fundo.Load(@"C:\Users\1988p\Desktop\programação\EgitoCuriosidades\projeto36\fotos\3f.jpg");
            using (StreamReader ler = new StreamReader(@"C:\Users\1988p\Desktop\programação\EgitoCuriosidades\projeto36\textos\persas.txt"))
            {
                string linha = ler.ReadLine();
                string[] valor = linha.Split('*');
                testo_egito.Add(valor[0]);
                foreach (var item in valor)
                {
                    resposta.SpeakAsync(item);
                }
            }
        }

        private void fundo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            liga();
            fundo.Load(@"C:\Users\1988p\Desktop\programação\EgitoCuriosidades\projeto36\fotos\3a.jpeg");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("você ciclou no bico da piramide do meio");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=ebm-fLo9-NA");
        }
    }
}
