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
    class Task_of_Student : ansver
    {
        // этот метод принимает название файла ,где есть запись решения от студента в формате 2+2=4,метод сохраняет
        // в другой файл ответ студента
        // для дальнейшего сравнения с правильными ответами
        public override string _ansver()
        {
            Console.WriteLine("Напишите имя файла с решениями от студента в формате: StudentAnsver");

            string patch_student = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            patch_student = patch_student + @"\StudentAnsver.txt";

            string patch = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            patch = patch + "\\" + Console.ReadLine() + ".txt";

            string[] lines = File.ReadAllLines(patch);
            int a;
            foreach (string line in lines)
            {
                string s = line;
                Regex regex = new Regex(@"(..$)");
                MatchCollection matches = regex.Matches(s);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        string e = match.ToString();
                        a = Convert.ToInt32(new DataTable().Compute(e, ""));


                        var ansver = new StreamWriter(patch_student, true);
                        ansver.WriteLine(a);
                        ansver.Close();

                    }

                }

               
            }
            string _ansver = File.ReadAllText(patch_student);
            return _ansver;
        }

    }
}
