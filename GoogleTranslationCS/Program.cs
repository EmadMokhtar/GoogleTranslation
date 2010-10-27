using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.API.Translate;

namespace GoogleTanslationCS
{
    class Program
    {
        static void Main(string[] args)
        {
            TranslateClient client = new TranslateClient("www.emadmokhtar.com");
            string tranlsated = client.Translate("أهلا و سهلا", "ar", "en");
            Console.WriteLine(tranlsated); //Welcome
            Console.ReadLine();
        }
    }
}
