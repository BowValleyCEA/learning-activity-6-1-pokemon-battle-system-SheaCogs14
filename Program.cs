
using game1401_la_starter;

MainMenu();

 void MainMenu()
{
    Console.WriteLine("Welcome to  my pokemon adventure!");

    Console.WriteLine("Player 1 Choose your pokemon");
    Pokemon p1 = selectionPokemon();

    Console.WriteLine("Player 2 Choose your pokemon");
    Pokemon p2 = selectionPokemon();

    Pokemon Player1 = p1;
    Pokemon Player2 = p2;


    while (true)
    {
        Console.WriteLine($"\nCurrent Pokémon: {Player1.Name} (Health: {Player1.currentHealth})");
        MainMenUSelection choice = ChooseMainOption();

        switch (choice)
        {
            case MainMenUSelection.Attack:
                Player1.ReciveAttack(Player2);
                break;
            case MainMenUSelection.Run:
                Console.WriteLine("You ran away! :( ");
                break;

            case MainMenUSelection.Heal:
                int heala = 3;
                Player1.BaseHeal(heala);
                break;

            case MainMenUSelection.Exit:
                return;
        }

        Console.WriteLine($"\nCurrent Pokémon: {Player2.Name} (Health: {Player2.currentHealth})");
        choice = ChooseMainOption();

        switch (choice)
        {
            case MainMenUSelection.Attack:
                Player2.ReciveAttack(Player1);
                break;
            case MainMenUSelection.Run:
                Console.WriteLine("You ran away! :( ");
                break;

            case MainMenUSelection.Heal:
                int heala = 3;
                Player2.BaseHeal(heala);
                break;

            case MainMenUSelection.Exit:
                return;
        }
    }
}


Pokemon selectionPokemon()
{
    Console.WriteLine("1: Electric");
    Console.WriteLine("2: Water");
    Console.WriteLine("3: Fire");
    Console.WriteLine("4: Grass");
    Console.WriteLine(" Normal");

    int selection = 0;
    while (true)
    {

        if (int.TryParse(Console.ReadLine(), out selection) && (selection >= 1 && selection <= 5))
            break;
    }

    return selection switch
    {
        1 => new Electric("Pikachu", 12, 12, 3),
        2 => new Water("Squirtle", 12, 12, 3),
        3 => new Fire("Chimchar", 12, 12, 3),
        4 => new Grass("Scovillain", 12, 12, 3),
        5 => new Normal("Clefairy", 12, 12, 3),
    };
}

MainMenUSelection ChooseMainOption()
{
   bool isSelection = false;
   int selection = 0;

   while (!isSelection)
   {
       Console.WriteLine("Would you like to:\n\t 1: Attack?! \n\t 2: Run away now?! \n\t 3: Use a heal item? \n\t 4: Exit the program?");
       if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= 4)
           isSelection = true;
   }

   return (MainMenUSelection)selection;
}

enum MainMenUSelection
{
   Attack = 1, Run = 2, Heal = 3, Exit = 4

}

