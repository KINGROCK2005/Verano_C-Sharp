// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace ejercicio
{
    public class Program
    {
        int venta = 0, compra = 0;
        double tazCambio, valor;

        public Program(double valor,double tazCambio)
        {
            this.valor = valor;
            this.tazCambio = tazCambio;

        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public void settazCambio(double tazCambio)
        {
            this.tazCambio = tazCambio;
        }

        public void menu()
        {
            Console.WriteLine("Bienveido al programa de prueba.");
            Console.WriteLine("Que opcion desea usar: \t 1.Compra   2.Venta ");

        }

        public double ComDolar()
        {
            return valor * 36.99;

        }
        public double compEuro()
        {
            return valor * 

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
