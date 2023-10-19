Console.Write("Enter Username: ");
string username = Console.ReadLine();

if(username.ToLower() == "erke")
{
    Console.WriteLine("Hooray, it's Erke!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}