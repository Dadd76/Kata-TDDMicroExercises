using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public interface IFileProvider
    {
       TextReader GetReader();
    }

    public class FileProvider : IFileProvider
    {
        TextReader unicodeFileStream;

        public FileProvider(string filePath)
        {
            unicodeFileStream = File.OpenText(filePath);
        }

        public TextReader GetReader()
        {
            return unicodeFileStream;
        }
    }

}
