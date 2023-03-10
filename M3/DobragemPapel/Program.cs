// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

double espessura = 0.074;
double espessuraCm;
double espessuraMetros;
double espessuraKms;
int dobragens;

Console.WriteLine("Quantas vezes dobrar?");
dobragens = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < dobragens; i++)
{
    espessura = espessura * 2;
}

espessuraCm = espessura / 10;
espessuraMetros = espessuraCm / 100;
espessuraKms = espessuraMetros / 1000;

Console.WriteLine("Espessura Final (mm): " + espessura);
Console.WriteLine("Espessura Final (cm): " + espessuraCm);
Console.WriteLine("Espessura Final (metros): " + espessuraMetros);
Console.WriteLine("Espessura Final (Kms): " + espessuraKms);