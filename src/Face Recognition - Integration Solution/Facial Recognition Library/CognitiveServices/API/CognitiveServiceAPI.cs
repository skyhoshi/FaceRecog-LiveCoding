

using Facial_Recognition_Library.API.Results;

namespace Facial_Recognition_Library.API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    /// <summary>
    /// 
    /// </summary>
    public class CognitiveServiceAPI
    {
        // **********************************************
        // *** Update or verify the following values. ***
        // **********************************************

        // Replace the subscriptionKey string value with your valid subscription key.
        string subscriptionKey => ServiceDetails.GetConfigurationValue("ServiceKey");

        // Replace or verify the region.
        //
        // You must use the same region in your REST API call as you used to obtain your subscription keys.
        // For example, if you obtained your subscription keys from the westus region, replace 
        // "westcentralus" in the URI below with "westus".
        //
        // NOTE: Free trial subscription keys are generated in the westcentralus region, so if you are using
        // a free trial subscription key, you should not need to change this region.
        private string uriBase => $"{ServiceDetails.GetConfigurationValue("ServiceURI")}/detect/";

        public bool ThrowErrorToParent { get; set; } = false;

        public class APISettings
        {
            //#region Face List
            ////Create A Face List
            //public const string faceListPUTQuerystring = "facelists/{faceListId}";
            //public const string faceListPOSTQuerystring = "";
            //public const string faceListDELETEQueryString = "";
            //public const string faceListDELETEListQueryString = "";
            ///// <summary>
            ///// generates the Query string for the Face List API: 
            ///// </summary>
            ///// <param name="FaceListID"></param>
            ///// <returns></returns>
            //public static string CreateFaceListPUTQueryString(string FaceListID)
            //{
            //    if (FaceListID.Length > 64) throw new ArgumentOutOfRangeException($"{nameof(FaceListID)} is too long, please reduce the number chacaters used.");
            //    return faceListPUTQuerystring.ToString().Replace("{faceListId}", FaceListID);
            //}
            //#endregion

        }

        private static HttpClientHandler httpClientHandler;


        private static HttpClient hcClient;

        public CognitiveServiceAPI()
        {

        }

        #region Face API calls

        #region Face

        #region Face Detect
        //Face Detect requires an image upload to the system be it from the file system or a stream. 

        /// <summary>
        /// Gets the analysis of the specified image file by using the Computer Vision REST API.
        /// </summary>
        /// <param name="imageFilePath">The image file.</param>
        public string RequestFaceDetect(string imageFilePath, ref HttpClient client)
        {


            //HttpClient client = new HttpClient();

            // Request headers.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

            // Request parameters. A third optional parameter is "details".
            //Create a Package out of these Parameters: (and a ToJSON Builder Override) 
            string requestParameters = "returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses,emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";

            // Assemble the URI for the REST API Call.
            string uri = uriBase + "?" + requestParameters;

            HttpResponseMessage response;

            // Request body. Posts a locally stored JPEG image.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            string contentString = "";
            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                // This example uses content type "application/octet-stream".
                // The other content types you can use are "application/json" and "multipart/form-data".
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                // Execute the REST API call.
                response = client.PostAsync(uri, content).Result;

                // Get the JSON response.
                contentString = response.Content.ReadAsStringAsync().Result;

                // Display the JSON response.
                System.Diagnostics.Debug.WriteLine("\nResponse:\n");
                System.Diagnostics.Debug.WriteLine(JsonPrettyPrint(contentString));

            }
            return contentString;
        }

        /// <summary>
        /// Gets the analysis of the specified image file by using the Computer Vision REST API.
        /// </summary>
        /// <param name="imageFilePath">The image file.</param>
        public string RequestFaceDetect(MemoryStream imgStream, QueryStringBuilder qsb, ref HttpClient client)
        {
            if (qsb == null)
            {
                qsb.IncludeFaceID = true;
                qsb.IncludeFaceLandmarks = true;
            }
            //HttpClient client = new HttpClient();

            // Request headers.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

            // Request parameters. A third optional parameter is "details".
            //Create a Package out of these Parameters: (and a ToJSON Builder Override) 
            //Original Query String
            //"returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses,emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";
            string requestParameters = qsb.ToString();

            // Assemble the URI for the REST API Call.
            string uri = uriBase;
            if (!string.IsNullOrWhiteSpace(requestParameters))
                uri = uri + "?" + requestParameters;

            client.BaseAddress = new Uri(uri);

            HttpResponseMessage response;

            // Request body. Posts a locally stored JPEG image.
            byte[] byteData = imgStream.ToArray();

            string contentString = "";
            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                // This example uses content type "application/octet-stream".
                // The other content types you can use are "application/json" and "multipart/form-data".
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                // Execute the REST API call.
                response = client.PostAsync(uri, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Get the JSON response.
                    contentString = response.Content.ReadAsStringAsync().Result;

                    // Display the JSON response.
                    System.Diagnostics.Debug.WriteLine("\nResponse:\n");
                    System.Diagnostics.Debug.WriteLine(JsonPrettyPrint(contentString));
                }
                else
                {
                    string failedContentString = "";
                    try
                    {
                        failedContentString = response.Content.ReadAsStringAsync()?.Result;
                    }
                    catch (Exception e)
                    {
                        //We don't want to really catch this failure. we want to continue on if it fails. 
                    }
                    throw new HttpRequestException($"{response.ReasonPhrase} : {failedContentString}");
                }
            }
            return contentString;
        }


        public List<Facial_Recognition_Library.API.Results.FaceDetectFaceResult> GetFaceDetectResult(MemoryStream ms, ref HttpClient client)
        {
            QueryStringBuilder qsb = new QueryStringBuilder() { IncludeFaceID = true, IncludeFaceLandmarks = true };
            string APIReturn = "";
            try
            {
                APIReturn = RequestFaceDetect(ms, qsb, ref client);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write(e);
                Console.WriteLine(e);
                if (ThrowErrorToParent) throw e;
            }
            List<FaceDetectFaceResult> fdr = null;
            if (!string.IsNullOrWhiteSpace(APIReturn))
            {
                fdr = Facial_Recognition_Library.API.Results.FaceApiFaceDetectResult.FromJson(APIReturn);
            }
            return fdr;
        }
        #endregion
        #region Find Similar
        //Find Similar uses "Face List" 


        #endregion
        #region Group - (Similar faces)

        #endregion
        #region Identify

        #endregion
        #endregion

        #region Face List

        #endregion

        #region Person

        #endregion

        #region Person Group

        #endregion

        #endregion

        #region Image Functions
        /// <summary>
        /// Returns the contents of the specified file as a byte array.
        /// </summary>
        /// <param name="imageFilePath">The image file to read.</param>
        /// <returns>The byte array of the image data.</returns>
        public static byte[] GetImageAsByteArray(string imageFilePath)
        {
            FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }
        #endregion

        /// <summary>
        /// Formats the given JSON string by adding line breaks and indents.
        /// </summary>
        /// <param name="json">The raw JSON string to format.</param>
        /// <returns>The formatted JSON string.</returns>
        static string JsonPrettyPrint(string json)
        {
            if (string.IsNullOrEmpty(json))
                return string.Empty;

            json = json.Replace(Environment.NewLine, "").Replace("\t", "");

            StringBuilder sb = new StringBuilder();
            bool quote = false;
            bool ignore = false;
            int offset = 0;
            int indentLength = 3;

            foreach (char ch in json)
            {
                switch (ch)
                {
                    case '"':
                        if (!ignore) quote = !quote;
                        break;
                    case '\'':
                        if (quote) ignore = !ignore;
                        break;
                }

                if (quote)
                    sb.Append(ch);
                else
                {
                    switch (ch)
                    {
                        case '{':
                        case '[':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', ++offset * indentLength));
                            break;
                        case '}':
                        case ']':
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', --offset * indentLength));
                            sb.Append(ch);
                            break;
                        case ',':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', offset * indentLength));
                            break;
                        case ':':
                            sb.Append(ch);
                            sb.Append(' ');
                            break;
                        default:
                            if (ch != ' ') sb.Append(ch);
                            break;
                    }
                }
            }

            return sb.ToString().Trim();
        }
    }
}

