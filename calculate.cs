namespace console
{
class Calculate
{
    public static double add(double x, double y)
    {
        return(x+y);
    }
    static void main(string[]args)
    {
        int op,
        Console.WriteLine("enter operation");
        Console.WriteLine("1.addition");
        Console.WriteLine("2.substraction");
        Console.WriteLine("3.division");
        Console.WriteLine("4.multiplication");
        op = convert.Toint32(Console.Readline());

         Console.WriteLine(" enter first number");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second number");
            double y = Convert.ToDouble(Console.ReadLine());
            int n,ans=0;
            var operation = new Calculate();

              switch(op)
            {
                case 1:
                    
                    Console.WriteLine("the sum of two entered numbers {0} and {1} equal to {2}", x, y, operation.Add(x, y));
                    Console.ReadKey();
                    break;
                case 2:
 Console.WriteLine("the difference of two entered numbers {0} and {1} equal to {2}" ,x ,y,operation.subtraction(x, y));
                    Console.ReadKey();
                    break;
                case 3:
                    
                    Console.WriteLine("the quotient of entered numbers {0}  and {1} is equal to {2}", x, y,operation .division(x, y));
                    Console.ReadKey();
                    break;
                case 4:
                Console.WriteLine("the multplication table of entered number {0}  and {1} is equal to {2}", x, y, operation.Multplication(x, y));
                    Console.ReadKey();
                    break;
                     Console.ReadKey();
                default:
                    Console.WriteLine("you can try another operation ");
                    Console.ReadKey();
                    break;
            }
    }
}
