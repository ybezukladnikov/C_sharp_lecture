Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Max")
{
  Console.WriteLine("ПРивет Макс") ;
}
else
{
  Console.Write("Привет, ")  ; 
  Console.WriteLine(username)  ; 
}



