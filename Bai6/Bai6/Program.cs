Console.WriteLine("Nguyen Huu Hung_2415053122322");
Console.Write("Nhap so phan tu n: ");
int n = int.Parse(Console.ReadLine());

int[] a = null;

if (n > 0)
{
    a = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"a[{i}] = ");
        a[i] = int.Parse(Console.ReadLine());
    }
}

int dem = 0;

if(a != null)
    for (int i = 0; i < n; i++)
    {
        if (a[i] % 2 == 0)
            dem++;
    }

Console.WriteLine($"Co {dem} phan tu chan");