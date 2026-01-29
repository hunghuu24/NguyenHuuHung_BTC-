Console.WriteLine("Nguyen Huu Hung_2415053122322");
Console.Write("Nhap mot cau:");
string cau = Console.ReadLine();

if (string.IsNullOrWhiteSpace(cau))
    Console.WriteLine("Chuoi null");
else
{
    string[] words = cau.Trim().Split(' ');

    string tuDaiNhat = "";
    int maxLength = 0;

    for (int i = 0; i < words.Length; i++)
        if (words[i] != "")
            if (words[i].Length > maxLength)
            {
                maxLength = words[i].Length;
                tuDaiNhat = words[i];
            }

    Console.WriteLine("Tu dai nhat: " + tuDaiNhat);
}
