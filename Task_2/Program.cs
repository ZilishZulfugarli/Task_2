using Task_2;


internal class Program
{
    public static void Main(string[] args)
    {
        AccessBank uni = new AccessBank("Zilish", "Zulfugarli", "4545 - 5454 - 2121 - 1212", 121, 1111, 200);
        

        Console.WriteLine("Welcome to UniBank");
        Console.WriteLine("Enter pin code:");
        int pin = Convert.ToInt32(Console.ReadLine());
        if (pin != 1111)
        {
            return;
        }

        Console.WriteLine("Dear " + uni.Name + " " + uni.Surname + " Welcome UniBank");
        Console.WriteLine(uni.CardNumber);

        Console.WriteLine("How we can help you?");
        Console.WriteLine("For check money -- Please Enter 1");
        Console.WriteLine("For add money -- Please enter 0");
        int enter = Convert.ToInt32(Console.ReadLine());
        if (enter == 0)

        {
            Console.WriteLine("How much money you want to check?");
            uni.DecreaseBalance(Convert.ToDouble(Console.ReadLine()));
            if (uni.Balance > 0)
            {
                Console.WriteLine("Balance: " + uni.Balance);
            }

            else
            {
                Console.WriteLine("You haven't enough money in your balance");
            }

        }

        if (enter == 1)
        {
            Console.WriteLine("How much money you want to add:");
            uni.IncreaseBalance(Convert.ToDouble(Console.ReadLine()));
            if (uni.Balance > 0)
            {
                Console.WriteLine("Balance: " + uni.Balance);
            }
            else uni.Balance = uni.Balance;
            {
                Console.WriteLine("Please enter money");
            }
        }

        

        








    }
}