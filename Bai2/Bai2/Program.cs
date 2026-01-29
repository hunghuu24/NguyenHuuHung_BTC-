Console.WriteLine("Nhap chuoi: ");
String s = Console.ReadLine();
if(string.IsNullOrWhiteSpace(s))
{
    Console.WriteLine("Khong co tu nao");
}
s = s.Trim();
string[] words = s.Split(' ');
int count = 0;
foreach (string w in words)
{
    if (w != "")
        count++;
}
Console.WriteLine("So tu: " + count);