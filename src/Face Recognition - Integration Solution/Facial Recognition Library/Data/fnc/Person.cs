using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facial_Recognition_Library.API;
using Facial_Recognition_Library.Data.tbls;
using Facial_Recognition_Library.Migrations;

namespace Facial_Recognition_Library.Data.fnc
{
    public class PersonOperationStatus
    {
        public bool AttemptedDatabaseOperation { get; set; }
        public bool AttemptedAPIOperation { get; set; }

        public bool CompletedDatabaseOperation { get; set; }
        public bool CompletedAPIOperation { get; set; }

        public string ReasonForFailure { get; set; }
    }
    public class Person
    {
        public static async Task<PersonOperationStatus> CreatePerson(string strPersonGroupId, string strPersonName)
        {
            PersonOperationStatus status = new PersonOperationStatus();
            ////////////////////////////////////////////////////////////////////////////////////
            string strUserData = "";
            try
            {
                ////////////////////////////////////////////////////////////////////////////////////
                status.AttemptedDatabaseOperation = true;
                MyPerson person = new MyPerson();
                using (var db = new Facial_Recognition_Library.Data.LiveEduFaceModel())
                {
                    status.CompletedDatabaseOperation = MyPerson.AddPerson(db, ref person);
                }
                ////////////////////////////////////////////////////////////////////////////////////
                status.AttemptedAPIOperation = true;
                await ProjectOxfordAPI.CreatePerson(strPersonGroupId, strPersonName, strUserData);
                status.CompletedAPIOperation = true;
                ////////////////////////////////////////////////////////////////////////////////////
            }
            catch (Exception e)
            {
                status.ReasonForFailure = $"Attempts made to update database and api failed : {e.Message}";
            }
            return status;
        }
        public static async Task<PersonOperationStatus> DeletePerson(string PersonGroupId, string personId = null)
        {
            bool rtnStatus = false;
            PersonOperationStatus status = new PersonOperationStatus();
            ////////////////////////////////////////////////////////////////////////////////////
            Guid uuidPersonGuid = Guid.Empty;
            ////////////////////////////////////////////////////////////////////////////////////
            status.AttemptedDatabaseOperation = true;
            try
            {
                using (var db = new Facial_Recognition_Library.Data.LiveEduFaceModel())
                {
                    status.CompletedDatabaseOperation = MyPerson.DeletePersonById(db, PersonGroupId, out uuidPersonGuid);
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
                await ProjectOxfordAPI.DeletePerson(PersonGroupId, uuidPersonGuid);
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
