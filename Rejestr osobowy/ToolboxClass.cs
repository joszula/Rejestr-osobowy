using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Linq;
using System.IO;

namespace Rejestr_osobowy
{
    public class ToolboxClass
    {
        public static int EnterNumber(string a_iText = "",int a_iMin = 0, int a_iMax = 100)
        {
            while (true)
            {
                if (a_iText != "")
                    Console.WriteLine(a_iText);
                

                if (int.TryParse(Console.ReadLine(), out int _iValue) == true && _iValue >= a_iMin && _iValue <= a_iMax)
                {
                    return _iValue;
                }
                Console.WriteLine("Co piszesz gamoniu?!");
                Console.WriteLine($"Podaj wartosc z przedzialu {a_iMin} - {a_iMax}");
            }

        }
        public static int EnterNumber(string a_iText = "", int a_iMax = 1)
        {
            while (true)
            {
                if (a_iText != "")
                    Console.WriteLine(a_iText);


                if (int.TryParse(Console.ReadLine(), out int _iValue) == true)
                {
                    return _iValue;
                }
            }

        }
        public static string EnterText(string a_sText = "", bool a_bCanBeEmpty = true, int a_Lenght = 255)
        {
            while (true)
            {
                if (a_sText != "")
                    Console.WriteLine(a_sText);
                
                string _sValue = Console.ReadLine();

                if (string.IsNullOrEmpty(_sValue) && a_bCanBeEmpty == false && _sValue.Length > a_Lenght)
                {
                    Console.WriteLine($"Nie wpisano wartości O.o .... lub jest dluzsza niz {a_Lenght}");
                }
                else
                    return _sValue;
            }
        }
    }
}
