using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

Random random = new Random();           //52 cards in a deck


// ALL VARIABLES

int Cards_set1;
int Cards_set2; // ALlow the player to hit 11 times
int Cards_set3;
int Cards_set4;
int Cards_set5;
int Cards_set6; 
int Cards_set7;
int Cards_set8;
int Cards_set9;
int Cards_set10; 
int Cards_set11;

int total;


// Computer cards
int Com_Cards1; 
int Com_Cards2;
int Com_Cards3;
int Com_plays;
int Com_start_total;

int Com_total;

int hits = 0;


// BOOLS
bool playing = true; 
bool repeat = true;
bool choice = true;
bool in_play = true;
bool determining = true;
bool BETTING = true;



// white ($1), red ($5), blue ($10), green ($25), and black ($100)
int white_chip;
int red_chip;
int blue_chip;
int green_chip;
int black_chip;
// colours that they choccse
int colours;

int bet = 0; // total bet by the player

int bank = 100;




void random_cards() // method/function to randomize cards
{
    Cards_set1 = random.Next(1, 12);
    Cards_set2 = random.Next(1, 12); 
    Cards_set3 = random.Next(1, 12);
    Cards_set4 = random.Next(1, 12);
    Cards_set5 = random.Next(1, 12);
    Cards_set6 = random.Next(1, 12);
    Cards_set7 = random.Next(1, 12);
    Cards_set8 = random.Next(1, 12);
    Cards_set9 = random.Next(1, 12);
    Cards_set10 = random.Next(1, 12);
    Cards_set11 = random.Next(1, 12);
    total = Cards_set1 + Cards_set2;
}
random_cards();


void random_ComCards()
{
    Com_Cards1 = random.Next(1, 12);
    Com_Cards2 = random.Next(1, 12);
    Com_Cards3 = random.Next(1, 12);
    Com_plays = random.Next(1, 4);
    Com_start_total = Com_Cards1 + Com_Cards2;
}
random_ComCards();






// Method to show your total of cards
void show_cards() 
{
    if (hits == 0)
    {
        Console.WriteLine("You have: " + Cards_set1 + ", " + Cards_set2);
    }
    else if (hits == 1)
    {
        Console.WriteLine("You have: " + Cards_set1 + ", " + Cards_set2 + ", " + Cards_set3);
    }
    else if (hits == 2)
    {
        Console.WriteLine("You have: " + Cards_set1 + ", " + Cards_set2 + ", " + Cards_set3 + ", " + Cards_set4);
    }
    else if (hits == 3)
    {
        Console.WriteLine("You have: " + Cards_set1 + ", " + Cards_set2 + ", " + Cards_set3 + ", " + Cards_set4 + ", " + Cards_set5);
    }

}







void com_ai()   // Com AI
{
    if (Com_start_total > 17 && Com_start_total < 22)   
    {
        Com_total = Com_Cards1 + Com_Cards2;
    }
    else
    {
        Com_total = Com_Cards1 + Com_Cards2 + Com_Cards3;
    }
}

com_ai();






void betting() // The betting and money lol
{
    while (determining)
    {
        Console.WriteLine("How Much Would you like to bet");
        Console.Write("(1) | ");
        Console.WriteLine("white ($1)");
        Console.Write("(2) | ");
        Console.WriteLine("red ($5)");
        Console.Write("(3) | ");
        Console.WriteLine("blue ($10)");
        Console.Write("(4) | ");
        Console.WriteLine("white ($25)");
        Console.Write("(5) | ");
        Console.WriteLine("black ($100)");
        Console.Write("(6) | ");
        Console.WriteLine("Finish betting");
        Console.WriteLine("");
        Console.WriteLine("You Currently have in your bank: " + bank);
        Console.WriteLine("");
        Console.WriteLine("Your currently betting: $" + bet);
        Console.WriteLine("");


        while (true)
        {
            Console.Write("Which chip colour do you wanna chosse: ");
            colours = Convert.ToInt32(Console.ReadLine());

            if (colours == 1)
            {
                bet += 1;
                if(bet > bank)
                {
                    bet -= 1;
                    Console.WriteLine("");
                    Console.WriteLine("YOU DONT HAVE THE MONEY TO BET THAT MUCH!!!!....brokie");
                    Console.WriteLine("");
                    break;
                }
                break;
            }
            else if (colours == 2)
            {
                bet += 5;
                if (bet > bank)
                {
                    bet -= 5;
                    Console.WriteLine("");
                    Console.WriteLine("YOU DONT HAVE THE MONEY TO BET THAT MUCH!!!!....brokie");
                    Console.WriteLine("");
                    break;
                }
                break;
            }
            else if (colours == 3)
            {
                bet += 10;
                if (bet > bank)
                {
                    bet -= 10;
                    Console.WriteLine("");
                    Console.WriteLine("YOU DONT HAVE THE MONEY TO BET THAT MUCH!!!!....brokie");
                    Console.WriteLine("");
                    break;
                }
                break;
            }
            else if (colours == 4)
            {
                bet += 25;
                if (bet > bank)
                {
                    bet -= 25;
                    Console.WriteLine("");
                    Console.WriteLine("YOU DONT HAVE THE MONEY TO BET THAT MUCH!!!!....brokie");
                    Console.WriteLine("");
                    break;
                }
                break;
            }
            else if (colours == 5)
            {
                bet += 100;
                if (bet > bank)
                {
                    bet -= 100;
                    Console.WriteLine("");
                    Console.WriteLine("YOU DONT HAVE THE MONEY TO BET THAT MUCH!!!!....brokie");
                    Console.WriteLine("");
                    break;
                }
                break;
            }
            else if (colours == 6)
            {
                determining = false;
                break;
            }
        }
    }

}


//LUFFFY

/*
void draw_luffy()
{
    Console.WriteLine("");
    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣣⣿⣿⣿⣿⣿⡏⠀⠈⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿");
    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⣵⣿⣿⣿⣿⣿⣿⠁⠀⠀⢀⣾⣿⠟⣿⣿⣿⣿⣿⣿");
    Console.WriteLine("⣿⣿⣿⣿⣿⣿⡿⢟⣫⣾⣿⣿⣿⣿⣿⡿⠏⠀⠀⠀⠉⠉⠀⠈⠙⠛⠋⢩⣿⣿");
    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⢸⣿⣿⣿⣿⠋⠀⠀⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⠛⠛");
    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⠀⠉⢻⣿⣿⣄⠀⠀⠀⠀⠀⠀⠀⣴⠀⠀⠀⡀⠀⠀⠀⠀⠲");
    Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⡆⠐⠀⢹⠟⠁⠀⠀⠀⠀⠀⢀⣾⣿⡇⡄⠀⣷⠀⠀⠀⠀⠀");
    Console.WriteLine("⢹⣿⣿⣿⣿⣿⣿⣷⠀⠀⠀⢯⠁⢀⠀⠀⢀⢠⣿⣮⣝⢿⣿⡀⣿⣧⠀⠀⠀⠀");
    Console.WriteLine("⠈⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⢠⡄⢸⢧⠁⣬⡿⢋⣭⡛⣿⣿⡟⣯⣽⢀⡆⠀⢠");
    Console.WriteLine("⠀⢹⣿⣿⣿⣿⣿⠁⠌⠀⠀⠀⢓⡀⠢⡁⣿⠛⢿⣿⣿⣿⣿⣟⣭⣬⣻⠃⣄⢸");
    Console.WriteLine("⠀⠈⢿⣿⣿⠿⠃⠌⠀⠀⠀⡘⠀⢣⣾⡆⢻⡞⠗⠶⣯⣭⣿⣛⠳⣶⠇⣰⣿⣿");
    Console.WriteLine("⠀⠀⠀⢌⠀⠠⠀⠀⠀⠀⠀⠁⠀⠸⣿⣿⠈⠻⣮⡻⢿⣷⣿⡉⣱⢃⣾⣛⣻⣿");
    Console.WriteLine("⠀⠀⠀⠀⡀⠁⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⠀⢀⠔⣙⡷⢶⣖⣮⣵⣿⣿⣿⣿⣿");
    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢈⠻⣆⠊⠸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
    Console.WriteLine("⠀⡀⠂⠀⠀⠀⠀⠀⠀⠀⠀⠰⡀⠠⠈⣷⠄⠀⠀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
    Console.WriteLine("⣦⡄⡀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡇⠀⠀⢹⠃⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿");
    Console.WriteLine("");
*/

    


///////////////////////////////////////////////////////////  GAME START  //////////////////////////////////////////////////////////////////////////////



Console.WriteLine("Welcome to Black Jack"); // Welcome And Start  //THE GAMES BEGIN








while (playing)
{

    while (BETTING)
    {
        Console.WriteLine("PLease place your bet.");
        betting();
        BETTING = false;
        break;
    }

    while (in_play)
    {




        Console.WriteLine("You have: " + Cards_set1 + ", " + Cards_set2);

        Console.WriteLine("Your total is: " + total);
        Console.WriteLine("");
        Console.WriteLine("Dealer has: " + Com_Cards1);
        Console.WriteLine("");


        if (total > 21)
        {
            Console.WriteLine("YOU LOST");
            in_play = false;
            break;
        }

        while (choice)
        {

            Console.WriteLine("(1) Hit / (2) Stand");
            int Choice = Convert.ToInt32(Console.ReadLine());

            if (Choice == 1)        //Hitting                                                                              
            {
                if (hits == 0)
                {
                    total = Cards_set1 + Cards_set2 + Cards_set3;
                    hits++;
                }
                else if (hits == 1)
                {
                    total = Cards_set1 + Cards_set2 + Cards_set3 + Cards_set4;
                    hits++;
                }
                else if (hits == 2)
                {
                    total = Cards_set1 + Cards_set2 + Cards_set3 + Cards_set4 + Cards_set5;
                    hits++;
                }
                else if (hits == 3)
                {
                    total = Cards_set1 + Cards_set2 + Cards_set3 + Cards_set4 + Cards_set5 + Cards_set6;
                    hits++;
                }
                Console.WriteLine("Your total is: " + total);
                show_cards();

                if (total > 21) // OVER 21
                {
                    Console.WriteLine("YOU LOST");
                    choice = false;
                    in_play = false;
                    bank = bank - bet;
                    bet = 0;
                    break;
                }
            }
            else if (Choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Your total: " + total);
                Console.WriteLine("Computer's total: " + Com_total);
                Console.WriteLine();

                if (total > Com_total && total <= 21 || total <= 21 && Com_total > 21)
                {
                    Console.WriteLine("YOU WIN");
                    in_play = false;
                    playing = false;
                    choice = false;
                    bank = bank + bet;
                    bet = 0;
                    break;
                }
                else if (total < Com_total && total < 21 && Com_total <= 21)
                {
                    Console.WriteLine("You Lose");
                    in_play = false;
                    playing = false;
                    choice = false;
                    bank = bank - bet;
                    bet = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("YOU WIN");
                    in_play = false;
                    choice = false;
                    playing = false;
                    bank = bank + bet;
                    bet = 0;
                    break;
                }

            }
        }
    }
    while (repeat)
    {
        Console.WriteLine("Would You Like to keep playing or cash out ");
        Console.WriteLine("(1) Keep playing / (2) Cash out ");
        Console.WriteLine("");
        Console.WriteLine("You have a total of: $" + bank);
        int Choice = Convert.ToInt32(Console.ReadLine());

        if (bank == 0 || bank < 0)
        {
            playing = false;
            repeat = false;
            choice = false;
            in_play = false;
            Console.WriteLine("");
            Console.WriteLine("YOU LOST ALL YOUR MONEY");
            Console.WriteLine("EAT SHIT");
            break;
        }

        if (Choice == 1)
        {
 
            playing = true;
            repeat = true;
            choice = true;
            in_play = true;
            BETTING = true;
            hits = 0;
            random_cards();
            random_ComCards();
            random_cards();
            com_ai();
            Console.WriteLine("");
            determining = true;
            betting();
            break;
        }
        else if (Choice == 2)
        {
            playing = false;
            repeat = false;
            choice = false;
            in_play = false;
            Console.WriteLine("Remember: “99% of gamblers quit before hitting it big” ");
            break;
        }
    }
}






/*Notes
 * make sure when person losses all money they are forced quit
 */






















































