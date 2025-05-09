using System.Collections.Generic;

public interface IUserRepository
{
    List<User> GetAllUsers();
    User GetUserById(int id);
    void AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(int id);
}
