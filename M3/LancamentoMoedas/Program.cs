
int nrCaras = 0;
int nrCoroas = 0;
Random r = new Random();

for (int i = 0; i < 20; i++)
{
    int resultado = r.Next(0, 2);

    if (resultado == 0)
    {
        nrCaras++;
    } else if (resultado == 1) {
        nrCoroas++;
    }
}

Console.WriteLine("Caras: " + nrCaras);
Console.WriteLine("Coroas: " + nrCoroas);
