using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AbstractClassAssignment
{
    abstract class Quadrilateral
    {
        int length;
        public Quadrilateral()
        {}
        public Quadrilateral(int _length)
        {
            length = _length;
        }
        public int CalArea()
        {
            return length * length;
        }
        public abstract void Area();
    }
    class Square : Quadrilateral
    {
        public Square()
        { }
        public Square(int _len):base(_len)
        {
           
        }
        public override void Area()
        {
            
        }
    }
    class Rectangle : Quadrilateral
    {
        int breadth;
        int len;
        bool isSquare;
        public bool IsSquare
        {
            get { return isSquare; }
            set { isSquare = value; }
            
        }
        public Rectangle()
        { }
        public Rectangle(int _breadth,int _len)
        {
            breadth = _breadth;
            len = _len;
        }
        public int calAreaRec()
        {
            return breadth * len;
        }
        public override void Area()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral qua = new Square(4);
            Console.WriteLine("Area of square is-----------");
            Console.WriteLine(qua.CalArea());
            Rectangle rec = new Rectangle(5, 6);
            Console.WriteLine("Area of Rectangle is---------");
            Console.WriteLine(rec.calAreaRec());
            if (qua.CalArea() > rec.calAreaRec())
            {
                Console.WriteLine("Square area is greater than Rectangle");
            }
            else
            {
                Console.WriteLine("Rectangle area is greater than Square");
            }
            Console.ReadLine();
            
        }
    }
}
