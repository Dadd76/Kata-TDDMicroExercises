using System;
using NUnit.Framework;
using TDDMicroExercises.UnicodeFileToHtmlTextConverter;
using System.IO;

namespace TDDMicroExercisesUnitTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    [TestFixture]
    public class HtmlTextConverterTest
    {
        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItem(@"Sample.txt")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItem(@"ResultSample.txt")]
        public void TestMethod1()
        {

           // var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
           // var sourceFilePath = string.Format("{0}\\{1}", directory, "Sample.txt");
           // var resultFilePath = string.Format("{0}\\{1}", directory, "ResultSample.txt");

            var sourceFilePath = (@"Sample.txt");
            var resultFilePath = (@"ResultSample.txt");

            FileProvider sourceFileProvider = new FileProvider(sourceFilePath);
            FileProvider resultFileProvider = new FileProvider(resultFilePath);

            UnicodeFileToHtmlTextConverter HtmlConverter = new UnicodeFileToHtmlTextConverter(sourceFileProvider);
            TextReader unicodeFileStream                 = resultFileProvider.GetReader();

            var result = HtmlConverter.ConvertToHtml();
            var expected = unicodeFileStream.ReadToEnd();

            Assert.AreEqual(expected, result);
        }
    }
}
