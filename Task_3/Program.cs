/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да*/

/*int number = Convert.ToInt32(Console.ReadLine());


if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Number " + number + " is multiple 7 and 23");
}
else
{
    Console.WriteLine("Number " + number + " is not multiple 7 and 23");
}*/
KratnoeChislo(181);
KratnoeChislo(55);
KratnoeChislo(161);


void KratnoeChislo(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Число " + number + " является кратным 7 и 23");
    }
    else
    {
        Console.WriteLine("Число " + number + " не является кратным 7 и 23");
    }
}

