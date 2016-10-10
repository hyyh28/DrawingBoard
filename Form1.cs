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
enum drawtype{arrow,line, ellipse, rectangle, pen};
namespace drawboard
{
    public partial class Form1 : Form
    {
        Point startpoint, endpoint;
        bool isdraw;
        Graphics g;
        drawtype mytype = drawtype.arrow;
        Pen p = new Pen(Color.Black, 1);
        Image picture;
        class Line
        {
            public Line(Pen mypen,Point p1, Point p2)
            {
                start = p1;
                end = p2;
                mycolor = mypen.Color;
                mywidth = mypen.Width;
            }
            public Point start;
            public Point end;
            public Color mycolor;
            public float mywidth;
        }
        class Ellipse
        {
            public Ellipse(Pen mypen,Rectangle rec)
            {
                this.rec = rec;
                mycolor = mypen.Color;
                mywidth = mypen.Width;
            }
            public Rectangle rec;
            public Color mycolor;
            public float mywidth;
        }
        class rectangle
        {
            public rectangle(Pen mypen,Rectangle rec)
            {
                this.rec = rec;
                mycolor = mypen.Color;
                mywidth = mypen.Width;
            }
            public Rectangle rec;
            public Color mycolor;
            public float mywidth;
        }

        List<rectangle> Rectangles = new List<rectangle>();
        List<Ellipse> Ellipses = new List<Ellipse>();
        List<Line> Lines = new List<Line>();
        public Form1()
        {
            InitializeComponent();
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.Round;
            g = db.CreateGraphics();
        }

        private void db_MouseMove(object sender, MouseEventArgs e)
        {
            if (isdraw)
            {
                db.Refresh();
                foreach (Line line in Lines)
                {
                    g.DrawLine(new Pen(line.mycolor,line.mywidth), line.start, line.end);
                }
                foreach (Ellipse ellipse in Ellipses)
                {
                    g.DrawEllipse(new Pen(ellipse.mycolor,ellipse.mywidth),ellipse.rec);
                }
                foreach (rectangle rec in Rectangles)
                {
                    g.DrawRectangle(new Pen(rec.mycolor, rec.mywidth), rec.rec);
                }
                db.BackColor = Color.White;
                if (mytype == drawtype.ellipse)
                {
                    g.DrawEllipse(p, new Rectangle(startpoint.X, startpoint.Y, e.X - startpoint.X, e.Y - startpoint.Y));
                }
                else if(mytype == drawtype.line)
                {
                    g.DrawLine(p, startpoint, new Point(e.X,e.Y));
                }
                else if(mytype == drawtype.rectangle)
                {
                    g.DrawRectangle(p, new Rectangle(startpoint.X, startpoint.Y, e.X - startpoint.X, e.Y - startpoint.Y));
                }
                else if(mytype == drawtype.pen)
                {
                    endpoint = e.Location;
                    g.DrawLine(p, startpoint,endpoint);
                    Lines.Add(new Line(p, startpoint, endpoint));
                    startpoint = endpoint;
                }
            }
        }

        private void db_MouseUp(object sender, MouseEventArgs e)
        {
            db.Refresh();
            //db.BackColor = Color.White;
            endpoint = e.Location;
            if (mytype == drawtype.line)
            {
                Lines.Add(new Line(p,startpoint, endpoint));
            }
            else if (mytype == drawtype.ellipse)
            {
                Ellipses.Add(new Ellipse(p,new Rectangle(startpoint.X, startpoint.Y, endpoint.X - startpoint.X, endpoint.Y - startpoint.Y)));
            }
            else if(mytype == drawtype.rectangle)
            {
                Rectangles.Add(new rectangle(p, new Rectangle(startpoint.X, startpoint.Y, endpoint.X - startpoint.X, endpoint.Y - startpoint.Y)));
            }
            else if(mytype == drawtype.pen)
            {
                Lines.Add(new Line(p, startpoint, endpoint));
            }
            foreach (Line line in Lines)
            {
                g.DrawLine(new Pen(line.mycolor, line.mywidth), line.start, line.end);
            }
            foreach (Ellipse ellipse in Ellipses)
            {
                g.DrawEllipse(new Pen(ellipse.mycolor, ellipse.mywidth), ellipse.rec);
            }
            foreach (rectangle rec in Rectangles)
            {
                g.DrawRectangle(new Pen(rec.mycolor, rec.mywidth), rec.rec);
            }
            isdraw = false;
        }

        private void arrow_Click(object sender, EventArgs e)
        {
            mytype = drawtype.arrow;
        }

        private void line_Click(object sender, EventArgs e)
        {
            mytype = drawtype.line;
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            mytype = drawtype.ellipse;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            mytype = drawtype.arrow;
            Ellipses.Clear();
            Lines.Clear();
            Rectangles.Clear();
            g.Clear(Color.White);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            p.Width = (float)numericUpDown1.Value;
        }

        private void recta_Click(object sender, EventArgs e)
        {
            mytype = drawtype.rectangle;
        }

        private void pencolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            p.Color = colorDialog1.Color;
        }

        private void thepen_Click(object sender, EventArgs e)
        {
            mytype = drawtype.pen;
        }

        private void save_Click_1(object sender, EventArgs e)
        {
            picture = new Bitmap(1920, 1080);
            g = Graphics.FromImage(picture);
            foreach (Line line in Lines)
            {
                g.DrawLine(new Pen(line.mycolor, line.mywidth), line.start, line.end);
            }
            foreach (Ellipse ellipse in Ellipses)
            {
                g.DrawEllipse(new Pen(ellipse.mycolor, ellipse.mywidth), ellipse.rec);
            }
            foreach (rectangle rec in Rectangles)
            {
                g.DrawRectangle(new Pen(rec.mycolor, rec.mywidth), rec.rec);
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg|*.jpg|png|*.png|bmp|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                picture.Save(sfd.FileName);
            }
        }
        private void db_MouseDown(object sender, MouseEventArgs e)
        {
            db.Refresh();
            foreach (Line line in Lines)
            {
                g.DrawLine(new Pen(line.mycolor, line.mywidth), line.start, line.end);
            }
            foreach (Ellipse ellipse in Ellipses)
            {
                g.DrawEllipse(new Pen(ellipse.mycolor, ellipse.mywidth), ellipse.rec);
            }
            foreach (rectangle rec in Rectangles)
            {
                g.DrawRectangle(new Pen(rec.mycolor, rec.mywidth), rec.rec);
            }
            isdraw = true;
            startpoint = e.Location;
        }
    }
}/*代码比较乱而且其实几个图形类之间可以使用继承的，然后在movemouse
事件当中用三个列表存储之前画的内容再在鼠标移动时重画使得画到后面闪得很厉害，
至于保存的问题，我做完了才发现我的graphic是直接在控件上创建的，而不是在db.image上创建的，于是
db.image显示为NULL，这一块不是很明白。。。*/
/*保存功能可以用了，虽然处理方式感觉有点扯。。。*/
