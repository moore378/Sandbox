using static System.Console;

#error version

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(format: "{0, -10} {1,6}", arg0: "Name", arg1: "Count");

WriteLine("{0, -10} {1,6:N0}",  applesText,  applesCount);

WriteLine(format: "{0, -10} {1,6:N0}", arg0: bananasText, arg1: bananasCount);

Console.WriteLine(Environment.Version);


Write("Type your first name and press ENTER:");
string firstName = ReadLine()!;

Write("Type your age and press ENTER:");
string age = ReadLine()!;


WriteLine($"Hello {firstName}, you look good for {age}.");