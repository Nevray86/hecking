using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;


namespace проверка_2_2
{
    class myAnsver : ansver
    {

        public override string _ansver() 
        {

            Console.WriteLine("Введите имя файла с правильным решениями  в формате: StudentAnsver ");
            string patch = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            patch = patch + "\\" + Console.ReadLine() + ".txt";
           
                string _ansver = File.ReadAllText(patch);
                return _ansver;
           
        }
    
    }
}
