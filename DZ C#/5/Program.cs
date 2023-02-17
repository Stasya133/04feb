/*Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
456111 -> 5
78 -> 8
9146548 -> 1
3 -> нет*/

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int num2=num;
int count=0;
while (num > 0)
{
    count++;
    num = num / 10;
}

Console.WriteLine($"Разрядность введенного числа {count}");
int res= num2;
for (int i=1;i<=count;i++)
    {
        if (i!=count-0)
            res = num2%10;
        num2=num2/10;
     
    }
        
Console.WriteLine(res); 

/*Console.WriteLine($"Разрядность введенного числа {count}");
int res= num2; 
int i=1;
while (i<=count && num<10)
       i++;  
    {
        if (i!=count-0)
         {
            res = num2%10;
        num2=num2/10;
    Console.WriteLine(res);
         }
else

Console.WriteLine("{0} второй цифры нет ", num);

 
    }*/


