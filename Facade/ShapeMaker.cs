using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    class ShapeMaker
    {
        private List<IShape> shapes = new List<IShape>();

        public ShapeMaker()
        {
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
        }

        public void Draw()
        {
            foreach (IShape s in shapes)
                s.Draw();
        }
    }

    interface IShape
    {
        void Draw();
    }

    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Circle.");
        }
    }

    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Rectangle.");
        }
    }
}
