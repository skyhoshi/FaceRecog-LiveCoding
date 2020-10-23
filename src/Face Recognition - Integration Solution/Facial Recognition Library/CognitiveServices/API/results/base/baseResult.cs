using Newtonsoft.Json;

namespace Facial_Recognition_Library.API.Results
{
    /// <summary>
    /// base Results : Shared methods across all "Results" (API Json Return) Classes.
    /// </summary>
    public abstract class baseResult
    {
        /// <summary>
        /// used to represent the class as a JSON String
        /// </summary>
        /// <returns></returns>
        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this, Converter.Settings);
        }
    }
}