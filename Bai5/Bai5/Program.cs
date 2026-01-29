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

if (a == null)
{
    Console.WriteLine("Mang chua duoc khoi tao!");
}

int max = a[0];

for (int i = 1; i < n; i++)
{
    if (a[i] > max)
        max = a[i];
}

Console.WriteLine("Gia tri lon nhat = " + max);
