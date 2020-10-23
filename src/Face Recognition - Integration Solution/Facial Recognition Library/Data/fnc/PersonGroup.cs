using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Facial_Recognition_Library.API;
using Facial_Recognition_Library.Data.tbls;

namespace Facial_Recognition_Library.Data.fnc
{
    public class PersonGroup
    {
        public class PersonGroupOperationStatus
        {
            public bool AttemptedDatabaseOperation { get; set; }
            public bool AttemptedAPIOperation { get; set; }

            public bool CompletedDatabaseOperation { get; set; }
            public bool CompletedAPIOperation { get; set; }

            public string ReasonForFailure { get; set; }
        }
        public static async Task<PersonGroupOperationStatus> CreatePersonGroup(string PersonGroupName, string PersonGroupId)
        {
            bool rtnStatus = false;
            PersonGroupOperationStatus status = new PersonGroupOperationStatus();
            ////////////////////////////////////////////////////////////////////////////////////
            string uuidSystemID = "";
            try
            {
                ////////////////////////////////////////////////////////////////////////////////////
                status.AttemptedDatabaseOperation = true;
                using (var db = new Facial_Recognition_Library.Data.LiveEduFaceModel())
                {
                    MyPersonGroup PersonGroup = new MyPersonGroup
                    {
                        Name = PersonGroupName,
                        IDApi = PersonGroupId
                    };
                    status.CompletedDatabaseOperation = MyPersonGroup.AddPersonGroup(db, ref PersonGroup);
                    uuidSystemID = PersonGroup.IDApi;
                }
                status.CompletedDatabaseOperation = true;
                ////////////////////////////////////////////////////////////////////////////////////
                status.AttemptedAPIOperation = true;
                await ProjectOxfordAPI.CreatePersonGroup(PersonGroupId, PersonGroupName, uuidSystemID);
                status.CompletedAPIOperation = true;
                ////////////////////////////////////////////////////////////////////////////////////
            }
            catch (Exception e)
            {
                status.ReasonForFailure = $"Attempts made to update database and api failed : {e.Message}";
            }
            return status;
        }

        public static async Task<PersonGroupOperationStatus> DeletePersonGroup(string PersonGroupId)
        {
            bool rtnStatus = false;
            PersonGroupOperationStatus status = new PersonGroupOperationStatus();
            ////////////////////////////////////////////////////////////////////////////////////
            Guid uuidSystemID = Guid.Empty;
            ////////////////////////////////////////////////////////////////////////////////////
            status.AttemptedDatabaseOperation = true;
            try
            {
                using (var db = new Facial_Recognition_Library.Data.LiveEduFaceModel())
                {
                    status.CompletedDatabaseOperation = MyPersonGroup.DeletePersonGroupById(db, PersonGroupId);
                }
                status.CompletedDatabaseOperation = true;
            }
            catch (Exception e)
            {
                status.ReasonForFailure += $"Failed to remove from database {e.Message} |";
            }

            ////////////////////////////////////////////////////////////////////////////////////
            status.AttemptedAPIOperation = true;
            try
            {

                await ProjectOxfordAPI.DeletePersonGroup(PersonGroupId);
                status.CompletedAPIOperation = true;
            }
            catch (Exception e)
            {
                status.ReasonForFailure += $"Failed to remove from api {e.Message} |";
            }
            ////////////////////////////////////////////////////////////////////////////////////
            return status;
        }
    }
}
