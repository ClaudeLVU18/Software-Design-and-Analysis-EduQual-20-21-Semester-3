using System;

namespace finalSummative
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endGame = false; //To be called later to end the While loop.
            
            //This part serves as the Title Screen for my program.
            Console.Clear();
            Console.WriteLine("\n\n```````````````````````````````````````````````````````````````````````````````");
            titleCard();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("````````````````````````````````````````````````````````````````````````````````");
            Console.Write("                           Press");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" enter");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to start.");
            Console.ReadLine();
            Console.Clear();Console.Clear();Console.Clear();Console.Clear(); //4x of Console Clear to ensure it cleans up large amount of WriteLines.

            //Main Menu body printed out; While loop begins here, so that user can return to the main menu after accessing game, about, etc,.
            do
            {
            Console.Clear();
            Console.WriteLine("\n\n```````````````````````````````````````````````````````````````````````````````");
            titleCard();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("````````````````````````````````````````````````````````````````````````````````");
            Console.WriteLine("                Welcome to Tic Tac Toe!");
            Console.WriteLine("                =================");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                | 1 - Start Game | ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                =================");
            Console.WriteLine("                ========================");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                | 2 - About Programmer | ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                ========================");
            Console.WriteLine("                ==================");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                | 3 - How to Play |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                ==================");
            Console.WriteLine("                =================");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                | 4 - Exit Game |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                =================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                Select a number: ");

            //In order to make the menu interactive and ask for user input
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            
            
            Console.Clear();
            
            

            //Commands for menu using cases filled with functions for smooth organisation.
            switch(menuChoice)
            {
                case 1:
                    Console.Clear();
                    game();
                    Console.Write("Press ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("enter");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" to return to the main menu.");
                    Console.ReadLine();
                    break;
                    
                case 2: 
                    Console.Clear();
                    about();
                    Console.Write("Press ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("enter");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" to return to the main menu.");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("===========================================================================");
                    how();
                    Console.WriteLine("===========================================================================");
                    Console.Write("Press ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("enter");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" to return to the main menu.");
                    Console.ReadLine();
                    
                    
                    
                    break;
                
                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("===============");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("===============");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("===============");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("===============");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("===============\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\n                        Thanks for playing!\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("===============");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("===============");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("===============");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("===============");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("===============\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    endGame = true;
                    break;
                
                default:    
                    Console.Clear();
                    break;

            }
            
            
  
            } while (!endGame); //"!" operator reverses the boolean value, therefore making the "endgame" variable set to true, more appropriate for the name.

            
        }

       static void titleCard()
       {    
           Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("====================        ====================             ==================");
            Console.WriteLine("        ||                           ||                   ||");
            Console.WriteLine("        ||                           ||                   ||");
            Console.WriteLine("        ||                           ||                   ||");
            Console.WriteLine("        ||                           ||                   ||");
            Console.WriteLine("        ||                  ====================             ==================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("====================                ====                     ==================");
            Console.WriteLine("        ||                         ^    ^                 ||");
            Console.WriteLine("        ||                        ^      ^                ||");
            Console.WriteLine("        ||                       ^ ====== ^               ||");
            Console.WriteLine("        ||                      ^          ^              ||");
            Console.WriteLine("        ||                     ^            ^                ==================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================                ====                     ==================");
            Console.WriteLine("        ||                        ==    ==                ||");
            Console.WriteLine("        ||                      ==        ==              ||===================");
            Console.WriteLine("        ||                      ==        ==              ||");
            Console.WriteLine("        ||                        ==    ==                ||");
            Console.WriteLine("        ||                          ====                     ==================");
            Console.WriteLine();
       }
        
        static void game()
        {
            char player = 'X';
            char[,] board = new char [3,3];

           Input(board); 
           int playmoves = 0;
            
           

            while (true)
            {
                Console.Clear();
                Column(board);

            

            Console.WriteLine("0 = 1st row, 1 = 2nd row, 2 = 3rd row.");
            Console.WriteLine();
            Console.Write("Player ");
            Console.Write(player);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("'s turn");
            Console.WriteLine();
            Console.Write("Select the row you would like to place your mark on: ");
            int row = Convert.ToInt32(Console.ReadLine());


            
            Console.WriteLine("0 = 1st column, 1 = 2nd column, 2 = 3rd column");
            Console.Write("Select the column you would like to place your mark on: ");
            int col = Convert.ToInt32(Console.ReadLine());
            
            board[row, col] = player;

            

            //If statement to detect a winner

            //Win detector for horizontal streaks
            if (player == board[0,0] && player == board[0,1] && player == board[0,2])
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Winner: " + player + "!");
                Console.ForegroundColor = ConsoleColor.White;
                break;
                
                
            }

             if (player == board[1,0] && player == board[1,1] && player == board[1,2])
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Winner: " + player + "!");
                Console.ForegroundColor = ConsoleColor.White;
               
                break;
                
                
            }

            if (player == board[2,0] && player == board[2,1] && player == board[2,2])
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Winner: " + player + "!");
                Console.ForegroundColor = ConsoleColor.White;
               
                break;
                
                
            }

            //Win detector for Vertical streaks
            if (player == board[0,0] && player == board[1,0] && player == board[2,0])
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Winner: " + player + "!");
                Console.ForegroundColor = ConsoleColor.White;
               
                break;
                
                
            }

             if (player == board[0,1] && player == board[1,1] && player == board[2,1])
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Winner: " + player + "!");
                Console.ForegroundColor = ConsoleColor.White;
               
                break;
               
                
            }

             if (player == board[0,2] && player == board[1,2] && player == board[2,2])
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Winner: " + player + "!");
                Console.ForegroundColor = ConsoleColor.White;
               
                break;
                
                
            }

            //Win detector for diagonal streaks
            if (player == board[0,0] && player == board[1,1] && player == board[2,2])
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Winner: " + player + "!");
                Console.ForegroundColor = ConsoleColor.White;
               
                break;
                
                
            }

            if (player == board[0,2] && player == board[1,1] && player == board[2,0])
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Winner: " + player + "!");
                Console.ForegroundColor = ConsoleColor.White;
               
                break;
                
                
            }


            playmoves = playmoves + 1;
            //Once the game makes 9 moves and no one wins, a tie is automatically called.
            if (playmoves == 9)
            {
                Console.Write("\nIt's a");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" tie!\n");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }


            player = TurnSwap(player);

            
            
            }

            
            
            
        }
        
    

        static char TurnSwap(char currentPlayer)
        {
            if (currentPlayer == 'X') //interchanges the player value from X to O
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                return  'O';
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                return  'X';
            }
        }

        static void Input(char[,] board) //sets up the arrays within the grid; so inputs can be place onto them.
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        static void Column(char[,] board)
        {
            //Prints the layout of the grid
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine("Column #| 0 | 1 | 2 |");
            for (int row = 0; row < 3; row++)
            {
                Console.Write("  Row #" + row + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board [row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=====================");
            
        }

    
        static void about() //Adds a section that shows a bit of the programmer and the purpose of the program.
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("\n\nHi! My name is Christian Claude L.V. Utlang. \n\nI am a student from IFS EduQual 2020-2021 L3.\n\nThis program containing a Tic-Tac-Toe game is my final project for my module 'Software Design and Analysis (EduQual) 20-21 Semester 3'.\n\nI hope you enjoy this program.\n\n");
            Console.WriteLine("===========================================================================");
        }

        static void how() //Prints out the instructions for the game.
        {
            
            Console.WriteLine("In a game of Tic-Tac-Toe, there are two players.\n\nX and O.\n\nX will go first. Each player will take turns on placing down their mark on the 3x3 grid.\nWhoever is first to mark down X/O three times in a row either in a horizontal, vertical, or diagonally line wins.\nIf neither are able to mark down X/O three times in a row, it is considered as a tie.");
            Console.WriteLine("=====================");
            Console.WriteLine("Column #| 0 | 1 | 2 |");
            Console.WriteLine("  Row #0|   |   |   |");
            Console.WriteLine("  Row #1|   |   |   |");
            Console.WriteLine("  Row #2|   |   |   |");
            Console.WriteLine("=====================");
            Console.WriteLine("");
        }
    }
}

