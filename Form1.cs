using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba2Visual_programming
{
    public partial class Form1 : Form
    {
        int NumberOfDots = 0; 
        bool IsClicked = false;
        int X = 0;
        int Y = 0;

        int X1 = 0;
        int Y1 = 0;
        double k = 1;
        int X_1 ; int Y_1;
        int X_2 ; int Y_2;
        int X_3 ; int Y_3;

        double Y_peretun12 = 0;
        double X_peretun12 = 0;
        Graphics formGraphics;
        GraphicsPath kontur = new GraphicsPath();

        public Form1()
        {
            InitializeComponent();
             formGraphics = this.CreateGraphics();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Paint_window(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            
        }
        private void Mouse_move(object sender, MouseEventArgs e)
        {             
             //  int CursorX = Cursor.Position.X;
             //  int CursorY = Cursor.Position.Y;
             //  textBox1.Text ="X: "+ e.X.ToString() + "   Y: " + e.Y.ToString();// для того що за межами області малювати
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_mouseDown(object sender, MouseEventArgs e)
        {
            IsClicked = true;
            if (NumberOfDots == 2)
            {
                IsClicked = true;
                textBox6.Text = null;
                textBox7.Text = null;
                X = e.X;
                Y = e.Y;
                //   MessageBox.Show(string.Format("X:{0} Y: {1}",X,Y ));
                textBox6.Text += X;
                textBox7.Text += Y;
                NumberOfDots++;
            }
            if (NumberOfDots == 1)
            {
                IsClicked = true;
                textBox4.Text = null;
                textBox5.Text = null;
                X = e.X;
                Y = e.Y;
                //   MessageBox.Show(string.Format("X:{0} Y: {1}",X,Y ));
                textBox4.Text += X;
                textBox5.Text += Y;
                NumberOfDots++;
            }
            else if (NumberOfDots == 0)
            {
                IsClicked = true;
                textBox2.Text = null;
                textBox3.Text = null;
                X = e.X;
                Y = e.Y;
                //   MessageBox.Show(string.Format("X:{0} Y: {1}",X,Y ));
                textBox2.Text += X;
                textBox3.Text += Y;
                NumberOfDots++;
            }

        }
        private void pictureBox1_mouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked) 
            {
                X1 = e.X;
                Y1 = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_mouseUp(object sender, MouseEventArgs e)
        {
          //  IsClicked = false;//поставлення точки тільки разом з рухом курсора

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)

        {
           
            SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            Pen pen = new Pen(Color.Black);
           // парсити з текстбоксів
       
         //   X = int.Parse(textBox2.Text);
         //   Y = int.Parse(textBox3.Text);    
            
        double intensity1 = double.Parse(textBox1.Text);
        double intensity2 = double.Parse(textBox8.Text);
        double intensity3 = double.Parse(textBox9.Text);
        double r1 =Convert.ToDouble( Math.Sqrt(k/ intensity1));
        double r2 = Convert.ToDouble(Math.Sqrt(k/ intensity2));
        double r3 = Convert.ToDouble(Math.Sqrt(k/ intensity3));
        //e.Graphics.FillEllipse(Brushes.Yellow, X, Y, r1, r1);
        
      //  if (NumberOfDots == 2) { int X_2 = X; int Y_2 = Y; }
       // if (NumberOfDots == 3) { int X_3 = X; int Y_3 = Y; }
            if (IsClicked == true)
            {
               Color brushColor = Color.FromArgb(250 / 100 * 55, 234, 234, 0);
               System.Drawing.Brush brush = new SolidBrush(brushColor);
               if (NumberOfDots == 1) { X_1 = X; Y_1 = Y; e.Graphics.FillEllipse(brush, (float)(X_1 - (r1 / 2)), (float)(Y_1 - r1 / 2), (float)r1, (float)r1);
               Rectangle rect_1 = new Rectangle(X_1 - 4, Y_1 - 4, 7, 7); e.Graphics.FillEllipse(myBrush, rect_1);
               }

               if (NumberOfDots == 2) { X_2 = X; Y_2 = Y; e.Graphics.FillEllipse(brush, (float)(X_2 - (r2 / 2)), (float)(Y_2 - r2 / 2), (float)r2, (float)r2); e.Graphics.FillEllipse(brush, (float)(X_1 - (r1 / 2)), (float)(Y_1 - r1 / 2), (float)r1, (float)r1);
               Rectangle rect_2 = new Rectangle(X_2 - 4, Y_2 - 4, 7, 7); e.Graphics.FillEllipse(myBrush, rect_2);
               Rectangle rect_1 = new Rectangle(X_1 - 4, Y_1 - 4, 7, 7); e.Graphics.FillEllipse(myBrush, rect_1);
               }


               if (NumberOfDots == 3) { X_3 = X; Y_3 = Y; e.Graphics.FillEllipse(brush, (float)(X_3 - (r3 / 2)), (float)(Y_3 - r3 / 2), (float)r3, (float)r3); e.Graphics.FillEllipse(brush, (float)(X_1 - (r1 / 2)), (float)(Y_1 - r1 / 2), (float)r1, (float)r1); e.Graphics.FillEllipse(brush, (float)(X_2 - (r2 / 2)), (float)(Y_2 - r2 / 2), (float)r2, (float)r2);
               Rectangle rect_3 = new Rectangle(X_3 - 4, Y_3 - 4, 7, 7); e.Graphics.FillEllipse(myBrush, rect_3);
               Rectangle rect_2 = new Rectangle(X_2 - 4, Y_2 - 4, 7, 7); e.Graphics.FillEllipse(myBrush, rect_2);
               Rectangle rect_1 = new Rectangle(X_1 - 4, Y_1 - 4, 7, 7); e.Graphics.FillEllipse(myBrush, rect_1);
               }
                //ТУТ малюється радіус навколо станції
                Rectangle rect = new Rectangle(X-4, Y-4, 7, 7);
                //радіус самої станції
                e.Graphics.FillEllipse(myBrush, rect);
                e.Graphics.DrawPath(pen, kontur);
               kontur.AddEllipse(rect);
               
              // myBrush.Dispose();//вивільняємо ресурси
            }
           
            //MessageBox.Show("radius3", intensity3.ToString());
        }
        void get_last_points(object sender, EventArgs e)
        {
            MessageBox.Show("АНАЛІТИЧНІ ТОЧКИ");
            bool normalno=false;
            while (normalno == false)
            {k=k+0.0000001;
                
                double intensity1 = double.Parse(textBox1.Text);
                double intensity2 = double.Parse(textBox8.Text);
                double intensity3 = double.Parse(textBox9.Text);
                double r1 = Convert.ToDouble(Math.Sqrt(k / intensity1));
                double r2 = Convert.ToDouble(Math.Sqrt(k / intensity2));
                double r3 = Convert.ToDouble(Math.Sqrt(k / intensity3));

                double A = -(-2 * Y_1 + 2 * Y_2);
                double B = (r2 * r2 - r3 * r3 - X_2 * X_2 + X_3 * X_3 - Y_2 * Y_2 + Y_3 * Y_3);
                double C = (-1) * (r1 * r1 - r2 * r2 + X_1 * X_1 + X_2 * X_2 - Y_1 * Y_1 + Y_2 * Y_2) * (-2 * X_2 + 2 * X_2) / (-2 * Y_1 + 2 * Y_2);

                //double A = (-1) * (-2 * Y_2 + 2 * Y_3);
                //double B = (r2 * r2 - r3 * r3 - X_2 * X_2 + X_3 * X_3 - Y_2 * Y_2 + Y_3 * Y_3);
              //  double C = (-1)*(r1 * r1 - r2 * r2 + X_1 * X_1 + X_2 * X_2 - Y_1 * Y_1 + Y_2 * Y_2) * (-2 * X_2 + 2 * X_3) / (-2 * Y_1 + 2 * Y_2);
                double sqrtD = Math.Sqrt(B*B - 4 * A * C);
                double Y_y1 = (-B + sqrtD) / 2 * A;
                double Y_y2 = (-B - sqrtD) / 2 * A;
                pictureBox1.Invalidate();
                if (Y_y1 > Y_y2 && Y_y1 > 0)
                {
                    double X_last = (r1 * r1 - r2 * r2 - X_1 * X_1 + X_2 * X_2 - Y_1 * Y_1 + Y_2 * Y_2) / Y_y1 * (-2 * Y_1 + 2 * Y_2);
                 //  if (X_last>Math.Min(X_3,(Math.Min(X_1,X_2))))
                       MessageBox.Show("y= "+Y_y1.ToString() , "x= "+X_last.ToString());
                 if (Y_y1 > 100.0 && X_last > 100.0) normalno = true;
 

                }
                else if (Y_y2 > Y_y1 && Y_y2 > 0)
                {  double X_last2 = (r1 * r1 - r2 * r2 - X_1 * X_1 + X_2 * X_2 - Y_1 * Y_1 + Y_2 * Y_2) / Y_y2 * (-2 * Y_1 + 2 * Y_2);
                MessageBox.Show("y= "+Y_y2.ToString() , X_last2.ToString());
                if (Y_y2 > 100 && X_last2 > 100) normalno = true;
                }
               
           }
        }

        void get_points_of_intersection(double x10 , double y10, double r1,//координаты центра и радиус
                        double x20,double y20,double r2 ) //возвращаем результаты
{
    double x0,y0;//координаты точки пересечения всех линий

    double d;//расстояние между центрами окружностей
    double a;//расстояние от r1 до точки пересечения всех линий
    double h;//расстояние от точки пересеч окружностей до точки пересеч всех линий
    x10 = int.Parse(textBox2.Text);
    y10=  int.Parse(textBox3.Text);
    x20 = int.Parse(textBox4.Text);
    y20 = int.Parse(textBox5.Text);
    
    d = Math.Sqrt(Math.Pow(Math.Abs(x10 - x20), 2) + Math.Pow(Math.Abs(y10 - y20), 2));
    if(d > r1+r2) MessageBox.Show("нема перетину"); //окружности не пересекаются

    a= (r1*r1 - r2*r2 + d*d ) / (2*d);
    h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(a, 2));


    x0 = x10 + a*( x20 - x10 ) / d;
    y0 = y10 + a*( y20 - y10 ) / d;

    double x1= x0 + h*( y20 - y10 ) / d;
    double y1=  y0 - h*( x20 - x10 ) / d;
    y1 = Math.Abs(y1);
    if (a == r1) MessageBox.Show("дотикаються"); //окружности соприкасаются

    double x2= x0 - h*( y20 - y10 ) / d;
    double y2= y0 + h*( x20 - x10 ) / d;
    y2 = Math.Abs(y2);
    MessageBox.Show("x2=" + x2.ToString() + " y2=" + y2.ToString()+"\n"+"x1=" + x1.ToString() + " y1=" + y1.ToString(), "Coordinates");
    double intensity3 = double.Parse(textBox9.Text);
    double r3 = Convert.ToInt32(Math.Sqrt(k / intensity3));

    if (Math.Sqrt(Math.Pow((double.Parse(textBox6.Text) - x2), 2) + Math.Pow((double.Parse(textBox7.Text) - y2), 2)) == r3)
    {
        MessageBox.Show("x=" + x2.ToString() + ";y=" + y2.ToString(), "координати абонента:");
        textBox10.Text = x2.ToString();
        textBox11.Text = y2.ToString();
    }
    if (Math.Sqrt(Math.Pow((double.Parse(textBox6.Text) - x1), 2) + Math.Pow((double.Parse(textBox7.Text) - y1), 2)) == r3)
    {
        MessageBox.Show("x=" + x1.ToString() + ";y=" + y1.ToString(), "координати абонента:");
        textBox10.Text = x1.ToString();
        textBox11.Text = y1.ToString();
    } if (Math.Sqrt(Math.Pow((double.Parse(textBox6.Text) - x2), 2) + Math.Pow((double.Parse(textBox7.Text) - y2), 2)) < Math.Sqrt(Math.Pow((double.Parse(textBox6.Text) - x1), 2) + Math.Pow((double.Parse(textBox7.Text) - y1), 2)))
    {
        textBox10.Text = x2.ToString();
        y2 = Math.Abs(y2);
        textBox11.Text = y2.ToString();
        Y_peretun12 = y2;
        X_peretun12 = x2;
    }
    else 
        textBox10.Text = x1.ToString();
    y1 = Math.Abs(y1);
    textBox11.Text = y1.ToString();
    Y_peretun12 = y1;
    X_peretun12 = x1;

   // if (d < r1 + r2) MessageBox.Show("перетин");//окружности пересекаются

}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double intensity1 = double.Parse(textBox1.Text);
            double intensity2 = double.Parse(textBox8.Text);
            double intensity3 = double.Parse(textBox9.Text);
            double r1 = Convert.ToDouble(Math.Sqrt(k / intensity1));
            double r2 = Convert.ToDouble(Math.Sqrt(k / intensity2));
            double r3 = Convert.ToDouble(Math.Sqrt(k / intensity3));
            get_points_of_intersection(0, 0, r1, 0, 0, r2); NumberOfDots = 1000; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void TextBox8TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void TextBox9TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
         //double z1 = double.Parse(textBox1.Text);
         //double z2 = double.Parse(textBox8.Text);
         //double z3 = double.Parse(textBox9.Text);
         //
         // z1= z1 /trackBar1.Value;
         //  z2=z2 /trackBar1.Value;
         //  z3=z3 /trackBar1.Value;
         //  textBox1.Text = z1.ToString();
         //  textBox8.Text = z2.ToString();
         //  textBox9.Text = z3.ToString();

            k = trackBar1.Value;
            pictureBox1.Invalidate();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            pictureBox1.Invalidate();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void zooming(object sender, EventArgs e)
        {

           double intensity1 = double.Parse(textBox1.Text);
           double intensity2 = double.Parse(textBox8.Text);
           double intensity3 = double.Parse(textBox9.Text);
           double r1 = Convert.ToDouble(Math.Sqrt(k / intensity1));
           double r2 = Convert.ToDouble(Math.Sqrt(k / intensity2));
           double r3 = Convert.ToDouble(Math.Sqrt(k / intensity3));
              double distance = Math.Sqrt( Math.Pow((X_1 - X_2), 2) + Math.Pow((Y_1 - Y_2), 2) );
               while(distance>r1/2+r2/2)
         {  
           k=k+0.1;
        r1 = Convert.ToDouble(Math.Sqrt(k / intensity1));
        r2 = Convert.ToDouble(Math.Sqrt(k / intensity2));
             pictureBox1.Invalidate();
             double x0, y0;//координаты точки пересечения всех линий
             double d;//расстояние между центрами окружностей
             double a;//расстояние от r1 до точки пересечения всех линий
             double h;//расстояние от точки пересеч окружностей до точки пересеч всех линий
             double x10 = int.Parse(textBox2.Text);
             double y10 = int.Parse(textBox3.Text);
             double x20 = int.Parse(textBox4.Text);
             double y20 = int.Parse(textBox5.Text);

             d = Math.Sqrt(Math.Pow(Math.Abs(x10 - x20), 2) + Math.Pow(Math.Abs(y10 - y20), 2));
             a = (r1 * r1 - r2 * r2 + d * d) / (2 * d);
             h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(a, 2));
             x0 = x10 + a * (x20 - x10) / d;
             y0 = y10 + a * (y20 - y10) / d;

             double x1 = x0 + h * (y20 - y10) / d;
             double y1 = y0 - h * (x20 - x10) / d;
             y1 = Math.Abs(y1);
             double x2 = x0 - h * (y20 - y10) / d;
             double y2 = y0 + h * (x20 - x10) / d;
             y2 = Math.Abs(y2);
             intensity3 = double.Parse(textBox9.Text);
             r3 = Convert.ToInt32(Math.Sqrt(k / intensity3));
             if (Math.Sqrt(Math.Pow((double.Parse(textBox6.Text) - x2), 2) + Math.Pow((double.Parse(textBox7.Text) - y2), 2)) < Math.Sqrt(Math.Pow((double.Parse(textBox6.Text) - x1), 2) + Math.Pow((double.Parse(textBox7.Text) - y1), 2)))
             {
                 y2 = Math.Abs(y2);
                 Y_peretun12 = y2;
                 X_peretun12 = x2;
             }
             else
                 y1 = Math.Abs(y1);
             Y_peretun12 = y1;
             X_peretun12 = x1;
         }
               MessageBox.Show("step2");
    
    double  distnce_to_3_intersections=Math.Sqrt( Math.Pow((X_3 - X_peretun12), 2) + Math.Pow((Y_3 - Y_peretun12), 2) );
     while(r3/2 < distnce_to_3_intersections)
     { 
      k = k + 1;
      r1 = Convert.ToDouble(Math.Sqrt(k / intensity1));
      r2 = Convert.ToDouble(Math.Sqrt(k / intensity2));
      r2 = Convert.ToDouble(Math.Sqrt(k / intensity2));

         double x0, y0;//координаты точки пересечения всех линий
         double d;//расстояние между центрами окружностей
         double a;//расстояние от r1 до точки пересечения всех линий
         double h;//расстояние от точки пересеч окружностей до точки пересеч всех линий
     double  x10 = int.Parse(textBox2.Text);
     double  y10 = int.Parse(textBox3.Text);
     double  x20 = int.Parse(textBox4.Text);
     double  y20 = int.Parse(textBox5.Text);

         d = Math.Sqrt(Math.Pow(Math.Abs(x10 - x20), 2) + Math.Pow(Math.Abs(y10 - y20), 2));
         a = (r1 * r1 - r2 * r2 + d * d) / (2 * d);
         h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(a, 2));
         x0 = x10 + a * (x20 - x10) / d;
         y0 = y10 + a * (y20 - y10) / d;

         double x1 = x0 + h * (y20 - y10) / d;
         double y1 = y0 - h * (x20 - x10) / d;
         y1 = Math.Abs(y1);
         double x2 = x0 - h * (y20 - y10) / d;
         double y2 = y0 + h * (x20 - x10) / d;
         y2 = Math.Abs(y2);
          intensity3 = double.Parse(textBox9.Text);
          r3 = Convert.ToInt32(Math.Sqrt(k / intensity3));
          if (Math.Sqrt(Math.Pow((double.Parse(textBox6.Text) - x2), 2) + Math.Pow((double.Parse(textBox7.Text) - y2), 2)) < Math.Sqrt(Math.Pow((double.Parse(textBox6.Text) - x1), 2) + Math.Pow((double.Parse(textBox7.Text) - y1), 2)))
          {


              y2 = Math.Abs(y2);

              Y_peretun12 = y2;
              X_peretun12 = x2;
              distnce_to_3_intersections = Math.Sqrt(Math.Pow((X_3 - X_peretun12), 2) + Math.Pow((Y_3 - Y_peretun12), 2));
              pictureBox1.Invalidate();
          }
          else
          {
              y1 = Math.Abs(y1);

              Y_peretun12 = y1;
              X_peretun12 = x1;

              distnce_to_3_intersections = Math.Sqrt(Math.Pow((X_3 - X_peretun12), 2) + Math.Pow((Y_3 - Y_peretun12), 2));
              pictureBox1.Invalidate();
          }
   }

        
        }

        private void unzooming(object sender, EventArgs e)
        {
            k--;
            pictureBox1.Invalidate();
        }

        private void get_analitics(object sender, MouseEventArgs e)
        {
            
            get_last_points();
           
        }

        private void get_last_points()
        {

        }
    }

}
