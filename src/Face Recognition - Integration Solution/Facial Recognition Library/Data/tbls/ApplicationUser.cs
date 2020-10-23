using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facial_Recognition_Library.Data.tbls
{
    public class ApplicationUser
    {
        #region Overrides of IdentityUser<string>

        /// <summary>Gets or sets the primary key for this user.</summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("SystemUserId"),Key]
        public string Id { get; set; }

        #endregion
        public string EmailAddress { get; set; }
    }

    public class MFA
    {
        private byte[] Image;
        private string securtyToken;
        private Guid SystemUserId;
        private string ValidationToken;
    }
}
