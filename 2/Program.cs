System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int GetLengthOfNumber(int val)
{
    int count = 0; //Кол-во цифр
    while(val > 0)
    {
        val = val / 10;
        count++;
    }
    return count;
}


int length = GetLengthOfNumber(N);
int [] digitsOfNumber = new int[length];

for(int i = 0; i < length; i++)
{
    digitsOfNumber[i] = N % 10;
    N = N / 10;
}
int sum = 0;
for (int i = 0; i < length; i++)
{
      if (N % digitsOfNumber[i] == 0)
      {
        sum = digitsOfNumber[i] + i;
      }
}
Console.WriteLine(sum);

























//int n = Convert.ToInt32(Console.ReadLine());
     //int sum = 0;
       // for (int i = 1; i <= n; ++i)
       // {
          //  if (n % i == 0) sum += i;
       // }
       // Console.WriteLine(sum);