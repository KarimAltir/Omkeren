using System.Net.Sockets;

string woord, woord1 = "";
int i = 0;


Console.Write("geef de woord in: ");
woord = Console.ReadLine();

Console.WriteLine("Met welk type iteratie moet de berekening gebeuren?");
Console.WriteLine("   1.  For-loop");
Console.WriteLine("   2.  While-loop");
Console.WriteLine("   3.  Do-While-loop");
Console.WriteLine("   4.  Recursie");
char keuze = Console.ReadLine().First();

int l = woord.Length - 1;


switch (keuze)
{
    case '1':

        for (i = l; i >= 0; i--)
        {
            woord1 += woord[i];
        }
        break;

    case '2':

        while (l >= 0)
        {
            woord1 += woord[l];
            l--;
        }

        break;

    case '3':

        do
        {
            woord1 += woord[l];
            l--;
        } while (l >= 0);

        break;

    case '4':

        woord1 = GeefDeOmkering(woord);

        break;
}

Console.WriteLine("de omgekeerde woord van " + woord + " is: " + woord1);

Console.WriteLine();

string GeefDeOmkering(string woord)
{
    if (woord.Length = 0)
        return woord;
    return GeefDeOmkering(woord.Substring(1)) + woord[0];

}


