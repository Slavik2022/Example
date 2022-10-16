Console.Write("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "слава")
{
    Console.WriteLine("Ура, это же СЛАВА");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}