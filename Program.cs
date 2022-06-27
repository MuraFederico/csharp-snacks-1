// See https://aka.ms/new-console-template for more information

//snack 4

int sum2 = 0;
float avg = 0f;
int a = 0;

for (int i = 2; i <= 10; i++)
{
    a += 1;
    sum2 = sum2 + i;
}

avg = sum2 / a;
Console.WriteLine(sum2);
Console.WriteLine(avg);


return;

/*snack 3*/

int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("inserisci un numero: ");
    int num = Int32.Parse(Console.ReadLine());
    sum = sum + num;
}

Console.WriteLine("la somma dei numeri e': " + sum);