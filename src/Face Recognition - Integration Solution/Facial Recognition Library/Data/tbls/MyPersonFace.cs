using System;

namespace Facial_Recognition_Library.Data.tbls
{
    public class MyPersonFace
    {
        [System.ComponentModel.DataAnnotations.Key(),
         System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public Guid SystemPersonFaceId { get; set; }
        public Guid FK_SystemPersonId { get; set; }
        /// <summary>
        /// API Identifier for the known ID of a face that will not expire. (Must be Deleted) 
        /// </summary>
        public Guid PersistedFaceId { get; set; }
    }
}