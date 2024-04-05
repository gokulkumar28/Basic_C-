using System;
namespace ReadAndWrite;
class Program{
    public static void Main(string[] args)
    {
       
        //input
         Console.WriteLine("Enter name");
        string name=Console.ReadLine();
        Console.WriteLine("Enter father name");
        string fatherName=Console.ReadLine();
        //concatenation
        Console.WriteLine(name + fatherName);
        //placeholder
        Console.WriteLine("{0} {1}",name,fatherName);
        Console.WriteLine("{1} {0}",name,fatherName);
        //Interpolation
        Console.WriteLine($"{name} {fatherName}");
        Console.ReadKey();
}
}