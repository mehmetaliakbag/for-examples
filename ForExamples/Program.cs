#region Practices1

// 10 kere ekrana girilen console ekranına yazdıracak

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{i} - Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

#endregion

#region Practices2 

// 1'den 20'ye kadar olan sayıların çıktısını console ekranına yazdıracak

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}

#endregion

#region Practices3

// 1'den 20'ye kadar olan çift sayıların çıktısını console ekranına yazdıracak

for (int i = 1;i <= 20; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

#endregion

#region Practices4

// 50 ile 150 arasındaki sayıların toplamını console ekranına yazdıracak

int total1 = 0;

for(int i = 50; i <= 150; i++)
{
    total1 += i;
}

Console.WriteLine($"50 - 150 arası sayıların toplamı: {total1}");

#endregion
    
#region Practices5

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
