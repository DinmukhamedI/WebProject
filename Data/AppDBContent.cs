namespace WebProject.Data
{
    public class AppDBContent: DbContext
    {

        public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {

     }
    }
}
