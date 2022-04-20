Console.WriteLine("Please write the price!");
var priceSt = Console.ReadLine();
Console.WriteLine("Please write the amount given to the cashier!");
var moneyGivenSt = Console.ReadLine();
double coin2 = 0;
double coin1 = 0;
double coin05 = 0;
double coin01 = 0;
double coin005 = 0;
double coin002 = 0;
double coin001 = 0;

bool priceParsed = double.TryParse(priceSt, out double price);
bool moneyGivenParsed = double.TryParse(moneyGivenSt, out double moneyGiven);

double change = Math.Round((moneyGiven - price), 2);

Console.WriteLine();

if (change < 0)
{ Console.WriteLine("The money you have given is not enough.");
  Console.WriteLine($"You still need to pay Euro {change}");
}

else { Console.WriteLine($"The change is Euro {change}");

if (change >= 2)
    {coin2 = Math.Floor(change / 2);
     change = Math.Round((change - coin2 * 2), 2);
    }

if (change >= 1)
    {
     coin1 = Math.Floor(change / 1);
     change = Math.Round((change - coin1 * 1), 2);
    }
    
if (change >= 0.5)
    {
     coin05 = Math.Floor(change / 0.5);
     change = Math.Round((change - coin05 * 0.5), 2);
    }
if (change >= 0.1)
    {
     coin01 = Math.Floor(change / 0.1);
     change = Math.Round((change - coin01 * 0.1), 2);
    }

if (change >= 0.05)
    {
     coin005 = Math.Floor(change / 0.05);
     change = Math.Round((change - coin005 * 0.05), 2);
    }

if (change >= 0.02)
    {
     coin002 = Math.Floor(change / 0.02);
     change = Math.Round((change - coin002 * 0.02), 2);
    }

if (change >= 0.01)
    {
     coin001 = Math.Floor(change / 0.01);
     change = Math.Round((change - coin001 * 0.01), 2);
    }

 Console.WriteLine("For your change you will receive:");
    if(coin2 > 0)
    { Console.WriteLine($"{coin2}   2.00 Euro coins"); }
    if (coin1 > 0)
    { Console.WriteLine($"{coin1}   1.00 Euro coins"); }
    if (coin05 > 0)
    { Console.WriteLine($"{coin05}   0.50 Euro coins"); }
    if (coin01 > 0)
    { Console.WriteLine($"{coin01}   0.10 Euro coins"); }
    if (coin005 > 0)
    { Console.WriteLine($"{coin005}   0.05 Euro coins"); }
    if (coin002 > 0)
    { Console.WriteLine($"{coin002}   0.02 Euro coins"); }
    if (coin001 > 0)
    { Console.WriteLine($"{coin001}   0.01 Euro coins"); }

}


