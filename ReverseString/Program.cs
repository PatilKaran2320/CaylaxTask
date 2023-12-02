class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter a string input");
        string name = Console.ReadLine();
        string reversename = string.Empty;

        int i = name.Length - 1;
        while (i >= 0)
        {
            reversename += name[i];
            i--;
        }

        Console.WriteLine($"The Original name : {name} \n ReversName : {reversename}");
        Console.ReadLine();
    }
}