namespace Fundamentals
{
    public class Assignment1
    {
        public void amicableNumber()
        {
            Console.WriteLine("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum1 = 0;
            for (int i = 1; i <=number1 / 2; i++)
            {
                if (number1 % i == 0)
                {
                    sum1 = sum1 + i;
                }
            }
            Console.WriteLine("The 1st sum is " + sum1);
            int sum2 = 0;
            for (int i = 1; i <=number2 / 2; i++)
            {
                if (number2 % i == 0)
                {
                    sum2 = sum2 + i;
                }
            }
            Console.WriteLine("Second sum is " + sum2);
            if(sum1==number2 && sum2==number1)
            {
                Console.WriteLine("Both the numbers are amicable");
            }
            else
            {
                Console.WriteLine("Both the number are not amicable");
            }

        }
    }
}
