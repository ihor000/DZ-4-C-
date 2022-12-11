
Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int degreeOfNumber = numberA;

for(int i = 1; numberB >= i; i++)
{
    degreeOfNumber = degreeOfNumber * numberA;
    Console.WriteLine(degreeOfNumber);
   
   
}