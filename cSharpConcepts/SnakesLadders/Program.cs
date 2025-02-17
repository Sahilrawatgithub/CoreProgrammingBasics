

class SnakeLadderGame
{
    static Random random = new Random();
    static int[] board = new int[101];

    static void InitializeBoard()
    {

        board[4] = 14; board[9] = 31; board[20] = 38;                        //setting ladders
        board[28] = 84; board[40] = 59; board[51] = 67;
        board[63] = 81; board[71] = 91;


        board[17] = 7; board[54] = 34; board[62] = 19;                       //setting snakes
        board[64] = 60; board[87] = 24; board[93] = 73;
        board[95] = 75; board[98] = 79;
    }

    static int RollDice()
    {
        return random.Next(1, 7);
    }

    static int MovePlayer(int position, int roll)
    {
        int newPosition = position + roll;
        if (newPosition > 100)
        {
            return position;
        }

        if (board[newPosition] != 0)
        {
            return board[newPosition];
        }
        else
        {
            return newPosition;
        }
    }

    static void PlayGame()
    {
        int[] players = { 0, 0 };
        int currentPlayer = 0;
        int rollsCount = 0;

        Console.WriteLine("Game Start! Both players are at position 0.");

        while (players[0] < 100 && players[1] < 100)
        {
            int roll = RollDice();
            Console.WriteLine($"Player {currentPlayer + 1} rolls: {roll}");

            int newPosition = MovePlayer(players[currentPlayer], roll);

            if (newPosition == players[currentPlayer])
            {
                Console.WriteLine($"Player {currentPlayer + 1} needs an exact roll to win!");
            }
            else
            {
                players[currentPlayer] = newPosition;
                Console.WriteLine($"Player {currentPlayer + 1} moves to: {players[currentPlayer]}");
            }

            rollsCount++;

            if (players[currentPlayer] == 100)
            {
                Console.WriteLine($"Player {currentPlayer + 1} wins after {rollsCount} rolls!");
                break;
            }


            if (board[newPosition] > newPosition)
            {
                Console.WriteLine($"Player {currentPlayer + 1} gets an extra turn!");
                continue;
            }

            currentPlayer = 1 - currentPlayer;
        }
    }

    static void Main()
    {
        InitializeBoard();
        PlayGame();
    }
}
