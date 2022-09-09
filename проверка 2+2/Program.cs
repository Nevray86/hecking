using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace проверка_2_2
{
    abstract class ansver
    {
        public abstract string _ansver();
    }
   
    
    internal class Program
    {
       
        static void Main(string[] args)
        {
            
            myAnsver my_Ansver = new myAnsver();
            Task_of_Student studentAnsver = new Task_of_Student();
           
            do
            {
                try
                {
                    var str1 = studentAnsver._ansver();
                    var str2 = my_Ansver._ansver();
                    Console.WriteLine(str1 == str2 ? "Все решено верно" : "Есть ошибки");
                    break;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            } while (true);

           
            


        }
    }
}
