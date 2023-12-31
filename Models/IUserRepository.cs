namespace PandoraCaseTest.Models
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        void AddUser(User user);
        void RemoveUser(User user);
        void UpdateUser(User user); //DO ZROBIENIA
        bool ExistUser(User user);
    }
}
