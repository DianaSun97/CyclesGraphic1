using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyclesGraphic1
{
    public partial class Form1 : Form
    {
        //Инструменты для рисования
        public Graphics g;
        public Pen pen;
        
        //Конструктор
        public Form1()
        {
            InitializeComponent();
            InitGraph();
        }

        void InitGraph()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            //Отображение на экране
            picture.Image = bmp;
            g = Graphics.FromImage(picture.Image);
            pen = new Pen(Color.Red);
            g.DrawLine(pen,0,0,600,600);
            
        }

      

        //привязка к кнопке
        private void picture_Click(object sender, EventArgs e)
        {
            
        }

        private void butt_Click(object sender, EventArgs e)
        {
            
            //написание координат с помощью цикла
            for (int y = 0; y <=600; y+=10)
            {
                g.DrawLine(pen,0,y,600,y);
                picture.Refresh();
            }
            
             //ручное написание координат 
            // g.DrawLine(pen,0,0,600,0);
            // g.DrawLine(pen,0,10,600,10);
            // g.DrawLine(pen,0,20,600,20);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //очистка после рефреша
            g.Clear(Color.White);
            picture.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 0; x<=600; x+=10)
            {
                pen = new Pen(Color.DarkOrchid);
                g.DrawLine(pen,x,600,x,0);
                picture.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.OrangeRed);
            
            for (int a = 0; a<=600; a+=10)
            {
                g.DrawLine(pen,a,0,0,a);
                picture.Refresh();
            }
            
            pen = new Pen(Color.Chartreuse);
            
            for (int a = 0; a<=600; a+=10)
            {
                g.DrawLine(pen,a,600,600,a);
                picture.Refresh();
            }
            
           
        }
    }
}