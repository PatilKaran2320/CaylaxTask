class Program
{
    public static void Main()
    {
        string gender = string.Empty;
        Console.WriteLine("Please Enter Gender : ");
        gender=Console.ReadLine();
        if(gender == "Male")
        {
            gender = "Female";
        }
        else if(gender =="Female")
        {
            gender = "Male";
        }
        Console.WriteLine("Replaced Value : "+gender);
        Console.ReadLine();
    }
}