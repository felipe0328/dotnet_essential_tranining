bool isProgramRunning = true;

while(isProgramRunning){
    Console.WriteLine("Which Date? ('exit' to quit)");
    string? entry = Console.ReadLine();

    if (entry == null){
        Console.WriteLine("Invalid entry, try again");
        continue;
    }

    if (entry.ToLower() == "exit"){
        isProgramRunning = false;
        continue;
    }

    DateTime dt;
    if(DateTime.TryParse(entry, out dt)){
        checkDate(dt);
        continue;
    } else {
        Console.WriteLine("Invalid entry, try again");
        continue;
    }
}


void checkDate(DateTime dt){
    DateOnly dateonly = DateOnly.FromDateTime(dt);
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