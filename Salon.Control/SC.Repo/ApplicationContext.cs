using System.Data.Entity;

namespace SC.Repo
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(): base("")
        {
        }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
