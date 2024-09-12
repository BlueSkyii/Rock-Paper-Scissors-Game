namespace Rock_Paper_Scissors
{
    internal class RPS
    {
        public void GameStart()
        {
            string Player = "";
            string Computer = "";
            Random RandomNum = new Random();
            int Num = RandomNum.Next(1, 4);

            Console.WriteLine("Rock, Paper, Scissors Game VS Computer");
            Console.WriteLine("=======================================");

            while (true)
            {
                try
                {
                    Console.Write("Your turn: ");
                    Player = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInvalid input try again!\n");
                    continue;
                }

                Player = Player.ToLower();

                if (Player != "rock" && Player != "paper" && Player != "scissors")
                {
                    Console.WriteLine("\nInvalid input try again!\n");
                    continue;
                }

                break;
            }

            if (Num == 1)
            {
                Computer = "Rock";
            }
            else if (Num == 2)
            {
                Computer = "Paper";
            }
            else
            {
                Computer = "Scissors";
            }

            Console.WriteLine($"\nComputer picked: {Computer}\n");

            if ((Player == "rock" && Computer == "Rock") || (Player == "paper" && Computer == "Paper") || (Player == "scissors" && Computer == "Scissors"))
            {
                Console.WriteLine("Draw!");
            }
            else if (Player == "rock" && Computer == "Paper")
            {
                Console.WriteLine("Computer won!");
            }
            else if (Player == "rock" && Computer == "Scissors")
            {
                Console.WriteLine("You won!");
            }
            else if (Player == "paper" && Computer == "Scissors")
            {
                Console.WriteLine("Computer won!");
            }
            else if (Player == "paper" && Computer == "Rock")
            {
                Console.WriteLine("You won!");
            }
            else if (Player == "scissors" && Computer == "Rock")
            {
                Console.WriteLine("Computer won!");
            }
            else if (Player == "scissors" && Computer == "Paper")
            {
                Console.WriteLine("You won!");
            }

            PlayAgain();
        }

        public void PlayAgain()
        {
            string YesOrNo = "";

            Console.WriteLine("\nWanna play again? (Yes or No)\n");

            while (true)
            {
                try
                {
                    Console.Write("Enter: ");
                    YesOrNo = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInvalid input try again!\n");
                    continue;
                }

                YesOrNo = YesOrNo.ToLower();

                if (YesOrNo != "yes" && YesOrNo != "no")
                {
                    Console.WriteLine("\nInvalid input try again!\n");
                    continue;
                }

                break;
            }

            if (YesOrNo == "yes")
            {
                Console.Clear();
                GameStart();
            }
            else
            {
                Console.WriteLine("\nThanks for playing!");
            }
        }
    }
}
