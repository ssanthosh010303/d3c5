/*
 * Author: Sakthi (Sandy) Santhosh
 * Created on: 11/04/2024
 *
 * Day-3 Challenge-5: Simple Login System
 */
namespace Challenge5;

class Program
{
    static void Main()
    {
        const string Username = "ABC";
        const string Password = "123";

        string? username, password;

        Console.Write("Enter username: ");
        username = Console.ReadLine();

        Console.Write("Enter password: ");
        password = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            return;

        Console.Write("\nResult\n  Login: ");
        Console.WriteLine((username == Username && password == Password)
            ? "Success"
            : "Fail");
    }
}
