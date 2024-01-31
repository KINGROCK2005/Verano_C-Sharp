using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Impuesto
    {
        private double[] Ing = new double[10];
        private double[] IL = new double[10];
        private double[] IP = new double[10];


        public Impuesto() { }
        public Impuesto(double[] ing, double[] iL, double[] iP)
        {
            Ing = ing;
            IL = iL;
            IP = iP;
        }
        public void PIng(double[] ing)
        {
            this.Ing = ing;
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
                }catch(Exception error)
                {
                    v = 0;
                    Console.WriteLine("No se aceptan letras",error.Message);
                }
            }while(v==0);
            return num;
        }
        }
    }

