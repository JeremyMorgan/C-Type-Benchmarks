using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    class Tester
    {
        DateTime _date1;
        DateTime _date2;
        DateTime _date3;
        DateTime _date4;
        public string Unitname { get; set; }
        public int Callnum { get; set; }

        public void CreateDictionary()
        {
            var ourdictionary = new Dictionary<int,string>
            {
                {0, "1234"},
                {1, "Unit"},
                {2, "2014-11-25 21:39:07.000"},
                {3, "2014-11-25 21:39:07.000"},
                {4, "2014-11-25 21:39:07.000"},
                {5, "2014-11-25 21:39:07.000"}
            };


            Callnum = Int32.Parse(ourdictionary[0]);
            Unitname = ourdictionary[1];
            _date1 = DateTime.Parse(ourdictionary[2]);
            _date2 = DateTime.Parse(ourdictionary[3]);
            _date3 = DateTime.Parse(ourdictionary[4]);
            _date4 = DateTime.Parse(ourdictionary[5]);
            

        }
        public void CreateObject()
        {
            var ourUnitTest = new ObjectTester
            {
                Callnum = 1234,
                Unitname = "Unit",
                Date1 = DateTime.Parse("2014-11-25 21:39:07.000"),
                Date2 = DateTime.Parse("2014-11-25 21:39:07.000"),
                Date3 = DateTime.Parse("2014-11-25 21:39:07.000"),
                Date4 = DateTime.Parse("2014-11-25 21:39:07.000")
            };

            Callnum = ourUnitTest.Callnum;
            Unitname = ourUnitTest.Unitname;
            _date1 = ourUnitTest.Date1;
            _date2 = ourUnitTest.Date2;
            _date3 = ourUnitTest.Date3;
            _date4 = ourUnitTest.Date4;

        }
        public void CreateStruct()
        {
            var ourStructTest = new StructTester
            {
                Callnum = 1234,
                Unitname = "Unit",
                Date1 = DateTime.Parse("2014-11-25 21:39:07.000"),
                Date2 = DateTime.Parse("2014-11-25 21:39:07.000"),
                Date3 = DateTime.Parse("2014-11-25 21:39:07.000"),
                Date4 = DateTime.Parse("2014-11-25 21:39:07.000")
            };

            Callnum = ourStructTest.Callnum;
            Unitname = ourStructTest.Unitname;
            _date1 = ourStructTest.Date1;
            _date2 = ourStructTest.Date2;
            _date3 = ourStructTest.Date3;
            _date4 = ourStructTest.Date4;

        }
    }
}
