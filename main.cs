// Print backstory to user
Console.WriteLine("Welcome to the Haunted Mansion!");
Console.WriteLine("You are a distant family member of a rich millionaire who has just passed away, leaving this mansion to you.");
Console.WriteLine("Now that you are the newfound owner, you decide to take a look inside.");
Console.WriteLine("The house is dated, creaky, and falling apart. You walk in the front door.");
Console.WriteLine("Do you want to enter the living room or the dining room?");

// Prompt the user for a choice
Console.Write("> ");
string roomChoice = Console.ReadLine();

// Ask player which room they want to go to
if(roomChoice == "living room")
{
    Console.WriteLine("You chose to go into the living room.");
    Console.WriteLine("As you walk in, you see a sleeping pitbull guarding some gold jewelry.");
    Console.WriteLine("Do you want to steal the jewelry?");

    // Prompt the user for a choice
    Console.Write("> ");
    string pitBullChoice = Console.ReadLine();

    if(pitBullChoice == "yes")
    {
        Console.WriteLine("You attempt to steal the jewelry, but the pitbull wakes up and rips you to shreds.");
        Console.WriteLine("You have now died.");
    }
    else if(pitBullChoice == "no")
    {
        Console.WriteLine("You decide not to steal the dog's jewelry.");
        Console.WriteLine("Your turn back and find your way out of the house safely.");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please answer yes or no.");
    }
}
else if(roomChoice == "dining room")
{
    Console.WriteLine("You chose to go into the dining room.");
    Console.WriteLine("As you walk in, you see a shiny vase on the table");
    Console.WriteLine("Do you want to open it?");

    // Prompt the user for a choice
    Console.Write("> ");
    string vaseChoice = Console.ReadLine();

    if(vaseChoice == "yes")
    {
        Console.WriteLine("You open the vase and find a pile of bones!");
    }
    else if(vaseChoice == "no")
    {
        Console.WriteLine("You decide not to open the vase.");
        Console.WriteLine("As you turn to leave, you hear a cracking sound coming from the corner");
        Console.WriteLine("A dark figure with glowing red eyes launches at you, knocking you unconcious");
        Console.WriteLine("You wake up in your bed. It was all a dream.");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please answer yes or no.");
    }
}
else
{
    Console.WriteLine("Invalid choice. Please answer living room or dining room.");
}
