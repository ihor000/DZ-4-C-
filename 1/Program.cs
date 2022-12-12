
Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int degOfNumber = numberA; 

for (int i = 1; i < numberB; i++)
{   
    degOfNumber = degOfNumber * numberA;
}
Console.WriteLine(degOfNumber);  