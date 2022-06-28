// See https://aka.ms/new-console-template for more information

//snack 12

void IsEven(int number)
{
    if (number % 2 == 0)
    {
         Console.WriteLine("the number is even");
    }else
    {
        Console.WriteLine("the number is odd");
    }
}

Console.Write("enter a number: ");

int number = Int32.Parse(Console.ReadLine());

Console.WriteLine();

IsEven(number);

return;

// snack 11

string CheckWords(string word1, string word2)
{
    if (word1.Length == word2.Length)
    {
        return $"{word1} {word2}";
    }else if(word1.Length > word2.Length)
    {
        return word1;
    }else
    {
        return word2;
    }
};

Console.Write("inserisci 2 parole: ");
string word1 = Console.ReadLine();
string word2 = Console.ReadLine();

string result = CheckWords(word1, word2);

Console.WriteLine();
Console.WriteLine(result);

return;

//snack 10

Console.Write("inserisci il numero di array: ");
int n = Int32.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    /*Console.WriteLine("arr" + (i +1) + ":\n");*/
    int[] arr = new int[10];
    for(int j = 0; j < 10; j++)
    {
        Random r = new Random();
        int rInt = r.Next(1, 101);
        arr[j] = rInt;
        Console.Write(arr[j] + "\t");
    }
    Console.WriteLine();
}

return;

//snack 5

Console.Write("inserisci un numero: ");
int userNum1 = Int32.Parse(Console.ReadLine());

if (userNum1 % 2 == 0)
{
    Console.WriteLine("il numero e': " + userNum1);
}else
{
    Console.WriteLine("il numero e': " + (userNum1 + 1));
}



return;

//snack 4

int sum2 = 0;
double avg = 0f;
int numberIteration = 0;

for (int i = 2; i <= 10; i++)
{
    numberIteration += 1;
    sum2 = sum2 + i;
}

avg = sum2 / numberIteration;
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

return;
