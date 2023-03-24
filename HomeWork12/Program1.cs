using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Channels;
using static Task3.ReportGenerator;

namespace Task3
{
    public class Program1
    {
        public static void Main()
        {
            var reportGenerator = new ReportGenerator();

            var htmlReport = reportGenerator.GenerateHtmlReport();
            Console.WriteLine(htmlReport);

            var pdfReport = reportGenerator.GeneratePdfReport();
            Console.WriteLine(pdfReport);
        }
    }
}

