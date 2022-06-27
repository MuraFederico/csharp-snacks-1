// See https://aka.ms/new-console-template for more information


int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("inserisci un numero: ");
    int num = Int32.Parse(Console.ReadLine());
    sum = sum + num;
}

Console.WriteLine("la somma dei numeri e': " + sum);