using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PrimeNumberRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            //[Assumption: All Inputs are given line by line]
            string[] lines = System.IO.File.ReadAllLines(@"E:\PrimeNumberRefactor\PrimeNumberRefactor\Input.txt");

            // Display the file contents by using a foreach loop.
            //System.Console.WriteLine("Contents of File = ");

            try
            {
                //[Move all elements from file into ArrayList so resource of File will be freed]
                ArrayList Input = new ArrayList();
                foreach (string line in lines) {
                    Input.Add(line);
                }

                foreach (string element in Input)
                {
                    int n = int.Parse(element);

                    //[Handle 0 and negative values]
                    if (n <= 0)
                    {
                        Console.WriteLine("Given Number {0} is less than or equal to zero",n);
                    }
                    else if (n != null)
                    {
                        Console.WriteLine("Prime factors of {0} are as follows", n);                        
                        
                        //[Call to method for calculation of PrimeFactors]
                        ArrayList al = PrimeFactors(n);                       

                        foreach (Object obj in al) {
                            Console.WriteLine("   {0}", obj);
                        }
                        
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception occured is:- {0}",ex.Message.ToString());
            }            
            
                Console.ReadLine();
        }

        //[call to method for calculating Primefactors]
        public static ArrayList PrimeFactors(int n)
        {
            ArrayList Result = new ArrayList();            

            if (n == 1){
                Result.Add(1);
                
            }else{
               while (n % 2 == 0){
                   n /= 2;
                    Result.Add(2);                   
               }
                    while (n % 3 == 0){
                        n /= 3;
                    Result.Add(3);                    
                    }
                    
                    for (int j = 3; j <= Math.Floor(Math.Sqrt(n)); j += 2){
                        // While j divides n, print j 
                        while (n % j == 0){
                                n /= j;
                        Result.Add(j);                       
                        }
                    }

                    if (n > 1){
                    Result.Add(n.ToString());                    
                    }
            
              }//Else condition end
            return Result;
            
        }
        //Method PrimeFactors End


    }
}
