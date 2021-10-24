Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "даша")
{
    Console.WriteLine("Ура, это же Даша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}