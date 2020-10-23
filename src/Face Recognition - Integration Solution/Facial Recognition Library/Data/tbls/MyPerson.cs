using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facial_Recognition_Library.Data.tbls
{
    /// <summary>
    /// Represents the Person Object : <see cref="Microsoft.ProjectOxford.Face.Contract.PersonFace"/>
    /// </summary>
    public class MyPerson
    {
        [System.ComponentModel.DataAnnotations.Key(),
         System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public Guid SystemPersonId { get; set; }
        public Guid PersonId { get; set; }
        public virtual List<MyPersonFace> PersistedFaceIds { get; set; }
        public string Name { get; set; }
        public string UserData { get; set; }
        public string LastAction { get; set; }
        public DateTime? LastActionDateTime { get; set; } = DateTime.Now;

        public static bool AddPerson(LiveEduFaceModel db, ref MyPerson person)
        {
            person.LastAction = "ADD";
            person.LastActionDateTime = DateTime.Now;
            //Here is where the failure happens.
            throw new Exception("test");
            person = db.MyPersons.Add(person);
            return true;
        }

        public static bool DeletePersonById(LiveEduFaceModel db, string personGroupId, out Guid uuidPersonId)
        {
            throw new NotImplementedException();
        }
    }
}
