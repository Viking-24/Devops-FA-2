class ConsoleApp
{
    static void Main()
    {
        Console.Write("Enter the message: ");
        string str = Console.ReadLine() ?? "";
        Console.Write("Enter the key: ");
        string key = Console.ReadLine() ?? "";


        int mod = key.Length;
        int j = 0;
        for (int i = key.Length; i < str.Length; i++)
        {
            key += key[j % mod];
            j++;
        }
        string ans = "";
        for (int i = 0; i < str.Length; i++)
        {
            ans += Convert.ToChar((key[i] - 'A' + str[i] - 'A') % 26 + 'A');
        }
        Console.WriteLine($"Encrypted message: {ans}");
    }
}