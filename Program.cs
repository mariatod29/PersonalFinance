using PersonalFinance;


Console.WriteLine("Welcome!");
User User = new User();
Console.Write("Please enter your name: ");
User.Name = Console.ReadLine();
Console.Write("Now enter a secured password: ");
User.Password = Console.ReadLine();

while (Console.ReadKey(true).Key != ConsoleKey.Escape)
{
    OperationsMenu.MainMenu();
    /*
    double monthlyLeftMoney = 0.00;
    monthlyLeftMoney = totalAmountOfIncome - totalAmountOfExpenses;

    if(monthlyLeftMoney > 0)
    {
        Console.WriteLine("You have more {0} lv. left this month.", monthlyLeftMoney);
    }
    else
    {
        Console.WriteLine("You have spent {0} lv. more than planned.", Math.Abs(monthlyLeftMoney));
    }*/
}