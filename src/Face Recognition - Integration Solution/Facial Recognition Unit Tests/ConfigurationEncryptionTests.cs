using System;
using Facial_Recognition_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using crypto = Facial_Recognition_Library.Crypto;

namespace Facial_Recognition_Unit_Tests
{
    [TestClass]
    public class ConfigurationEncryptionTests
    {
        [TestMethod]
        public void EncryptTest()
        {
            string strToEncrypt = "This is my string to encrypt";
            var crypto = new Facial_Recognition_Library.Crypto();

            //Facial_Recognition_Library.Crypto.GetSharedSecret();
            string strSharedSecretForTest = Facial_Recognition_Library.ServiceDetails.GetConfigurationValue(key: "PrivateSharedSecret");

            var encryptedValue = crypto.EncryptStringAES(strToEncrypt, strSharedSecretForTest, ServiceDetails.GetConfigurationValue("ServicePasswordSalt"));
            System.Diagnostics.Debug.WriteLine(encryptedValue);
            var ReDecrypted = crypto.DecryptStringAES(encryptedValue, strSharedSecretForTest);
            var d = crypto.EncryptStringAES(ReDecrypted, strSharedSecretForTest, ServiceDetails.GetConfigurationValue("ServicePasswordSalt"));
            //Assert.AreEqual(encryptedValue, d);
            Assert.AreEqual(ReDecrypted, strToEncrypt);
        }
    }
}
