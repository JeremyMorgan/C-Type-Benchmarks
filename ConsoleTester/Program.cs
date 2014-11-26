using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {

            var webGet = new HtmlWeb();
            // load wccca page
            var document = webGet.Load("http://localhost/wccca/units.html");

            // Get all tables in the document
            HtmlNodeCollection tables = document.DocumentNode.SelectNodes("//table");

            // Iterate all rows in the first table
            HtmlNodeCollection rows = tables[0].SelectNodes(".//tr");
            for (int i = 0; i < rows.Count; ++i)
            {
                Console.WriteLine("----------");
                Console.WriteLine("Row: " + i);
                // this is where we write new

                // Iterate all columns in this row
                HtmlNodeCollection cols = rows[i].SelectNodes(".//td");
                for (int j = 0; j < cols.Count; ++j)
                {
                    
                    string value = cols[j].InnerText;
                    Console.WriteLine(value);
                }
            }

            Console.ReadLine();

        }
    }
}
