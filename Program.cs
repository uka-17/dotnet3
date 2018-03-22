using System;
// comment
// comment 2
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(7, 8);
            rectangle.Perimetr = 2; //вызвали свойство чтоб задать значение value
            Console.WriteLine(rectangle.Perimetr);

            Console.ReadLine();
        }

        public class Rectangle
        {
            int length = 0;
            public int Length
            {
                get { return length; }

                set { length = value; }
            }

            public int Width { get; set; }

            public Rectangle(int length, int width)
            {
                this.length = length;              //this.length - это length,которая int length=0;
                this.width = width;           //this.length приравниваем к length, которая в конструкторе
            }

            int perimetr = 0;
            int width = 0;
            public int Perimetr
            {
                get { return perimetr; }
                set
                {
                    width = value;
                    length = value * 2;
                    perimetr = (width + length) * 2;
                }
            }
        }
    }
}
