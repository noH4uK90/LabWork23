namespace LabWorkLibrary.UserData;

public class User
{
    private int _userId;
    private string _login;
    private string _password;
    private bool _privileged;

    /// <summary>
    /// Логин
    /// </summary>
    public string Login
    {
        get => _login;
        set => _login = string.IsNullOrWhiteSpace(value) ? _login : value;
    }
    
    /// <summary>
    /// Изменение пароля пользователя
    /// </summary>
    /// <param name="password">Новый пароль</param>
    /// <returns>Был сменен пароль или нет</returns>
    public bool ChangePassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password)
            || password == _password) return false;
        _password = password;
        return true;
    }
    
    /// <summary>
    /// Изменения уровня привелегии
    /// </summary>
    /// <param name="role">Новая роль пользователя</param>
    public void ChangePrivilege(UserRole role)
    {
        _privileged = role == UserRole.Administrator;
    }
}