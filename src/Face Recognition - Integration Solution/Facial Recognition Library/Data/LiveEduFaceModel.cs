using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Model;
using System.Resources;
using Facial_Recognition_Library.Data.tbls;

namespace Facial_Recognition_Library.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LiveEduFaceModel : DbContext
    {
        // Your context has been configured to use a 'LiveEduFaceModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Facial_Recognition_Library.Data.LiveEduFaceModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LiveEduFaceModel' 
        // connection string in the application configuration file.
        public LiveEduFaceModel() : base("name=LiveEduFaceModel") { }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<ApplicationUser> Users { get; set; }
        public virtual DbSet<MyFace> MyFaces { get; set; }
        public virtual DbSet<MyFaceList> MyFaceLists { get; set; }
        public virtual DbSet<MyPersonGroup> MyPersonGroups { get; set; }

        public virtual DbSet<MyPerson> MyPersons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class MySmile
    {
        public long value { get; set; }
        public virtual Guid FaceID { get; set; }
    }
}