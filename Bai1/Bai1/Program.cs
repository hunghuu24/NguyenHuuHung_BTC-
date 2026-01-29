
Console.Write("Nhap ho Ten: ");
string hoTen = Console.ReadLine();
if (string.IsNullOrWhiteSpace(hoTen))
    Console.WriteLine("Chuoi khong hop le");
hoTen = hoTen.Trim();
string[] word = hoTen.Split(' ');
string kq = "";
foreach (string w in word)
{
    if (w != "")
    {
        string tu = char.ToUpper(w[0]) + w.Substring(1).ToLower();
        kq = kq + tu + " ";
    }
}
Console.WriteLine(kq.Trim());