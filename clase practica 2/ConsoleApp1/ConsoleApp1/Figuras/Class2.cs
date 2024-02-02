using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Figuras
{
    internal class Class2
    {
        double area, Base, altura;

        public Class2(double area, double Base, double altura)
        {
        
            this.area = area;
            this.Base = Base;
            this.altura = altura;
        
        }

        public void setArea(double area) { this.area = area; }

        public void setBase(double Base) { this.Base = Base; }

        public void setAltura(double altura) { this.altura = altura; }


        public void menu(int opcion)
        {
            Console.WriteLine("Ingrese su opcion deseada: ");
            Console.WriteLine("\t 1. Triangulo 2.Rectangulo 3.Cuadrado");

        }

        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("No se aceptan letras", error.Message);
                }
            } while (v == 0);
            return num;
        }


    }
}
