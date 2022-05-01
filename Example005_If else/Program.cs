Console.Write("enter name user: ");
string username = Console.ReadLine();

if (username.ToLower() == "steelplated")
{
    Console.WriteLine("quality assurance");
}
else
{
    Console.Write("Q, ");
    Console.WriteLine(username);
}