using System;
using System.Runtime.InteropServices;
namespace SurpriseAssignment{
    class Program{
        public static void Main(string[] args)
        {
            // int size=int.Parse(Console.ReadLine());
            // string str=Console.ReadLine();
            // string[] arr=str.Split(",");
            // for(int i=0;i<size;i++){
            //     if(i!=size-1 &&int.Parse(arr[i])>int.Parse(arr[i+1])){
            //         Console.WriteLine(arr[i]);
            //     }
            // }
            // if(arr.Length==0){

            // }
            // else{
            //     Console.WriteLine(arr[size-1]);
            // }



            //  int size=int.Parse(Console.ReadLine());
            // string str=Console.ReadLine();
            // string[] arr=str.Split(",");
            //  int ans;
            // if(arr.Length==0){

            // }
            // else{
            //  ans=int.Parse(arr[0])-int.Parse(arr[arr.Length-1]);
            //  Console.WriteLine(ans);
            // }

            // string str=Console.ReadLine();
            // int flag=0;
            // for(int i=0;i<str.Length;i++){
            //     int count=0;
            //     for(int j=i+1;j<str.Length;j++){
            //         if(str[i]=='{'&&str[j]=='}')
            //             count++;
            //         else if(str[i]=='['&&str[i]==']')
            //             count++;
            //         else if(str[i]=='('&&str[i]==')')
            //             count++;
            //     }
            //     if(count%2!=0)
            //         flag++;
            // }
            // if flag


            // int size=int.Parse(Console.ReadLine());
            // string str=Console.ReadLine();
            // string[] arr=str.Split(",");
            // int max=int.Parse(arr[0]);
            // int maxIndex=0;
            // int minIndex=0;
            // int min=int.Parse(arr[0]);
            // for(int i=0;i<arr.Length;i++){
            //     if(max<int.Parse(arr[i])){
            //         max=int.Parse(arr[i]);
            //         maxIndex=i;
            //         }
            //     else if(max>int.Parse(arr[i])){
            //         min=int.Parse(arr[i]);
            //         minIndex=i;
            //     }
            // }
            // int ans=maxIndex-minIndex;
            //  Console.WriteLine(ans);
            // }


            // string str=Console.ReadLine();
            //     string empty="";
            //    for(int i=0;i<str.Length;i++){
            //     if(str[i]==32)
            //         char c= str[i + 1];
            //         empty+=c.ToString();
            //     else
            //         empty+=str[i];
            //    }
            //    Console.WriteLine(empty);


            //  int size=int.Parse(Console.ReadLine());
            //     int[] arr=new int[size];
            //     int search=int.Parse(Console.ReadLine());
            //     int count=0;
            //     for(int i=0;i<size;i++){
            //         arr[i]=int.Parse(Console.ReadLine());
            //         if(arr[i]==search){
            //             Console.WriteLine(i);
            //             count++;
            //             }

            //             if(count==0)
            //         Console.WriteLine("-1");
            //     } 

// ODD EVEN  STRING SWAP
        //    string str=Console.ReadLine();
        //        string ans=str[0]+"";
        //        string odd="";
        //        string even="";
        //        for(int i=1;i<str.Length;i++){
        //         if(i%2!=0){
        //             odd+=str[i];
        //             }
        //         else{
        //             even+=str[i];
        //         }
        //        }
        //        int index=0;
        //        for(int i=0;i<even.Length;i++){
        //         ans=ans+even[i]+odd[i];
        //         index=i;
        //        }
        //        for(int i=index+1;i<odd.Length;i++){
        //         ans+=odd[i];
        //        }
        

        //        Console.WriteLine(ans);


//camel casing string


            //     string str=Console.ReadLine();
            //    int count=0;
            //    if(str[0]>=65 && str[0]<=90){
            //     int c=str[0]+32;
            //     Console.Write((char)c);
            //    }
    

            //    for(int i=1;i<str.Length;i++){
            //     if(str[i]==32)
            //         count++;
            //     else if(count>0){
            //         string val=str[i].ToString();
            //         Console.Write(val.ToUpper());
            //         count=0;
            //         }
            //     else
            //         Console.Write(str[i]);

    //}

                // string str=Console.ReadLine();
                // string[] arr=str.Split(" ");
                // string reverse=" ";
                // for(int i=1;i<arr.Length-1;i++){
                //     string another=arr[i];
                //     for(int j=another.Length-1;j>=0;j--){
                //         reverse+=another[j];
                //     }
                //     reverse+=" ";
                // }
                // Console.WriteLine(arr[0]+reverse+arr[arr.Length-1]);

                // bool flag=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss.fff",null,System.Globalization.DateTimeStyles.None,out DateTime date);
                // Console.WriteLine(flag);
                // // while(!flag){
                // //     flag=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss.fff",null,System.Globalization.DateTimeStyles.None,out  date);
                // // }
                // Console.WriteLine("year = "+date.ToString("yyyy"));
                // Console.WriteLine("month = "+date.ToString("MM"));
                // Console.WriteLine("hour = "+date.ToString("dd"));
                // Console.WriteLine("minute = "+date.ToString("mm"));
                // Console.WriteLine("second = "+date.ToString("ss"));
                // Console.WriteLine("millisecond = "+date.ToString("fff"));


                // DateTime date1=DateTime.Parse(Console.ReadLine());
                // DateTime date2=DateTime.Parse(Console.ReadLine());
                // TimeSpan span=date2-date1;
                // Console.WriteLine(span.TotalMinutes);

            //  DateTime date=DateTime.Parse(Console.ReadLine());
            // int month=int.Parse(date.ToString("MM"));
            //    string day=date.D();

                // DateTime date1=DateTime.Parse(Console.ReadLine());
                // DateTime date2=DateTime.Parse(Console.ReadLine());
                // TimeSpan span=new TimeSpan();
                //    span=date1-date2;
                //    int minutes=(int)span.TotalMinutes;
                //  Console.WriteLine(minutes);

                
            //    int num=int.Parse(Console.ReadLine());
            //     for(int i=1;i<=num;i++){
            //         for(int j=1;j<=num*2-i;j++){
            //          Console.Write(" ");
            //         }
            //         for(int k=1;k<=i*2-1;k++){
            //             Console.Write(i);
            //         }
            //         Console.WriteLine();
            //     }
                

            int row=int.Parse(Console.ReadLine());
                int col=int.Parse(Console.ReadLine());
               int[,] arrOne=new int[row,col];
               int[,] arrTwo=new int[col,row];
                for(int i=0;i<row;i++){
                    for(int j=0;j<col;j++){
                        arrOne[i,j]=int.Parse(Console.ReadLine());
                    }
                }
                for(int i=0;i<row;i++){
                    for(int j=0;j<col;j++){
                       arrTwo[j,i]=arrOne[i,j];
                    }
                }
                for(int i=0;i<row;i++){
                    for(int j=0;j<col;j++){
                        
                        Console.Write(arrOne[i,j]+" ");
                    }
                    Console.WriteLine();
                }


                }
               
    }
    }

