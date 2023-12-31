namespace PandoraCaseTest.Models
{
    public class EFUserRepository : IUserRepository
    {
        private MyDbContext context;
        public EFUserRepository(MyDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<User> Users => context.Users;

        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void RemoveUser(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            //DO ZROBIENIA
        }
        public bool ExistUser(User user)
        {
            foreach (var user_i in context.Users)
            {
                if(user.Login == user_i.Login && user.Pass == user_i.Pass)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
