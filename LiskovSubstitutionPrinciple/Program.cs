

/* LiskovSubstitutionPrinciple--> This principle ensures that any class that is child of parent class should usuable in place of its 
                                  parent without any unexpected behaviour.
                                or
 Derived or child classed muste be substituable for their base or parent classes.

ex=> Rectangle having four sides. A rectangle's height can be any value and width can be any value. A square is a rectangle with equal width and height. So we can say that we can
extend the properties of the rectangle class into square class.
 
 */

using System;

namespace LiskovSubstitutionPrinciple
{
    class Rectangle
    {
        protected double width;
        protected double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public virtual double Area()
        {
            return width * height;
        }
        public double getWidth()
        {
            return width;
        }
        public double getHeight()
        {
            return height;
        }
        public virtual void setWidth(double width)
        {
            this.width = width;
        }
        public virtual void setHeight(double height)
        {
            this.height = height;
        }

    }
    class Square : Rectangle
    {
        public Square(double size) : base(size, size) { }
        public override void setWidth(double width)
        {
            width = height = width;
        }
        public override void setHeight(double height)
        {
            this.setHeight(height);
        }

    }
     class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 10);
            Console.WriteLine($"Rectangle Area : {rect.Area()}");

            Rectangle square = new Square(5);
            Console.WriteLine($"Square Area: {square.Area()}");

            square.setWidth(10);
            Console.WriteLine($"update square area: {square.Area()}");
            Console.ReadLine();
        }
    }
}
