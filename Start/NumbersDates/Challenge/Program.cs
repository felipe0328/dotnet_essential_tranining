bool isProgramRunning = true;

while(isProgramRunning){
    Console.WriteLine("Which Date? ('exit' to quit)");
    string? entry = Console.ReadLine();

    if (entry == null){
        Console.WriteLine("Invalid entry, try again");
        continue;
    }

    if (string.Equals(entry, "exit", StringComparison.OrdinalIgnoreCase)) {
        isProgramRunning = false;
        continue;
    }

    if (DateTime.TryParse(entry, out DateTime dt)) {
        checkDate(dt);
        continue;
    } else {
        Console.WriteLine("Invalid entry, try again");
        continue;
    }
}

static void checkDate(DateTime dt){
    DateTime now = DateTime.Now;

    if (dt.Date == now.Date){
        Console.WriteLine("That date is Today!");
        return;
    }

    TimeSpan result = now - dt;

    if(dt < now){
        Console.WriteLine($"That date was {result.Days} days ago.");
    } else {
        Console.WriteLine($"That date will be in {-1 * result.Days} days");
    }
}