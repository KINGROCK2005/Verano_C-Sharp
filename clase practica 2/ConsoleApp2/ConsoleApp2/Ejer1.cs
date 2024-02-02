using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ejer1
    {

            double area, Base, altura, lado;

            public Ejer1(double area, double Base, double altura, double lado)
            {

                this.area = area;
                this.Base = Base;
                this.altura = altura;
            this.lado = lado;

            }

            public void setArea(double area) { this.area = area; }

            public void setBase(double Base) { this.Base = Base; }

            public void setAltura(double altura) { this.altura = altura; }

            public double getArea() { return this.area; }


            public Ejer1()
                    {

                    }
            

            public void menu()
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

        public double AT(double Base, double altura, double area)
        {
            area = (Base / 2) * altura;
            return area;

        }

        public double AR(double Base, double altura, double area)
        {
            area = Base * altura;
            return area;
        }

        public double AC(double lado, double area)
        {
            area = Math.Pow(lado, 4);
            return area;

        }
        
    }
}

