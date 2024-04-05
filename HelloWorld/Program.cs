using System;//import
namespace HelloWorld; //File Scoped Namespace

    class Program
    {
       public static void Main(string[] args)
       {
       int ans=sub(23,28);
       Console.WriteLine(ans);
       double a=2.3;
       double b=6.5;
       divide( a,b);
       }
       public static int sub(int a,int b){
         int dif=a-b;
         return dif;
       }
       public static void divide(double a,double b){
         double dif=a/b;
         Console.WriteLine(dif);
       }
    }
