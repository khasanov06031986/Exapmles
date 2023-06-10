Console.Write("ВВедите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "timur"){
    Console.Write(" Hello, how are you Timur?");
}
else {
    Console.Write(" Hello! " + username + " sorry, I'm didn't recognize you" );

}