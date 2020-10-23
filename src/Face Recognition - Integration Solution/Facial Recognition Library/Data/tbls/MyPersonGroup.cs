using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facial_Recognition_Library.Data.tbls
{
    public class MyPersonGroup
    {
        /// <summary>
        /// This is to be removed.
        /// </summary>
        [Obsolete("Do not use this property as it will be removed", true)]
        public Guid ID { get; set; }
        public string IDApi { get; set; }
        public string Name { get; set; }
        public string UserData { get; set; }
        public string Status { get; set; }
        public DateTime createDateTime { get; set; } = DateTime.Now;
        public string LastAction { get; set; }
        public DateTime? LastActionDateTime { get; set; } = DateTime.Now;
        public string StatusMessage { get; set; }
        /// <summary>
        /// System UserID denotes this Systems (local) User Identification : This ID is likely stored in the database along with additonal user data.
        /// </summary>
        /// <remarks>Not to be confused with the API or other systems USERID</remarks>
        [System.ComponentModel.DataAnnotations.Key(),
         System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public Guid SystemUserID { get; set; }
        /// <summary>
        /// Add person group to database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="PersonGroup"></param>
        /// <returns></returns>
        /// <remarks>Add's "Last Action" to object to keep track of adjustments</remarks>
        public static bool AddPersonGroup(LiveEduFaceModel db,ref MyPersonGroup PersonGroup)
        {
            PersonGroup.LastAction = "Add";
            PersonGroup.LastActionDateTime = DateTime.Now;
            PersonGroup = db.MyPersonGroups.Add(PersonGroup);
            return true;
        }

        public static bool DeletePersonGroupById(LiveEduFaceModel db, string personGroupId)
        {
            db.MyPersonGroups.Remove(db.MyPersonGroups.Single(pg => pg.IDApi == personGroupId));
            return true;
        }
    }
}
