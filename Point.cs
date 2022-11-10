using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
    internal class Point
    {
        private int x,y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Getx()
        {
            return x;
        }
        public void Setx(int x)
        {
            this.x = x;
        }
        public int Gety()
        {
            return y;
        }
        public void Sety(int y)
        {
            this.y = y;
        }
        public int Distance(Point p)
        {
            int a = this.x - p.x;
            int b = this.y - p.y;
            return (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        public bool Equality(Point p)
        {

            return (this.x == p.x && this.y == p.y);
        }
        public void Translate(int t)
        {
            Setx(t * this.x);
            Sety(t * this.y);
        }
        public bool Linearity(Point p, Point q, Point r)
        {
            return ((p.Gety() - q.Gety()) / (p.Getx() - q.Getx())) == ((r.Gety() - q.Gety()) / (r.Getx() - q.Getx()));
        }
    }
}
