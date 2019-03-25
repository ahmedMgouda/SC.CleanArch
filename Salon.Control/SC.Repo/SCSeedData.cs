using System.Data.Entity;

namespace SC.Repo
{
    public class SCSeedData : DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            //context.Commit();
        }
    }
}
