Console.WriteLine("Nguyen Huu Hung_2415053122322");
Console.Write("Nhap ho ten:");
string hoTen = Console.ReadLine();

if (string.IsNullOrWhiteSpace(hoTen))
    Console.WriteLine("Chuoi null, khong tach");
else
{
    string[] words = hoTen.Trim().Split(' ');

    if (words == null)
        Console.WriteLine("Mang null, khong in");
    else
        for (int i = 0; i < words.Length; i++)
            if (words[i] != null)
                Console.WriteLine(words[i]);
}
