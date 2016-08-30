using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public class UnicodeFileToHtmlTextConverter
    {
        private readonly string _fullFilenameWithPath;
        private IFileProvider _fileProvider;

        public UnicodeFileToHtmlTextConverter(string fullFilenameWithPath) :  this(new FileProvider(fullFilenameWithPath))
        {

        }

        public UnicodeFileToHtmlTextConverter(IFileProvider fp)
        {
            _fileProvider = fp; 
        }

        public string ConvertToHtml()
        {
            using (TextReader  _unicodeFileStream = _fileProvider.GetReader())
            {
                string html = string.Empty;

                string line = _unicodeFileStream.ReadLine();
                while (line != null)
                {
                    html += HttpUtility.HtmlEncode(line);
                    html += "<br />";
                    line = _unicodeFileStream.ReadLine();
                }

                return html;
            }
        }
    }
}
