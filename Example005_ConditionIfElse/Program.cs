Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "george")
{
    Console.WriteLine("Well, Hi there, cutie");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}