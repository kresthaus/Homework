// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int a, b, c;


         Console.WriteLine("Введите три числа : ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());

        c = Convert.ToInt32(Console.ReadLine());
 

        if (a > b && b > c)
 
        {
 
            Console.WriteLine("{0} максимальное число", a);
 
        }
 
  if (b > a && a > c)
 
        {
 
            Console.WriteLine("{0} максимальное число", b);
 
        }

         if (c > a && c > b)
 
        {
 
            Console.WriteLine("{0} максимальное число", c);
 
        }
        Console.ReadLine();
 