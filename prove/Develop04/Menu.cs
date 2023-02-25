class Menu{
    public void Display(){
        
        int quit = 0;
        while(true){
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1.Start breathing activity\n2.Start reflection activity\n3.Start listing activity\n4.Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        int.TryParse(choice, out int choiceInt);
        switch (choiceInt){
            case 1:
                //breathing
                Breathing breathing = new Breathing("Breathing", "This activity will walk you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.GetStartingMessage();
                breathing.Display();
                break;
            case 2:
                //reflection
                Reflection refelction = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have showen strength and reselience.");
                refelction.GetStartingMessage();
                refelction.Display();
                break;
            case 3:
                //listing
                Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.GetStartingMessage();
                listing.Display();
                break;
            case 4:
                //quit
                quit = -1;
                break;
            default:
            //try again
                break;
        }
        if (quit !=0){
            break;
        }
        
        }
    }
}