using System;
namespace ForLoop
{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Enter start number:");
            double start=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter end number:");
            double end=Convert.ToDouble(Console.ReadLine());
            double sum=0;
            for(double i=start+1;i<end;i++){
                double square=i*i;
                 sum+=square;
            }
            Console.WriteLine(sum);
        }
    }
}
