int age = int.Parse(Console.ReadLine());
double priceOfWashingMachine = double.Parse(Console.ReadLine());    
int presentPrice = int.Parse(Console.ReadLine());

int numberOfToys = 0;
int savedMoney = 0;
int moneyForBirthday = 10;

for (int currenYear = 1; currenYear <= age; currenYear++)
{
    if (currenYear % 2 == 0)
    {
        savedMoney += (moneyForBirthday - 1);
        moneyForBirthday += 10;
    }
    else
    {
        numberOfToys++;
    }
}
savedMoney += numberOfToys * presentPrice;
if (savedMoney >= priceOfWashingMachine)
{
    Console.WriteLine($"Yes! {savedMoney - priceOfWashingMachine:F2}");
}
else
{
    Console.WriteLine($"No! {priceOfWashingMachine - savedMoney:F2}");
}
    
