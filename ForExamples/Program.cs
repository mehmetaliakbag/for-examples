#region Task1

// "Kendime inanıyorum, ben bu yazılım işini hallederim" mesajı 10 kere konsol ekranına yazılacak

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{i} - Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

#endregion

#region Task2

// 1'den 20'ye kadar olan sayıları konsol ekranına yazdırılacak

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}

#endregion

#region Task3

// 1'den 20'ye kadar olan çift sayıları konsol ekranına yazdıracak

for (int i = 1;i <= 20; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

#endregion

#region Task4

// 50 ile 150 arasındaki sayıların toplamını console ekranına yazdıracak

int total = 0;

for(int i = 50; i <= 150; i++)
{
    total += i;
}

Console.WriteLine($"50 - 150 arası sayıların toplamı: {total}");

#endregion
    
#region Task5

// 1 ile 120 arası çift ve tek sayıların toplamı

int doubleTotal = 0;

int singleTotal = 0;

for( int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        doubleTotal += i;
    }
    else
    {
        singleTotal += i;
    }
}

Console.WriteLine($"1 - 120 arasındaki çift sayıların toplamı: {doubleTotal}" +
                  $"\n1 - 120 arasındaki tek Sayıları toplamı: {singleTotal}");

#endregion
