using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facial_Recognition_Library.Data.tbls
{
    public class MyFaceList : Microsoft.ProjectOxford.Face.Contract.FaceListMetadata
    {
        public MyFaceList()
        {
            ID = Guid.NewGuid();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public new string FaceListId { get; set; }
        public new string Name { get; set; }
        public new string UserData { get; set; }
        public DateTime AddeDateTime { get; set; } = DateTime.Now;
        public DateTime ModifiedDateTime { get; set; } = DateTime.Now;

    }
}
