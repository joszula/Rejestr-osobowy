using System;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace Rejestr_osobowy
{
    class Program
    {

        static void Main(string[] args)
        {
        Menu menu = new Menu();
        menu.Run();

        }
    }
}