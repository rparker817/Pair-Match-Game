//Assignment 1 SODV2101 Robert Parker


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchGame
{
    public partial class MainForm : Form
    {
        
        
        string id= "1";
        int action_count = 0; //each player has two actions per turn
        string stored_id = "0";
        Button stored_card;
        Button stored_card_2;
        int match_count = 0;
        int num_of_players = 0;
        int current_player = 1;
        int player_1_score = 0;
        int player_2_score = 0;
        int game_time_seconds = 0;
        int game_time_minutes = 0;
        int pause_timer_seconds = 0;
        bool pause_card_clicks = false;
        int turn_count = 0; // used only for 1 player games

        public MainForm()
        {
            InitializeComponent();
            gameText.Text = "Press Play!";
            // disable all of the card buttons, this stops the game from being played before the play button is pressed.
            for (int i = 0; i < gameBoard.Controls.Count; i++)
            {
                if (gameBoard.Controls[i] is Button)
                {
                    gameBoard.Controls[i].Enabled = false;
                }
            }
        }

        private void card_selected(object sender, EventArgs e)// caled when a player clicks on any card
        {
            if(pause_card_clicks != true) //this initial check will ensure no action is taken on cards when the pause timer is activated
            {
              
                id = (sender as Button).BackgroundImage.Tag.ToString();
                set_card_texture(sender);
                action_count += 1;
                (sender as Button).Enabled = false; // this ensures the card cannot be pressed twice
                if (action_count == 1)
                {
                    stored_id = id;
                    stored_card = (sender as Button);
                    
                }
                if (action_count == 2)
                {
                    turn_count += 1;
                    pause_card_clicks = true;
                    stored_card_2 = (sender as Button);
                    pauseTimer.Start(); // when pause timer ends check_match() will be called.
                    
                }
            }
     
        }

        private void playBtn_Click(object sender, EventArgs e) //starts the game when "play" is pressed
        {
            
            string[] cards = new string[20] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }; //array containing all of the card Ids
            Random rand = new Random();

            gameText.Text = "Player 1 Turn";
            check_player_count();
            reset_game();
            playBtn.Text = "Restart";
           

            //randomize the order of the cards array
            for (int i = 0; i < cards.Length - 1; i++)
            {
                int j = rand.Next(i, cards.Length);
                string temp1 = cards[i];
                cards[i] = cards[j];
                cards[j] = temp1;
            }
            //assign a code to each of the cards on the board. The code will determine which type of card is hidden underneath
            for (int i = 0; i < gameBoard.Controls.Count; i++)
            {
                if (gameBoard.Controls[i] is Button)
                {
                    gameBoard.Controls[i].BackgroundImage.Tag = cards[i];
                }
            }

            //enable all of the cards to be pressed.
            for (int i = 0; i < gameBoard.Controls.Count; i++)
            {
                if (gameBoard.Controls[i] is Button)
                {
                    gameBoard.Controls[i].Enabled = true;
                }
            }

            gameTimer.Start();
            
        }
        private void check_game_status() // checks to see how many pairs have been made. If it is all 10, the game ends.
        {
            match_count += 1;
            if(match_count == 10)
            {
                gameTimer.Stop();

                if (num_of_players == 1)
                {
                    gameText.Text = "Winner! ("+turn_count.ToString()+ " turns)";
                }
                else
                {
                    if (player_1_score == player_2_score)
                    {
                        gameText.Text = "it is a draw!";
                    }
                    else
                    {
                        if (player_1_score > player_2_score)
                        {
                            gameText.Text = "Player 1 wins!";
                        }
                        if (player_2_score > player_1_score)
                        {
                            gameText.Text = "Player 2 wins!";
                        }
                    }
                }
                
                playerSelect.Text = "How Many Players?";

            }
        }

        private void set_card_texture(object sender) { //will set the card image to the correct resource, depending on it's id
            
            if(id == "1") 
            {
                (sender as Button).BackgroundImage = MatchGame.Properties.Resources.shape1;
            }
            else if(id == "2")
            {
                (sender as Button).BackgroundImage = MatchGame.Properties.Resources.shape2;
            }
            else if (id == "3")
            {
                (sender as Button).BackgroundImage = MatchGame.Properties.Resources.shape3;
            }
            else if (id == "4")
            {
                (sender as Button).BackgroundImage = MatchGame.Properties.Resources.shape4;
            }
            else if (id == "5")
            {
                (sender as Button).BackgroundImage = MatchGame.Properties.Resources.shape5;
            }
            else if (id == "6")
            {
                (sender as Button).BackgroundImage = MatchGame.Properties.Resources.shape6;
            }
            else if (id == "7")
            {
                (sender as Button).BackgroundImage = MatchGame.Properties.Resources.shape7;
            }
            else if (id == "8")
            {
                (sender as Button).BackgroundImage = MatchGame.Properties.Resources.shape8;
            }
            else if (id == "9")
            {
                (sender as Button).BackgroundImage = MatchGame.Properties.Resources.shape9;
            }
            else if (id == "10")
            {
                (sender as Button).BackgroundImage = MatchGame.Properties.Resources.shape10;
            }
        }
        private void reset_game() // turns all cards face down and resets the variables.
        {
            
            //set all of the card images to the card backs.
            for (int i = 0; i < gameBoard.Controls.Count; i++)
            {
                if (gameBoard.Controls[i] is Button)
                {
                    gameBoard.Controls[i].BackgroundImage = MatchGame.Properties.Resources.CardBack; 
                }
            }

            //reset Variables
            current_player = 1;
            match_count = 0;
            action_count = 0;
            player_1_score = 0;
            player_2_score = 0;
            player1Score.Text = "0";
            player2Score.Text = "0";
            turn_count = 0;

            //reset timer
            game_time_seconds = 0;
            game_time_minutes = 0;
            secondsLabel.Text = game_time_seconds.ToString();
            minutesLabel.Text = game_time_minutes.ToString();
           

        }
        private void check_player_count() // Sets the player count variables, is it a 1 player or 2 player game?.
        {
            if(playerSelect.Text == "1" || playerSelect.Text == "How Many Players?")
            {
                num_of_players = 1;
            }
            else
            {
                num_of_players = 2;
            }
            
        }

        private void gameTimer_Tick(object sender, EventArgs e) // change the timer to represent the time passed during the game.
        {
            game_time_seconds += 1;
            if(game_time_seconds == 60)
            {
                game_time_seconds = 0;
                game_time_minutes += 1;
                minutesLabel.Text = game_time_minutes.ToString();

            }
            if (game_time_seconds < 10)
            {
                secondsLabel.Text = "0" + game_time_seconds.ToString();
            }
            else 
            {
                secondsLabel.Text = game_time_seconds.ToString();
            }
            
        }

        private void pauseTimer_Tick(object sender, EventArgs e)// used to allow the player to see both revealed cards temporarily
        {
            pause_timer_seconds += 1;
            if(pause_timer_seconds ==1)
            {
                pause_timer_seconds = 0;
                pauseTimer.Stop();
                check_match();
            }
        }

        private void check_match() //checks the two revealed cards to see if there is a match.
        {
            if (stored_id == id) //Correct pair match
            {
                gameText.Text = "Match!";
                stored_card_2.Enabled = false;

                if (current_player == 1)
                {
                    player_1_score += 1;
                    string score = player_1_score.ToString();
                    player1Score.Text = score;
                }
                else
                {
                    player_2_score += 1;
                    string score = player_2_score.ToString();
                    player2Score.Text = score;
                }
                check_game_status();
            }
            else //pair was not a match
            {

                gameText.Text = "Unlucky!";

                //flips cards back over
                stored_card.BackgroundImage = MatchGame.Properties.Resources.CardBack; //Image.FromFile("D:\\Software Development\\SODV2101- Rapid Application Development\\Assignments\\images\\CardBack.png");
                stored_card.BackgroundImage.Tag = stored_id.ToString();
                stored_card.Enabled = true;

                stored_card_2.BackgroundImage = MatchGame.Properties.Resources.CardBack; //Image.FromFile("D:\\Software Development\\SODV2101- Rapid Application Development\\Assignments\\images\\CardBack.png");
                stored_card_2.BackgroundImage.Tag = id.ToString();
                stored_card_2.Enabled = true;
                //because pair was incorrect, switch over to the next player, if it is a two player game.
                if (num_of_players == 2)
                {
                    if (current_player == 1)
                    {
                        current_player = 2;
                        gameText.Text = "Player 2 Turn";
                    }
                    else
                    {
                        current_player = 1;
                        gameText.Text = "Player 1 Turn";
                    }
                }
            }
            action_count = 0;
            pause_card_clicks = false; // allow cards to be clicked again
        }
    }
}
