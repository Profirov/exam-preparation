double heritage = double.Parse(Console.ReadLine()); 
int yearToLive = int.Parse(Console.ReadLine());
int years = 18;

for (int currentYear = 1800; currentYear <= yearToLive; currentYear++)
{
    if (currentYear % 2 == 0)
    {
        heritage -= 12000;
    }
    else
    {
        heritage -= (12000 + 50 * years);
    }
    years++;
}
if (heritage > 0)
{
    Console.WriteLine($"Yes! he will live and will have {heritage :F2} money ");
}
else
{
    Console.WriteLine();
}