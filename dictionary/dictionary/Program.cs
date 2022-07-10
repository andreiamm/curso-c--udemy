Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "Maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "99712234";
cookies["phone"] = "83737388";

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("Key not found");
}

Console.WriteLine($"Size: {cookies.Count()}");

foreach (KeyValuePair<string,string> cookie in cookies)
{
    Console.WriteLine(cookie.Key + ": " + cookie.Value);
}