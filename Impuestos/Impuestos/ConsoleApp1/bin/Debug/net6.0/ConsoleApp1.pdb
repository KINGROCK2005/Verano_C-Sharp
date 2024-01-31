using ConsoleApp1;
public class Cp
{
    public static void Main(String[]args)
    {
        Impuesto im = new Impuesto();
        int seguir;
        double[] S; double[] P; double[] L;
        S = new double[10];
        P = new double[10];
        L = new double[10];
        int ind = 0;int ce;
        do
        {

            do
            {
                ce = im.validar("Digite la cantidad de empleados:  ");

            } while (ce <= 0 || ce > 10);

            for (ind = 0; ind < ce; ind++)
            {
                do
                {
                    S[ind] = im.validar("Valor del empleado #"+(ind+1)+":");
                    im.PIng(S);
                } while (S[ind] < 4800 || S[ind] > 500000);
                P[ind] = S[ind] * 0.07;
                L[ind] = S[ind] * 0.22;
            }
            for (ind = 0; ind < ce; ind++)
            {
                Console.WriteLine("\t" + S[ind]);
            }
            for (ind = 0; ind < ce; ind++)
            {
                Console.WriteLine("\t" + P[ind]);
            }
            for (ind = 0; ind < ce; ind++)
            {
                Console.WriteLine("\t" + L[ind]);
            }

            do
            {
                seguir = im.validar("Desea seguir en el programa? 1.Si 2.No");

            } while (seguir <= 0 || seguir > 2);
        }while (seguir ==1);

        Console.WriteLine("Fin del programa, Josthim gey <3");
    }
}