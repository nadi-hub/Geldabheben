namespace Geldabheben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pinkontrolle("123455");

        }
        static void Pinkontrolle(string eingabe)
        {
            string pin = "123456";
            if (pin == eingabe)
            {
                Console.WriteLine("Sie haben sich erfolgreich eingeloggt.");
            }
            else
            {
                int wiederholungszaehler = 1;
                while (wiederholungszaehler < 3)
                {
                    Console.Write("Der Pin war falsch. Bitte geben Sie ihn erneut ein: ");
                    eingabe = Console.ReadLine();
                    if (pin == eingabe)
                    {
                        Console.WriteLine("Sie haben sich erfolgreich eingeloggt.");
                        break;
                    }
                    wiederholungszaehler += 1;
                }
                if (wiederholungszaehler == 3)
                {
                    Console.WriteLine("Zu viele falsche Eingaben. Ihre Karte wird eingezogen und Ihr Konto gesperrt.");
                }
            }
        }
    }
}
