using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Facial_Recognition_Library
{
    //https://stackoverflow.com/questions/202011/encrypt-and-decrypt-a-string
    public class Crypto
    {
        //While an app specific salt is not the best practice for
        //password based encryption, it's probably safe enough as long as
        //it is truly uncommon. Also too much work to alter this answer otherwise.

        private static string __coreSalt = "";
        private string _coreSalt
        {
            get { return __coreSalt; }
            set { __coreSalt = value; }
        }

        private static byte[] __salt = null;

        private static byte[] salt
        {
            get
            {
                if (__coreSalt != null)
                {
                    byte[] rt = System.Text.ASCIIEncoding.Default.GetBytes(__coreSalt);
                    /* Here we are going to use a random salt technic that I devised to allow you to encode each string stored differently.*/
                    return rt;
                }
                else if (__salt != null)
                {
                    return __salt;
                }
                else
                {
                    return null;
                }
            }
        }
        public byte[] _salt
        {
            get
            {
                if (__salt != null)
                {
                    return __salt;
                }
                else
                {
                    byte[] rt = System.Text.ASCIIEncoding.Default.GetBytes(__coreSalt);
                    /* Here we are going to use a random salt technic that I devised to allow you to encode each string stored differently.*/
                    return rt;
                }
            }
            protected internal set { __salt = value; }
        }

        public Crypto()
        {

        }

        public Crypto(string Salt)
        {
            this._coreSalt = Salt;
        }

        //public static string GetSharedSecret()
        //{
        //    return Facial_Recognition_Library.ServiceDetails.GetConfigurationValue(key: "PrivateSharedSecret");
        //}

        public static string EncryptedStringAES(string plainText)
        {
            string rtnString = "";
            string strSharedSecretForTest = Facial_Recognition_Library.ServiceDetails.GetConfigurationValue(key: "PrivateSharedSecret");
            string privatestring = ServiceDetails.GetConfigurationValue("ServicePasswordSalt");
            rtnString = Facial_Recognition_Library.Crypto.EncryptStringAES(plainText, strSharedSecretForTest, privatestring);
            return rtnString;
        }

        /// <summary>
        /// Encrypt the given string using AES.  The string can be decrypted using 
        /// DecryptStringAES().  The sharedSecret parameters must match.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for encryption.</param>
        /// <exception cref="Exception"></exception>
        public static string EncryptStringAES(string plainText, string sharedSecret, string strPrivateSalt = "")
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException(nameof(plainText));
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException(nameof(sharedSecret));

            if (!string.IsNullOrWhiteSpace(strPrivateSalt))
            {
                //this._coreSalt = strPrivateSalt;
                __coreSalt = strPrivateSalt;
            }

            string outStr = null;                       // Encrypted string to return
            RijndaelManaged aesAlg = null;              // RijndaelManaged object used to encrypt the data.

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, salt);

                // Create a RijndaelManaged object
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                // Create a decryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // prepend the IV
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            catch (ArgumentNullException ANEx) { }
            catch (ArgumentException AEx) { }
            catch (InvalidOperationException IOpEx) { }
            catch (Exception ex) { }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            // Return the encrypted bytes from the memory stream.
            return outStr;
        }

        /// <summary>
        /// Decrypt the given string.  Assumes the string was encrypted using 
        /// EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
        public string DecryptStringAES(string cipherText, string sharedSecret, string strPrivateSalt = "")
        {
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException(nameof(sharedSecret));

            if (!string.IsNullOrWhiteSpace(strPrivateSalt))
            {
                this._coreSalt = strPrivateSalt;
            }

            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
            RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create the streams used for decryption.                
                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    // Create a RijndaelManaged object
                    // with the specified key and IV.
                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    // Get the initialization vector from the encrypted stream
                    aesAlg.IV = ReadByteArray(msDecrypt);
                    // Create a decrytor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Stream did not contain properly formatted byte array");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Did not read byte array properly");
            }

            return buffer;
        }
    }
}