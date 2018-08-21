using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrimeNumbersGenerator
{
    public class FileManager
    {
        private string path;

        public FileManager()
        {
            path = Directory.GetCurrentDirectory() + @"\primes.xml";
            if (!File.Exists(path))
                CreateFile();
        }

        public void SetPath(string path)
        {
            this.path = path+ @"\primes.xml";

            if (!File.Exists(this.path))
                CreateFile();
        }

        public void CreateFile()
        {
            XDocument xml = new XDocument(
                new XDeclaration("1.0", "utf-8", "no"),
                new XElement("primes"));
            xml.Save(path);
        }

        public void Add(long number, int cycle, long cycleTime, long calculationTime)
        {
            var xml = XDocument.Load(path);

            XElement newPrimeNumber = new XElement("prime",
                new XElement("number", number),
                new XElement("cycle", cycle),
                new XElement("cycleTime", cycleTime + "ms"),
                new XElement("calculationTime", calculationTime + "ms")
            );

            xml.Root?.Add(newPrimeNumber);

            xml.Save(path);
        }

        public string ReadLastCycle()
        {
            var xml = XDocument.Load(path);

            if (xml.Root == null || xml.Root.IsEmpty)
                return "Brak danych";

            XElement lastElement = xml.Root.Descendants("prime").Last();

            var number = (from item in lastElement.Elements()
                         where item.Name == "number"
                         select item.Value).FirstOrDefault();

            var cycle = (from item in lastElement.Elements()
                         where item.Name == "cycle"
                          select item.Value).FirstOrDefault();

            var cycleTime = (from item in lastElement.Elements()
                         where item.Name == "cycleTime"
                         select item.Value).FirstOrDefault();

            var calculationTime = (from item in lastElement.Elements()
                         where item.Name == "calculationTime"
                         select item.Value).FirstOrDefault();

            if (calculationTime == "0ms")
                calculationTime = "<1ms";

            return "l. pierwsza: " + number +
                    "\r\ncykl nr : " + cycle +
                    "\r\nczas cyklu: " + cycleTime +
                    "\r\nczas obliczeń: " + calculationTime;
        }
    }
}
