using System;

namespace Demo1sir
{
    class Program
    {
        static void Main( string[] args)
        {
            //int val1 = 0,
            //    val2 = 1,
            //    val3,
            //       i,
            //    n = 9;
            //Console.WriteLine("Fibonacci series:");
            //Console.Write(val1 + " " + val2 + " ");
            //for (i = 2; i < n; ++i)
            //{
            //    val3 = val1 + val2;
            //    Console.Write(val3 + " ");
            //    val1 = val2;
            //    val2 = val3;
            //}

            // revrse number

            //Console.WriteLine("enter the num");
            //int rNum = int.Parse(Console.ReadLine());
            //int rev = 0;
            //while (rNum > 0)
            //{
            //    int rem = rNum % 10;
            //    rev = (rev * 10) + rem;
            //    rNum = rNum / 10;
            //}
            //Console.WriteLine("reverse number is:" + rev);


            // string palindrome

            //Console.WriteLine("enter any string for check string is palindrome or not ");
            //string s = Console.ReadLine();
            //char[] rev = s.ToCharArray();
            //Array.Reverse(rev);
            //string revel = new string(rev);
            //if (s.Equals(revel))
            //{
            //    Console.WriteLine(s + " Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine(s + "Not Palindrome");
            //}

            ////number palindrome
            int ip, remain, num, add;
            Console.WriteLine("enter any number for check number is palindrome or not ");
            Console.Write("\n Enter a number: ");
            ip = int.Parse(Console.ReadLine());
            num = ip;
            while (ip > 0)
            {
                remain = ip % 10; //for getting remainder by dividing with 10    
                ip = ip / 10; //for getting quotient by dividing with 10    
                add = ip * 10 + remain;
                /*multiplying the sum with 10 and adding  
                remainder*/
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", ip);
            if (ip == add) //checking whether the reversed number is equal to entered number    
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();


        }
    }
}
