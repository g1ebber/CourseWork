using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseWork
{
    public class Rectangle
    {
        private
        int ID;
        double length, width, S, P;
        string color, name;
        static int IDcounter = 0;

        public
        //Перегруженный конструктор
        Rectangle(double initLength, double initWidth, string initColor, string initName)
        {
            ID = IDcounter;
            IDcounter++;
            name = initName;
            length = initLength;
            width = initWidth;
            color = initColor;
            S = length * width;
            P = (length + width) * 2;
        }

        Rectangle(double initLength, double initWidth, string initName)
        {
            ID = IDcounter;
            IDcounter++;
            name = initName;
            length = initLength;
            width = initWidth;
            color = "No data";
            S = length * width;
            P = (length + width) * 2;
        }

        Rectangle()
        {
            name = "unknown";
            length = 0;
            width = 0;
            color = "No data";
            S = 0;
            P = 0;
        }
        public string getName()
        {
            return name;
        }

        public int getID()
        {
            return ID;
        }


        //Метод для получения данных
        public double getLength()
        {
            return length;
        }

        public double getWidth()
        {
            return width;
        }

        public string getColor()
        {
            return color;
        }


        // Площадь
        public double area()
        {
            return S;
        }


        //Периметр
        public double perimeter()
        {
            return P;
        }


        //Перегруженный метод изменения характеристик
        void setProperty(double a, double b)
        {
            double oldLength = length;
            double oldWidth = width;
            length = a;
            width = b;
            S = length * width;
            P = (length + width) * 2;
        }

        void setProperty(double a, double b, string c)
        {
            double oldLength = length;
            double oldWidth = width;
            length = a;
            width = b;
            color = c;
            S = length * width;
            P = (length + width) * 2;
        }


        //Перегруженный метод сравнения
        int comparison(Rectangle b)
        {
            if (area() > b.area())
            {
                return 1;
            }
            else
            {
                if (area() == b.area())
                    return 0;
                else
                    return -1;
            }
        }

        int comparison(double b)
        {
            if (area() > b)
            {
                return 1;
            }
            else
            {
                if (area() == b)

                    return 0;
                else
                    return -1;
            }

        }
        public static bool operator <(Rectangle l, Rectangle f)
        {
            return l.ID < f.ID;
        }

        public static bool operator >(Rectangle l, Rectangle f)
        {
            return l.ID > f.ID;
        }

        public static bool operator <=(Rectangle l, Rectangle f)
        {
            return l.ID <= f.ID;
        }

        public static bool operator >=(Rectangle l, Rectangle f)
        {
            return l.ID >= f.ID;
        }
    }
}
