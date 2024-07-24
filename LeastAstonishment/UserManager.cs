namespace LeastAstonishment;

// Class to manage any user modification or addition

public class UserManager
{
  private readonly List<User> _users;

  public UserManager()
  {
    _users = new List<User>();
  }

  public void AddUser(string username, string email, string password)
  {
    if (VerifyUniqueUser(username, email))
    {
      _users.Add(new User { Username = username, Email = email, Password = password });
    }
    else
    {
      Console.WriteLine("User or email is already being used");
    }
  }

  public void UpdateUserPassword(string username, string newPassword)
  {
    var user = GetSpecificUser(username);

    if (user != null)
    {
      if (string.IsNullOrWhiteSpace(newPassword))
      {
        throw new ArgumentException("New password cannot be empty.");
      }
      user.Password = newPassword;
    }
    else
    {
      Console.WriteLine($"User with username {username} not found.");
    }
  }

  public void SetUserRole(string username, string role)
  {
    var user = GetSpecificUser(username);

    if (user != null)
    {
      user.Role = role;
    }
  }

  public void DisplayUserDetails(string username)
  {
    var user = GetSpecificUser(username);

    if (user != null)
    {
      Console.WriteLine($"Username: {user.Username}, Email: {user.Email}, Role: {user.Role}");
    }
  }

  private User GetSpecificUser(string username)
  {
    return _users.FirstOrDefault(u => u.Username == username);
  }

  private bool VerifyUniqueUser(string username, string email)
  {
    foreach (var user in _users)
    {
      if (user.Username == username || user.Email == email)
      {
        return false;
      }
    }

    return true;
  }
}
