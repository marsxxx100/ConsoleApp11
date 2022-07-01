    Console.WriteLine("Введите строку:");
    string d = Console.ReadLine();
    Console.WriteLine($"Удвоенная строка: {foul(d)}");
Console.WriteLine($"Количество гласных: {foul1(d)}");
Console.WriteLine($"Количество согласных: {foul2(d)}");
if (foul3(d)) Console.WriteLine("Гласных больше ");
else Console.WriteLine("Согласных больше ");
static string foul(string s)
{
    int k = s.Length;
    string f = "";
    for (int i = 0; i < k; i++)
    {
        f = s[i + i].ToString();
        s = s.Insert(i + i, f);
    }
    return s;
}
static int foul1(string s)
{
    int l = s.Length;
    const string gl = "aeiouyAEIOUY";
    int kol = 0;
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < gl.Length; j++)
        {
            if (s[i] == gl[j])
                kol++;
        }
    }
    return kol;
}
static int foul2(string s)
{
    const string sogl = "qwrtpsdfghjklzxcvbnm";
    int kol = 0;
    for (int i = 0; i < s.Length; i++)
    {
        for (int j = 0; j < sogl.Length; j++)
        {
            if (s[i] == sogl[j])
                kol++;
        }
    }
    return (kol);
}
static bool foul3(string s)
{
    bool b;
    if (foul1(s) < foul2(s))
    {
        b = false;
    }
    else 
    {
        b = true;
    }
        return b;
}