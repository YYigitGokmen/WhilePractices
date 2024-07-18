

int i = 0;
while (i <= 9)
{
    i++;
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}


Console.WriteLine("---------------------------------");


int x = 0;
while (x <= 19)
{
    x++;
    Console.WriteLine($"{x}");
}

Console.WriteLine("---------------------------------");


int y = 0;
while ( y <= 18)
{
    y += 2;
    Console.WriteLine($"{y}");
}

Console.WriteLine("---------------------------------");


int sum = 0;
int z = 49;
while  (z <= 149)
{
    z++;
    sum += z;

}
Console.WriteLine($"{sum}");
//50 ve 150 yi dahil etmek için döngüyü 49 dan başlatıp 149 da bitirdim


Console.WriteLine("---------------------------------");



int odd = 0;
int even = 0;
int loop = 0;
//121 i dahil etmemesi için 119 da kestim döngüyü ve en son çıktı 120 oldu.
while (loop <= 119)
{
    loop++;
    
    if (loop % 2 == 0)
    {
        even += loop;
    }
    else
    {
        odd += loop;
    }
    
}


Console.WriteLine($"1 ile 120 Arasındaki çift sayıların toplamı {even}");

Console.WriteLine($"1 ile 120 Arasındaki Tek sayıların toplamı {odd}");



