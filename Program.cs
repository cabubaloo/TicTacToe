using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        static List<string> BoardCreation()
        {
            List<string> board = new List<string>();

            /*board[] = */

            board.Add("1");
            board.Add("2");
            board.Add("3");
            board.Add("4");
            board.Add("5");
            board.Add("6");
            board.Add("7");
            board.Add("8");
            board.Add("9");

            return board;
        }
        List<string> board = BoardCreation();
        

        static void PrintBoard(List<string> board)
        {
            Console.WriteLine($"\n {board[0]} {board[1]} {board[2]} \n {board[3]} {board[4]} {board[5]} \n {board[6]} {board[7]} {board[8]}\n");
        }


        static void PlayerTurn(List<string> board)
        {
            int userInt = 0;
            int counter = 0;
            int turn = 0;

            while (counter == 0)
            {
                PrintBoard(board);
                
                Console.WriteLine("Which number would you like to claim? (P1) ");
                userInt = Int32.Parse(Console.ReadLine());

                board[userInt - 1] = "X";

                PrintBoard(board);
                turn += 1;

                if (turn >= 5)
                {
                    if (board[0] == board[1] && board[1] == board[2] ||
                        board[0] == board[3] && board[3] == board[6] ||
                        board[0] == board[4] && board[4] == board[8] ||
                        board[1] == board[4] && board[4] == board[7] ||
                        board[2] == board[5] && board[5] == board[8] ||
                        board[2] == board[4] && board[4] == board[6] ||
                        board[3] == board[4] && board[4] == board[5] ||
                        board[6] == board[7] && board[7] == board[8])
                    {
                        Console.WriteLine("Player 1 Wins! ");
                    }
                }

                Console.WriteLine("Which number would you like to claim? (P2) ");
                userInt = Int32.Parse(Console.ReadLine());
                board[userInt - 1] = "O";

                turn += 1;

                if (turn >= 5)
                {
                    if (board[0] == board[1] && board[1] == board[2] ||
                        board[0] == board[3] && board[3] == board[6] ||
                        board[0] == board[4] && board[4] == board[8] ||
                        board[1] == board[4] && board[4] == board[7] ||
                        board[2] == board[5] && board[5] == board[8] ||
                        board[2] == board[4] && board[4] == board[6] ||
                        board[3] == board[4] && board[4] == board[5] ||
                        board[6] == board[7] && board[7] == board[8])
                    {
                        Console.WriteLine("Player 2 Wins! ");
                    }
                }
            }
        }
        PlayerTurn(board);
    }
}