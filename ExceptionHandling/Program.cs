using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            DivideByZero();

            YouTubeCustomException();

            StreamReaderException();

            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception Ex)
            {

                Console.WriteLine("Sorry an unexpected error occurred " + Ex.Message);
            }
        }

        private static void StreamReaderException()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\file.zip");
                var content = streamReader.ReadToEnd();
                throw new Exception("Oopsie");
            }
            catch (Exception)
            {

                Console.WriteLine("Sorry an unexpected error occurred ");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }

        private static void YouTubeCustomException()
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DivideByZero()
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);

            }
            catch (DivideByZeroException Ex)
            {
                Console.WriteLine("Sorry you can't divide by zero: " + Ex.Message);
            }
            catch (ArithmeticException Ex)
            {
                Console.WriteLine("Sorry some arithmetic error occurred " + Ex.Message);
            }
            catch (Exception Ex)
            {

                Console.WriteLine("Sorry an unexpected error occurred " + Ex);
            }
            finally
            {
                Console.WriteLine("let me clean that up for you");
            }
        }
    }
}
