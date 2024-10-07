#region Practices1

//Döngünün başlangıç değerini, bitiş koşulunu ve artış değerini belirtildi.
//Her döngüde girilen mesajın çıktısına verecek 10 kere olana kadar

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{i} - Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine();

#endregion

#region Practices2 

//1'den 20'ye kadar olan sayıların çıktısını verecek

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();

#endregion

#region Practices3

//1'den 20'ye kadar olan çift sayıların çıktısını verecek

for (int i = 1;i <= 20; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine();

#endregion

#region Practices4

//50 ile 150 arasındaki sayıların toplamı

//for döngüsünden dönen sayıların her birini total değişkenine += işlemi yapıp toplam sonucu bulcaz

int total1 = 0;

for(int i = 50; i <= 150; i++)
{
    total1 = total1 + i; // total += i;
}

//total1 = i dersem her döngüde mevcut değeri değişkene atarken total1 değişkenin  atama öncesi değerini silecekti

//Bu durum da sonucun 150 çıkmasına sebeb olacaktı.

Console.WriteLine($"50 - 150 arası sayıların toplamı: {total1}");

Console.WriteLine();

#endregion
    
#region Practices5

//1 ile 120 arası hem çift hem tek sayıların toplamı

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

Console.WriteLine($"1 - 120 arasındaki " +
                  $"\nÇift sayıların toplamı {doubleTotal} " +
                  $"\nTek Sayıları toplamı ise {singleTotal}");

#endregion