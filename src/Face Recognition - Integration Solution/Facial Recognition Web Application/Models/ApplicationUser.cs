using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Facial_Recognition_Web_Application.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        #region Overrides of IdentityUser<string>

        /// <summary>Gets or sets the primary key for this user.</summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("SystemUserId"),Key]
        public override string Id { get; set; }

        #endregion

        public string EmailAddress { get; set; }

    }
}
