class Program
{
    static void Main() 
    {
        int a, b;
        Console.WriteLine("Enter the first Number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second Number: ");
        b = Convert.ToInt32(Console.ReadLine());
        a = a + b;
        b = a - b;
        a= a - b;
        Console.WriteLine(  "First Number is : "+a);
        Console.WriteLine(" Second Num ber is  : "+b);
        Console.ReadLine();
    }

}