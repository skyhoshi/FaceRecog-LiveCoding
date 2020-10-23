using System;
using System.Runtime.Serialization;

namespace Facial_Recognition_Library.Controls
{
    [Serializable]
    internal class DataGridViewsFaceDetectException : Exception
    {
        public DataGridViewsFaceDetectException()
        {

        }

        public DataGridViewsFaceDetectException(string message) : base(message)
        {
            _Message = message;
        }

        public DataGridViewsFaceDetectException(string message, Exception innerException) : base(message, innerException)
        {
            _Message = message;
        }

        protected DataGridViewsFaceDetectException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
           
        }
        #region Overrides of Exception

        public string _Message = string.Empty;
        
        /// <summary>Gets a message that describes the current exception.</summary>
        /// <returns>The error message that explains the reason for the exception, or an empty string ("").</returns>
        public override string Message => _Message;
        #endregion

    }
}