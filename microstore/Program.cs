int money = 100;
string köpval;

//int Moneyamount = 0;

//int.TryParse(money, out money);

while (money > 0)
{
    Console.WriteLine($"Du har {money} cash");
    Console.WriteLine("Butik meny");
    Console.WriteLine("1)Kniv = 25kr");
    Console.WriteLine("2)Basebollträ = 15kr");
    Console.WriteLine("3)Pistol = 75kr");

    köpval = Console.ReadLine();
    while (köpval == "")
    {
        Console.WriteLine("Skriv in vad du vill köpa 1 = kniv, 2 = Basebollträ eller 3= Pistol");
        köpval = Console.ReadLine();
    }

    int antal = 0;
    Console.WriteLine("Hur många vill du köpa");
    string  pantal; 
    pantal = Console.ReadLine();  
     while (pantal == "")
    {
        Console.WriteLine("Skriv in hur många av varan du vill");
        pantal = Console.ReadLine();
    }
    int.TryParse(pantal, out antal); // sätter in anatalet spealren väljer in till vår int (antal)

    if (köpval == "1")
    {
        money = money - 25 * antal;
    }

    else if (köpval == "2")
    {
        money = money - 15 * antal;
    }
    else if (köpval == "3")
    {
        money = money - 75 * antal;
    }
}
Console.WriteLine("Du har inga pengar kvar");


Console.ReadLine();

//Console.WriteLine("Skiv in din ålder");
//string age = Console.ReadLine();

//int ageNum = 0;

//int.TryParse(age, out ageNum);

//bool success = int.TryParse(age, out ageNum);

//if (success == false)
//{
//    Console.WriteLine("No a number mate");
//}
//int i = 0;
//while (i < 10)
//{
//Console.WriteLine("igen");
//i++;
//}
