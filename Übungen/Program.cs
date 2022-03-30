Console.Write("Gib mal bitte die erste Zahl: ");
string input1Zahl = Console.ReadLine();

Console.Write("Und nun gib bitte die zweite Zahl: ");
string input2Zahl = Console.ReadLine();


int input1ZahlAlsInt = int.Parse(input1Zahl);
int input2ZahlAlsInt = int.Parse(input2Zahl);
int ergibis = input1ZahlAlsInt * input2ZahlAlsInt;


Console.WriteLine($"{input1Zahl} * {input2Zahl} = {ergibis}");






