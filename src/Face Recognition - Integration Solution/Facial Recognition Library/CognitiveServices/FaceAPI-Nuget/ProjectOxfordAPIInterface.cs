using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;

namespace Facial_Recognition_Library.API
{
    public static class ProjectOxfordAPI
    {
        #region Call Monitor (Call Limiter to # Calls Per Second)
        const int PersonCount = 10000;
        const int CallLimitPerSecond = 10;
        static Queue<DateTime> _timeStampQueue = new Queue<DateTime>(CallLimitPerSecond);

        static async Task WaitCallLimitPerSecondAsync()
        {
            Monitor.Enter(_timeStampQueue);
            try
            {
                if (_timeStampQueue.Count >= CallLimitPerSecond)
                {
                    TimeSpan timeInterval = DateTime.UtcNow - _timeStampQueue.Peek();
                    if (timeInterval < TimeSpan.FromSeconds(1))
                    {
                        await Task.Delay(TimeSpan.FromSeconds(1) - timeInterval);
                    }
                    _timeStampQueue.Dequeue();
                }
                _timeStampQueue.Enqueue(DateTime.UtcNow);
            }
            finally
            {
                Monitor.Exit(_timeStampQueue);
            }
        }
        #endregion

        //Face API Service Client
        private static Microsoft.ProjectOxford.Face.FaceServiceClient fsClient = new FaceServiceClient(ServiceDetails.GetConfigurationValue("ServiceKey"), "https://eastus2.api.cognitive.microsoft.com/face/v1.0");

        //Create FaceList
        #region Face List Methods
        //public static async Task<bool> CreateFaceList(string FaceListId, string FaceListName, string ExtraUserData)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FaceListId"></param>
        /// <param name="FaceListName"></param>
        /// <param name="ExtraUserData"></param>
        /// <returns></returns>
        public static async Task<bool> CreateFaceList(string FaceListId, string FaceListName, string ExtraUserData)
        {
            try
            {
                await fsClient.CreateFaceListAsync(FaceListId, FaceListName, ExtraUserData);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            //try
            //{
            //    AsyncHelpers.RunSync(() => fsClient.CreateFaceListAsync(FaceListId, FaceListName, ExtraUserData));
            //    return true;
            //}
            //catch (Exception e)
            //{
            //    System.Diagnostics.Debug.WriteLine(e);
            //    throw;
            //}
            //return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FaceListID"></param>
        /// <param name="Image"></param>
        /// <param name="UserData"></param>
        /// <param name="FaceRectangle"></param>
        /// <returns></returns>
        public static async Task<Guid> AddFaceToFaceListByFaceListID(string FaceListID, Stream Image, string UserData = null, FaceRectangle FaceRectangle = null)
        {
            AddPersistedFaceResult FacePersistantID = null;

            FacePersistantID = await fsClient.AddFaceToFaceListAsync(FaceListID, Image, UserData, FaceRectangle);

            //FacePersistantID = AsyncHelpers.RunSync(() =>
            // {
            //     return fsClient.AddFaceToFaceListAsync(FaceListID, Image, UserData, FaceRectangle);
            // });
            return FacePersistantID.PersistedFaceId;
        }

        /// <summary>
        /// get a list of faceLists from the API. (meta data only) 
        /// </summary>
        /// <returns></returns>
        public static async Task<ICollection<FaceListMetadata>> GetAllFaceLists()
        {
            return await fsClient.ListFaceListsAsync();
        }


        /// <summary>
        /// Remove Face List from API
        /// </summary>
        /// <param name="faceListId"></param>
        /// <returns></returns>
        public static async Task<bool> DeleteFaceListByFaceListID(string faceListId)
        {
            try
            {
                await fsClient.DeleteFaceListAsync(faceListId);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

            //try
            //{
            //    AsyncHelpers.RunSync(() => fsClient.DeleteFaceListAsync(faceListId));
            //    return true;
            //}
            //catch (Exception e)
            //{
            //    return false;
            //}
        }

        public static async Task<List<Microsoft.ProjectOxford.Face.Contract.PersonFace>> GetPersonsInFaceListByFaceListIDAsync(string strfaceList)
        {
            var item = await fsClient.GetFaceListAsync(strfaceList);
            return item.PersistedFaces.ToList();
        }

        #endregion


        #region Person Methods

        public static async Task DeletePersonFaceAsync(string strPersonGroupId, Guid uidPersonId, Guid uidPersistedFaceId)
        {
            try
            {
                await fsClient.DeletePersonFaceAsync(strPersonGroupId, uidPersonId, uidPersistedFaceId);
            }
            catch (Exception e)
            {
                return;
                throw;
            }
        }

        public static async Task<AddPersistedFaceResult> AddPersonFaceAsync(string strPersonGroupId, Guid personId, Stream stream, string strUserData = null, FaceRectangle faceRectangle = null)
        {
            AddPersistedFaceResult addPersistedFaceResult = null;
            addPersistedFaceResult = await fsClient.AddPersonFaceAsync(strPersonGroupId, personId, stream, strUserData, faceRectangle);
            return addPersistedFaceResult;
        }

        public static async Task CreatePersonGroup(string strPersonGroupId, string strName, string strUserData = null)
        {
            try
            {
                await fsClient.CreatePersonGroupAsync(strPersonGroupId, strName, strUserData);
            }
            catch (Exception e)
            {
                //throw;
                return;
            }
        }

        public static async Task DeletePersonGroup(string strPersonGroupId)
        {
            try
            {
                await fsClient.DeletePersonGroupAsync(strPersonGroupId);
            }
            catch (Exception e)
            {
                //throw;
                return;
            }
        }

        public static async Task<CreatePersonResult> CreatePerson(string strPersonGroupID, string strPersonName, string strUserData = null)
        {
            //TODO: Add Parameter Validation
            CreatePersonResult item = await fsClient.CreatePersonAsync(strPersonGroupID, strPersonName, strUserData);
            return item;
        }

        /// <summary>
        /// Used to take one person from one group and add them to another. (Does not delete person from first person group) 
        /// </summary>
        /// <param name="strPersonGroupId"></param>
        /// <param name="uidPersonId"></param>
        /// <param name="imgStrImageStream"></param>
        /// <param name="strUserData"></param>
        /// <param name="frTargetFace"></param>
        /// <returns></returns>
        public static async Task<AddPersistedFaceResult> AddExsitingPersonToPersonGroup(string strPersonGroupId, Guid uidPersonId, Stream imgStrImageStream, string strUserData, FaceRectangle frTargetFace)
        {
            AddPersistedFaceResult item = await fsClient.AddPersonFaceAsync(strPersonGroupId, uidPersonId, imgStrImageStream, strUserData, frTargetFace);
            return item;
        }

        public static async Task<List<Person>> GetAllPersonsInPersonGroup(string strPersonGroupId)
        {
            var items = await fsClient.ListPersonsAsync(strPersonGroupId);
            return items.ToList();
        }

        public static async Task DeletePersonAsync(string strPersonGroupId, Guid uidPersonId)
        {
            try
            {
                await fsClient.DeletePersonAsync(strPersonGroupId, uidPersonId);
            }
            catch (Exception e)
            {
                //Add Handling here. not really needed unless you need to ensure deletion. maybe someday I'll add some :) 
                //throw;
                return;
            }
        }
        #endregion

        public static async Task<Microsoft.ProjectOxford.Face.Contract.Face[]> DetectFace(MemoryStream msImage)
        {
            var items = FaceAttributeType.Age
                        | FaceAttributeType.Gender
                        | FaceAttributeType.HeadPose
                        | FaceAttributeType.Smile
                        | FaceAttributeType.FacialHair
                        | FaceAttributeType.Glasses
                        | FaceAttributeType.Emotion
                        | FaceAttributeType.Hair
                        | FaceAttributeType.Makeup
                        | FaceAttributeType.Occlusion
                        | FaceAttributeType.Accessories
                        | FaceAttributeType.Blur
                        | FaceAttributeType.Exposure
                        | FaceAttributeType.Noise;

            IEnumerable<FaceAttributeType> fat = new List<FaceAttributeType>() {FaceAttributeType.Age
                                                                                , FaceAttributeType.Gender
                                                                                , FaceAttributeType.HeadPose
                                                                                , FaceAttributeType.Smile
                                                                                , FaceAttributeType.FacialHair
                                                                                , FaceAttributeType.Glasses
                                                                                , FaceAttributeType.Emotion
                                                                                , FaceAttributeType.Hair
                                                                                , FaceAttributeType.Makeup
                                                                                , FaceAttributeType.Occlusion
                                                                                , FaceAttributeType.Accessories
                                                                                , FaceAttributeType.Blur
                                                                                , FaceAttributeType.Exposure
                                                                                , FaceAttributeType.Noise
            };
            
            try
            {
                var faces = await fsClient.DetectAsync(msImage, true, true, fat);
                return faces;
            }
            catch (Exception e)
            {
                return null;
            }

        }


        public static async Task<List<PersonGroup>> GetAllPersonGroups()
        {
            return (await fsClient.ListPersonGroupsAsync()).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static async Task<List<Person>> GetAllPersonsFromAllPersonGroups()
        {
            //TODO: Consider passing in the list of person groups from the database INSTEAD of calling the API for them.
            List<Person> loPersons = new List<Person>();
            List<PersonGroup> loPersonGroups = new List<PersonGroup>();
            loPersonGroups = await GetAllPersonGroups();
            foreach (PersonGroup personGroup in loPersonGroups)
            {
                loPersons.AddRange(await fsClient.ListPersonsAsync(personGroup.PersonGroupId));
            }
            return loPersons;
        }

        public static async Task DeletePerson(string personGroupId, Guid personId)
        {
            await fsClient.DeletePersonAsync(personGroupId, personId);
        }
    }
}
