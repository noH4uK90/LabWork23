using LabWorkLibrary;
using LabWorkLibrary.UserData;

Console.WriteLine(Maths.PI);
Console.WriteLine(Maths.Sum(2.2, 6.68));
Console.WriteLine(Maths.Subtraction(2.2, 6.68));
Console.WriteLine(Maths.Multiplication(2.2, 6.68));
Console.WriteLine(Maths.Division(2.2, 6.68));
Console.WriteLine(Maths.Division(2.2, 0));
Console.WriteLine(Maths.SquareRectangle(2.2, 6.68));
Console.WriteLine(Maths.SquareRectangle(2.2, -2));

const UserRole role = UserRole.Administrator;
var user = new User
{
    Login = "Login123"
};
user.ChangePassword("12345");
user.ChangePrivilege(role);