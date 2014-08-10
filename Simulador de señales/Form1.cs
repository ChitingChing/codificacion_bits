using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_señales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public Graphics dibujar;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {               
                    if (c is PictureBox)
                    {
                        c.Refresh();
                        dibujar = c.CreateGraphics();
                        dibujarFondo(c.Width);
                    }                
            }            
            string[] bits = new string[textBox1.TextLength];
            bits =textBox1.Text.Split(' ');
            dibujarSeñalOriginal(bits);
            dibujarNRZ(bits);
            dibujarNRZI(bits);
            dibujarM(bits);
            dibujarMD(bits);
        }
        private void dibujarFondo(int ancho) {
            Font myfuente = new Font("Arial", 10);
            Pen myPen = new Pen(Color.Black, 1);
            myPen.DashStyle = DashStyle.Dash;
            dibujar.DrawLine(Pens.Black, 0, 30, 600, 30);
            for (int i = 0; i <= (ancho / 20); i++)
            {
                dibujar.DrawLine(myPen, 10 + i * 20, 0, 10 + i * 20,60);
            }
            dibujar.DrawString("+", myfuente, Brushes.Black, 0, 0);
            dibujar.DrawString("-", myfuente, Brushes.Black, 0, 40);
        }
        private void dibujarSeñalOriginal(string[] Bits ) {
            
            dibujar = pctSeñalOriginal.CreateGraphics();
            for (int i = 0; i <= Bits.GetUpperBound(0); i++)
            {
                if (Bits[i] == "1")
                {
                    dibujar.DrawLine(Pens.Red, 10+i*20, 10, 30+i*20, 10);
                    if (i != 0 && Bits[i - 1] == "0") 
                    {
                        dibujar.DrawLine(Pens.Red, 10 + i * 20, 30, 10 + i * 20, 10);
                    }
                }else if(Bits[i]=="0")
                {                     
                    dibujar.DrawLine(Pens.Red, 10+i*20, 30, 30+i*20, 30);
                    if (i != 0 && Bits[i-1]=="1")
                    {
                        dibujar.DrawLine(Pens.Red, 10 + i * 20, 30, 10 + i * 20, 10);
                    }
                }
                
            }
        }
        private void dibujarMD(string[] Bits) 
        {
            dibujar = pctManchesterD.CreateGraphics();
            bool cambio=false;
            for (int i = 0; i <= Bits.GetUpperBound(0); i++)
            {
                if (i == 0)
                {
                    if (Bits[i] == "0")
                    {
                        abajoArriba(i);
                    }
                    else if(Bits[i]=="1")
                    {
                        arribaAbajo(i);
                        cambio = true;
                    }
                }
                else
                {
                    if (Bits[i] == "1")
                    {
                        if (Bits[i - 1] == "1")
                        {
                            if (cambio == false)
                            {
                                arribaAbajo(i);                                
                                cambio = true;
                            }
                            else
                            {                                
                                abajoArriba(i);
                                cambio = false;
                            }
                        }
                        else if (Bits[i - 1] == "0")
                        {
                            if (cambio == false)
                            {
                                arribaAbajo(i);                                 
                                cambio = true;
                            }
                            else
                            {
                                abajoArriba(i);                                
                                cambio = false;
                            }
                        }                      
                        
                    }
                    else if (Bits[i] == "0")
                    {
                        if (cambio == false)
                        {
                            abajoArriba(i);
                            dibujar.DrawLine(Pens.Red, 10 + i * 20, 10, 10 + i * 20, 50);
                        }
                        else
                        {
                            arribaAbajo(i);
                            dibujar.DrawLine(Pens.Red, 10 + i * 20, 10, 10 + i * 20, 50);    
                        }
                    }
                }

            }      
        }
        private void dibujarM(string[] Bits)
        {
            dibujar = pctManchester.CreateGraphics();
            for (int i = 0; i <= Bits.GetUpperBound(0); i++)
            {
               if (Bits[i] == "1")                
               {
                   arribaAbajo(i);                             
                   if (i != 0 && Bits[i - 1] == "1")
                   {
                        dibujar.DrawLine(Pens.Red, 10 + i * 20, 50, 10 + i * 20, 10);
                   }
               }
                else if (Bits[i] == "0")
                {
                    abajoArriba(i);
                   if (i != 0 && Bits[i - 1] == "0")
                   {
                        dibujar.DrawLine(Pens.Red, 10 + i * 20, 50, 10 + i * 20, 10);
                    }
               }

            }
        }
        private void dibujarNRZ(string[] Bits)
        {
            dibujar = pctNRZ.CreateGraphics();
            for (int i = 0; i <= Bits.GetUpperBound(0); i++)
            {
                if (Bits[i] == "1")
                {
                    dibujar.DrawLine(Pens.Red, 10 + i * 20, 10, 30 + i * 20, 10);
                    if (i != 0 && Bits[i - 1] == "0")
                    {
                        dibujar.DrawLine(Pens.Red, 10 + i * 20, 50, 10 + i * 20, 10);
                    }
                }
                else if (Bits[i] == "0")
                {
                    dibujar.DrawLine(Pens.Red, 10 + i * 20, 50, 30 + i * 20, 50);
                    if (i != 0 && Bits[i - 1] == "1")
                    {
                        dibujar.DrawLine(Pens.Red, 10 + i * 20, 50, 10 + i * 20, 10);
                    }
                }

            }
        }
        private void dibujarNRZI(string[] Bits)
        {
            string cambio = "arriba";
            dibujar = pctNRZI.CreateGraphics();
            if (Bits[0] == "0")
            {
                dibujar.DrawLine(Pens.Red, 10 , 50, 30 , 50); 
                for (int i = 1; i <= Bits.GetUpperBound(0); i++)
                {
                    if (Bits[i] == "1")
                    {
                        if (cambio == "arriba")
                        {
                            dibujar.DrawLine(Pens.Red, 10 + i * 20, 10, 30 + i * 20, 10);
                            dibujar.DrawLine(Pens.Red, 10 + i * 20, 50, 10 + i * 20, 10);
                            cambio = "abajo";
                        }
                        else 
                        {
                            dibujar.DrawLine(Pens.Red, 10 + i * 20, 50, 30 + i * 20, 50);
                            dibujar.DrawLine(Pens.Red, 10 + i * 20, 50, 10 + i * 20, 10);
                            cambio = "arriba";
                        }
                                               
                    }
                    else if (Bits[i] == "0")
                    {
                        if (cambio == "arriba")
                        {
                            //se dibuja abajo ya que el ultimo cambio fue abajo
                            dibujar.DrawLine(Pens.Red, 10 + i * 20, 50, 30 + i * 20, 50);
                            
                        }
                        else 
                        {
                            //se dibuja arriba ya que el ultimo cambio fue arriba
                            dibujar.DrawLine(Pens.Red, 10 + i * 20, 10, 30 + i * 20, 10);
                            
                        }
                        
                    }

                }
            }
            else 
            {
                MessageBox.Show("Para graficar NRZI la cedena de bits debe empezar por un 0");
            }
        }
        private void abajoArriba(int i) 
        {
            dibujar.DrawLine(Pens.Red, 10 + i * 20, 50, 20 + i * 20, 50);
            dibujar.DrawLine(Pens.Red, 20 + i * 20, 10, 20 + i * 20, 50);
            dibujar.DrawLine(Pens.Red, 20 + i * 20, 10, 30 + i * 20, 10);
        }
        private void arribaAbajo(int i) 
        {
            dibujar.DrawLine(Pens.Red, 10 + i * 20, 10, 20 + i * 20, 10);
            dibujar.DrawLine(Pens.Red, 20 + i * 20, 10, 20 + i * 20, 50);
            dibujar.DrawLine(Pens.Red, 20 + i * 20, 50, 30 + i * 20, 50);      
        }
    }
}
