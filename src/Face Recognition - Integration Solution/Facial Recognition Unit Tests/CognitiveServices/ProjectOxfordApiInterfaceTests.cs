using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Facial_Recognition_Library.API;
using Microsoft.ProjectOxford.Face.Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facial_Recognition_Unit_Tests.CognitiveServices
{
    [TestClass]
    public class ProjectOxfordApiInterfaceTests
    {
        private const string cstPersonGroupIDforTest = "pgtestid1";
        private const string cstPersonGroupNameforTest = "MyPersonGroup";
        CreatePersonResult PersonResult = null;
        AddPersistedFaceResult persistedFaceResult = null;

        [TestInitialize]
        public async Task Start()
        {
            await AddPersonGroup();
        }

        [TestCleanup]
        public async Task End()
        {
            //await DeletePersonGroup();
        }


        [TestMethod]
        public async Task AddPersonGroup()
        {
            await ProjectOxfordAPI.CreatePersonGroup(cstPersonGroupIDforTest, cstPersonGroupNameforTest, "TEST DATA: DELETE ME IF YOU CAN");
            //
            var PersonGroups = await ProjectOxfordAPI.GetAllPersonGroups();
            Assert.IsTrue(PersonGroups.Count > 0, "PersonGroups.Count !> 0");
            var TestGroup = PersonGroups.Where(pg => pg.PersonGroupId == cstPersonGroupIDforTest);
            if (!TestGroup.Any())
            {
                Assert.Fail("Couldn't Find Test group after addition.");
            }
        }

        [TestMethod]
        public async Task DeletePersonGroup()
        {
            var PersonGroups = await ProjectOxfordAPI.GetAllPersonGroups();
            if (PersonGroups.Any())
            {
                var TestGroup = PersonGroups.Where(pg => pg.PersonGroupId == cstPersonGroupIDforTest);
                if (TestGroup.Any())
                {
                    await ProjectOxfordAPI.DeletePersonGroup(cstPersonGroupIDforTest);
                }
            }
            else
            {
                Assert.Inconclusive($"Test not run due to missing data at api endpoint. Test Initialization should include PersonGroup ID:  {cstPersonGroupIDforTest}");
            }
        }

        [TestMethod]
        public async Task DeletePerson()
        {
            if (PersonResult != null)
            {
                await ProjectOxfordAPI.DeletePersonAsync(cstPersonGroupIDforTest, PersonResult.PersonId);
            }
            else
            {
                Assert.Inconclusive("Person Result is null so there's nothing to delete.");
            }
        }

        [TestMethod]
        public async Task AddPersonTest()
        {
            var PersonGroups = await ProjectOxfordAPI.GetAllPersonGroups();
            Assert.IsTrue(PersonGroups.Count > 0, "PersonGroups.Count !> 0");
            foreach (var personGroup in PersonGroups)
            {
                System.Diagnostics.Debug.WriteLine($"Person Group Name : {personGroup.Name} | Person Group ID : {personGroup.PersonGroupId}");


                PersonResult = await ProjectOxfordAPI.CreatePerson(personGroup.PersonGroupId, "MyOxfardFaceTest", "");

                if (PersonResult != null)
                {
                    //Considered successful test. 

                    //if (PersonResult.PersonId != Guid.Empty)
                    //{
                    //    await DeletePerson();
                    //}
                    //else
                    //{
                    //    Assert.Fail("Person ID was null");
                    //}
                }
                else
                {
                    Assert.Fail("Person Result was null");
                }
            }
        }

        [TestMethod]
        public async Task AddFaceToPerson()
        {
            if (PersonResult == null)
            {
                await AddPersonTest();
            }
            string TestPictureLocation = $@"W:\Example Pictures\imgNov82017.png";

            using (Stream stream = File.OpenRead(TestPictureLocation))
            {
                persistedFaceResult = await ProjectOxfordAPI.AddPersonFaceAsync(cstPersonGroupIDforTest, PersonResult.PersonId, stream);
                Assert.IsTrue(persistedFaceResult != null, "item == null");

            }

        }

        [TestMethod]
        public async Task DeleteFaceFromPersonByPersistantFaceId()
        {
            if (persistedFaceResult == null)
            {
                await AddFaceToPerson();
            }
            await ProjectOxfordAPI.DeletePersonFaceAsync(cstPersonGroupIDforTest, PersonResult.PersonId, persistedFaceResult.PersistedFaceId);

        }

        [TestMethod]
        public async Task GetAllPersonsTest()
        {

        }
    }
}
