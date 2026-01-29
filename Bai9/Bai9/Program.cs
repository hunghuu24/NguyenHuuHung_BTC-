Console.WriteLine("Nguyen Huu Hung_2415053122322");
string[] arr = {"Hung", null, "", "   ", "Nam", null, "Lan"};

for(int i = 0; i < arr.Length; i++)
    Console.WriteLine(arr[i]);
int dem = 0;

if (arr != null)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (!string.IsNullOrWhiteSpace(arr[i]))
        {
            dem++;
        }
    }
}

Console.WriteLine("So chuoi khac null va khong rong: " + dem);