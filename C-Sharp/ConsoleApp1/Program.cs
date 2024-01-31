// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int cost = 200;
int boletos = 0;
int valTotal = 0;


Console.WriteLine("Ingrese cuantos boletos desea comprar: ");
do { boletos = int.Parse(Console.ReadLine());
}
while (boletos <= 0 || boletos > 10);


valTotal = cost * boletos;

Console.WriteLine("Su a Miami tiene un costo total de: " + valTotal +" dolares. ");
