//Method Calls
ShowCharacter("New York", 2);
CalculateRetail(5.00, 100);
Celsius(80);
IsPrime(5);

//Method Code
////////////////////////////////////////////////////
static void ShowCharacter(string str, int integer)
{
    Console.WriteLine($"{str[integer - 1]}");
}
////////////////////////////////////////////////////
static void CalculateRetail(double wholeSale, double markupPercent)
{
    double retailPrice = wholeSale + (wholeSale * (markupPercent / 100));
    Console.WriteLine($"wholesale cost is {wholeSale} and markup percent is {markupPercent} percent, " +
        $"the retail price is {retailPrice}");
}
///////////////////////////////////////////////////
static double Celsius(double i)
{
    double C = .5556 * (i - 32);
    return C;
}
//Creating table of temp///////////////////////////
for (int i = 80; i < 101; i++)
{
    Console.WriteLine($"{i} | {Celsius(80)}");
}
//////////////////////////////////////////////////
static void IsPrime(int i)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(false);
    }
}