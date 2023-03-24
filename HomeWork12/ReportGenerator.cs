using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ReportGenerator
    {
        public string GenerateHtmlReport()
        {
            var header = "My Header";

            var body = "\r\nVideo provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add.";

            var footer = "My Footer";

            return $"\u001b[33m<header>\u001b[om]{header}</header>\r\n<body>{body}\r\n</body>\r\n<footer>{footer}</footer>";
        }

        public string GeneratePdfReport()
        {

            var header = "I'm using Facade Pattern";

            var body = "Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add. You can also type a keyword to search online for the video that best fits yours document. To make your document look professionally produced, Word provides";

            var footer = "Page 1";

            return $"Header: {header}\nBody:\n{body}\nFooter: {footer}";
        }
    }
}

