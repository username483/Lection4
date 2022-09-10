// рекурсия
//факториал
// 5!= 5*4*3*2*1
// 5!= 5*4!
//       4!=4*3!
//            3!=3*2!

double Factorial (int n)
{
    if(n == 1) return 1; //1! = 1 , 0! = 1
    else return n * Factorial(n-1);
}
Console.WriteLine(Factorial(3));
for (int i = 1; i < 40; i++)
{
 Console.WriteLine($"{i}! = {Factorial(i)}");
}
