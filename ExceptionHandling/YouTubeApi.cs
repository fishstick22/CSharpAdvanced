using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service 
                // Read the data 
                // Create a list of Video objects
                if ("mosh".Equals(user))
                {
                    throw new Exception("Oops some low level YouTube error.");
                }

            }
            catch (Exception ex)
            {
                // Log 

                throw new YouTubeException("Could not fetch the videos from YouTube.", ex);
            }

            return new List<Video>();
        }
    }
}
