using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security;
using KeePassLib;
using KeePassLib.Collections;
using KeePassLib.Interfaces;
using KeePassLib.Keys;
using KeePassLib.Serialization;
using config = System.Configuration.ConfigurationManager;

namespace Facial_Recognition_Library
{
    public class ServiceDetails
    {
        /*
         *TODO: Regenerate Salt for Keys
         * Open C# Interactive from the View menu | View -> Other Windows -> C# interactive : in most cases it will pop up next to the Output window.
         * Copy paste the line below to generate a new text based Guid. (Guid as Text) Copy paste and replace the keys above generate 4 new Salt Keys. 
         * Guid.NewGuid().ToJSON();
          Example : "13d7e13e-a63c-42ce-beff-e5d6346d949d", "cb3562e3-0d49-47c4-b9e2-49506259afe6", "c198bcd6-af01-46ba-a902-57973b621899","20831b9b-93be-433f-92d4-aa87cb997ba1"
             */
        //public static List<string> ServiceKeysForSaltLookup = new List<string> { "13d7e13e-a63c-42ce-beff-e5d6346d949d", "cb3562e3-0d49-47c4-b9e2-49506259afe6", "c198bcd6-af01-46ba-a902-57973b621899", "20831b9b-93be-433f-92d4-aa87cb997ba1" };


        public static string GetConfigurationValue(string key)
        {

            //String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            //String strFilePath = Path.Combine(strAppPath, "Resources");
            //String strFullFilename = Path.Combine(strFilePath, "MyFaceRecongnitionApplicationDB.kdbx");

            //string dbpath = @"W:\MyFaceRecongnitionApplicationDB.kdbx";
            //string keypath = $@"W:\MyFaceRecongnitionApplicationDB.key";

            var ioConnInfo = new IOConnectionInfo { Path = "" };

            var compKey = new CompositeKey();
            compKey.AddUserKey(new KcpKeyFile(new MemoryStream(Facial_Recognition_Library.Properties.Resources.MyFaceRecongnitionApplicationDBKey), "MyFaceRecongnitionApplicationDB"));
            //compKey.AddUserKey(new KcpPassword(masterpw));
            //This is a do nothing logger but the Interface should be implimented if you are going to make your application public, I recommend creating an applications insights account and using the logger to write trace events to that service.
            IStatusLogger d = new NullStatusLogger();
            KeePassLib.PwDatabase db = new PwDatabase();

            ioConnInfo.StreamFileName = "MyFaceRecongnitionApplicationDB";
            ioConnInfo.Stream = new MemoryStream(Facial_Recognition_Library.Properties.Resources.MyFaceRecongnitionApplicationDB);

            db.Open(ioConnInfo, compKey, d);

            /*
             * This could cause a problem. if I move the Service Type into another Assembly this would be incorrect or bomb if no additional app.config settings file was available.
             *  in other words if the config file doesn't contain the appropreate keys, this will throw an error, you could add additional reference checks to see if any other
             *  referenced dlls contain a config file in the directory.
             *  Another method is to have certian types of key's stored in certain locations, Passwords and such in asecure location and other settings (user|Application) 
             *  stored in the Registry or user path. 
             *  This sets you up to do just that.
             *  Check out the http://keepass.info source, and consider including it in your applicaitons to store password or encoded information. 
             */

            //First: Retrieve the Encryption Salt
            //Second: Get Private Key
            string PrivateKey = GetValueFromDB(ref db, "PrivateSharedSecret");
            string Salt = GetValueFromDB(ref db, "ServicePasswordSalt");
            if (string.IsNullOrWhiteSpace(PrivateKey))
            {
                throw new Exception("Private Key value was not found.");
            }
            if (string.IsNullOrWhiteSpace(Salt))
            {
                throw new Exception("Salt value was not found.");
            }

            Assembly service = Assembly.GetAssembly(typeof(Facial_Recognition_Library.ServiceDetails));
            //Here is where you can adjust the configruation file that is opened as apart of Configuration retrieval.
            //Configuration config = ConfigurationManager.OpenExeConfiguration(service.Location);
            
            var myCrypto = new Facial_Recognition_Library.Crypto();
            if (!string.IsNullOrWhiteSpace(config.AppSettings[key]))
            {
                string ConfigValue = config.AppSettings[key];
                string ConfigsThatAreEncrypted = config.AppSettings["EncryptedArray"];
                if (ConfigsThatAreEncrypted.Contains(key))
                {
                    ConfigValue = myCrypto.DecryptStringAES(ConfigValue, PrivateKey, Salt);
                }
                return ConfigValue;
            }
            else
            {
                //Use K to process the Encrypted Key
                string KeyValue = config.AppSettings[key];
                if (string.IsNullOrWhiteSpace(KeyValue))
                {
                    string value = GetValueFromDB(ref db, key);
                    return value;
                }
                else
                {
                    string value = Facial_Recognition_Library.Crypto.EncryptStringAES(KeyValue, PrivateKey, Salt);
                    return value;
                }
            }
        }

        protected static string GetValueFromDB(ref KeePassLib.PwDatabase pdb, string SearchString = "")
        {
            if (string.IsNullOrWhiteSpace(SearchString))
            {
                throw new ArgumentException("Search String Cannot be blank");
            }
            //byte[] keyBytes = System.Text.Encoding.Default.GetBytes(key); //new []{ System.Text.EncodingInfo}
            //Guid i = Guid.Parse(key);
            //var pwUuID = new PwUuid(i.ToByteArray());
            SearchParameters sp = new SearchParameters();
            sp.SearchInStringNames = true;
            sp.SearchString = SearchString;
            PwObjectList<PwEntry> pwl = new PwObjectList<PwEntry>();
            pdb.RootGroup.SearchEntries(sp, pwl);
            string k = string.Empty;
            foreach (var entry in pwl)
            {
                foreach (var l in entry.Strings.ToList())
                {
                    if (l.Key == "Password")
                    {
                        k = l.Value.ReadString();
                    }
                }
            }
            return k;
        }



        protected static System.Security.SecureString GetServiceUserPassword()
        {
            // Instantiate the secure string.
            SecureString securePwd = new SecureString();

            //Get Value from App.Config

            //ConsoleKeyInfo key;

            //Console.Write("Enter password: ");
            //do
            //{
            //    key = Console.ReadKey(true);

            //    // Ignore any key out of range.
            //    if (((int)key.Key) >= 65 && ((int)key.Key <= 90))
            //    {
            //        // Append the character to the password.
            //        securePwd.AppendChar(key.KeyChar);
            //        Console.Write("*");
            //    }
            //    // Exit if Enter key is pressed.
            //} while (key.Key != ConsoleKey.Enter);
            //Console.WriteLine();

            //try
            //{
            //    Process.Start("Notepad.exe", "MyUser", securePwd, "MYDOMAIN");
            //}
            //catch (Win32Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    securePwd.Dispose();
            //}
            return securePwd;
        }
    }
}

