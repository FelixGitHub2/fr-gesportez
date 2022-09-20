
int poäng = 0;

Console.WriteLine("Yo välkommen till leagueoflegends frågesport");
Console.WriteLine("Det kommer att finnas 5 frågor, good luck");
Console.WriteLine("Fråga 1 Easy");
Console.WriteLine("Vad är main rollen i Top-Lane");
Console.WriteLine("a = Mage b = Ranged c = Tank");


string svar1 = Console.ReadLine();
if (svar1 == "c")
{
    poäng++;
    Console.WriteLine("Rätt");
}
else 
{
    Console.WriteLine("Fel, det är TANK");
}

Console.WriteLine("Fråga 2 Easy");
Console.WriteLine("Vad är karaktären Mordekaisers main lane?");
Console.WriteLine("a = Mid b = Top c = Bot");

string svar2 = Console.ReadLine();
if (svar2 == "b")
{
    poäng++;
    Console.WriteLine("Rätt");
}
else
{
    Console.WriteLine("Fel, Det var TOP");
}


Console.WriteLine("Fråga 3 Medium");
Console.WriteLine("Vart kommer karaktären Darius från");
Console.WriteLine("a = Noxus b = Zaun c = Demasia");

string svar3 = Console.ReadLine();
if (svar3 == "a")
{
    poäng++;
    Console.WriteLine("Rätt");
}
else
{
    Console.WriteLine("Fel, Det var Noxus");
}

Console.WriteLine("Fråga 4 Medium");
Console.WriteLine("Vad för main damage typ är Urgot");
Console.WriteLine("a = AD b = AP c = Mixed AD/AP");

string svar4 = Console.ReadLine();
if (svar4 == "a")
{
    poäng++;
    Console.WriteLine("Rätt");
}
else
{
    Console.WriteLine("Fel, Han har bara AD abilities");
}

Console.WriteLine("Fråga 5 Svår");
Console.WriteLine("Vad heter Garens Q Abilitie");
Console.WriteLine("a = For Demacia b = Desisive Strike c = Rushdown");

string svar5 = Console.ReadLine();
if (svar5 == "b")
{
    poäng++;
    Console.WriteLine("Rätt");
}
else
{
    Console.WriteLine("Fel, Desisive strike är det");
}

Console.WriteLine("Så här många poäng fick du");
Console.WriteLine(poäng);

if (poäng >= 3)
{
    Console.WriteLine("Du gjorde bra :D");
}
else if (poäng < 3)
{
    Console.WriteLine("Bruh du kan inte alls bra");
}

Console.ReadLine();