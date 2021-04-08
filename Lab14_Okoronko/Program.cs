using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_Okoronko
{
    interface IConvertible
    {
        string ConvertToCSharp(string CSharp);
        string ConvertToVB(string VB);

    }
    interface ICodeChecker
    {
        bool CheckCodeSyntax(string str1, string str2);
        // str1 - строка для проверки
        // str2 - используемый язык
    }
    class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string CSharp)
        {
            return "Преобразование в Си Шарп";
        }
        public string ConvertToVB(string VB)
        {
            return "Преобразование в Вижуал Бэсик";
        }
    }
    class ProgramHelper:ProgramConverter,ICodeChecker
    {
        //public string ConvertToCSharp(string CSharp)
        //    return "Преобразование в Си Шарп";
        //}
        //public string ConvertToVB(string VB)
        //{
            //return "Преобразование в Вижуал Бэсик";
        //}
        public bool  CheckCodeSyntax(string str1, string srt2)
        {
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ProgramConverter[] check = new ProgramConverter[2]; 
            check[0] = new ProgramConverter();
            check[1] = new ProgramHelper();
            for (int i = 0; i < check.Length; i++)
            {
                if (check[i] is ICodeChecker)
                {
                    ICodeChecker Check = check[i] as ProgramHelper;
                    if (Check.CheckCodeSyntax("str1", "str2")) Console.WriteLine(check[i].ConvertToCSharp("str1"));
                    else Console.WriteLine(check[i].ConvertToVB("str1"));
                }
                else
                { 
                    ICodeChecker Check = check[i] as ProgramHelper;
                    Console.WriteLine(check[i].ConvertToCSharp("str1"));
                    Console.WriteLine(check[i].ConvertToVB("str1"));
                }
            }
            Console.ReadLine();
        }
        
    }
}
