/* 
 * Applicazione, dove effettuare un atterraggio di un razzo 
 */

/* 
 * Thread.Sleep() => è un metodo, dove il sistema di esecuzione viene effettuato in un tempo
 * specifico in millisecondi
 */


// Razzo sotto forma di stringa
string rocket = "\"   /\\\\   \\\" \r\n\"  /  \\\\  \\\" \r\n\" /----\\\\ \\\" \r\n\" |    | \\\" \r\n\" |    | \\\" \r\n\" |____| \\\" \r\n\"  /  \\\\  \\\" \r\n\" /____\\\\ \"";

for (int i = 5; i >= 1; i--)
{
    // Pulire la console ogni interazione
    Console.Clear();

    // Conto alla rovescia
    Console.WriteLine("-----"+i+"-----");

    // Quando il razzo atterra
    if (i == 1)
    {
        // Convertire output in utf-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // emoji rocket 🚀
        string rocketEmoji = char.ConvertFromUtf32(0x0001F680);
        Console.WriteLine($"Razzo atterrato!{rocketEmoji}");
    }

    Console.WriteLine(rocket);

    // Per ogni esecuzione del loop for, lascia una riga vuota in alto
    rocket = "\n" + rocket;

    // Il tempo in cui avviene l'esecuzione
    Thread.Sleep(1000); // 1 secondo
}

Console.ReadKey();