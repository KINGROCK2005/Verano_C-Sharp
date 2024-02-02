using System;
using System.Text;
using ConsoleApp2;

namespace Program
{
    public class Programa{


        static void Main(String[] args)
        {

                Ejer1 CD = new Ejer1();
            double area;
            int opcion;
                double resultado;

            CD.menu();

            do
                {
               opcion = CD.validar("Digite su opcion: ");
            }while(opcion > 0 || opcion <4);

            switch (opcion)
            {
                case 1:
                    {
                        do{
                            area = CD.validar("Ingrese su base: ");

                        }
                        while(opcion > 0);
                        do
                        {
                            area = CD.validar("Ingrese su altura: ");

                        }
                        while (opcion > 0);
                        resultado = CD.AT(area);
                        Console.WriteLine("Su area en cm cuadrados es: " + resultado);
                        break;


                    }
                case 2:
                    {
                        do{
                            area = CD.validar("Ingrese su base: ");

                        }
                        while (opcion > 0) ;
                        do
                        {
                            area = CD.validar("Ingrese su altura: ");

                        }
                        while (opcion > 0);
                        break;
                    }

                    case 3:{
                        do
                        {
                            area = CD.validar("Ingrese su lado: ");

                        }
                        while (opcion > 0);
                        break;
                    }
            }

            
        }
        

}

}
