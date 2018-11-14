using System;
using System.Collections.Generic;
using System.Text;

namespace Snakes_and_Ladders_Kata
{
    class Counter
    {
        private int location;
        private String playerName;
        private Boolean winner = false;

        public Counter(String playerName)
        {
            this.location = 1;
            this.playerName = playerName;
        }

        public int getLocation()
        {
            return this.location;
        }

        public void setLocation(int location)
        {
            this.location = location;
        }

        public String getPlayerName()
        {
            return this.playerName;
        }

        public void setPlayerName(String playerName)
        {
            this.playerName = playerName;
        }

        public bool checkWinner()
        {
            return winner;
        }

        //Move players Counter
        public void Move(int diceRoll)
        {
            if (location + diceRoll == 100)
            {
                this.location = this.location + diceRoll;
                this.winner = true;
            }
            if (location + diceRoll < 100)
            {
                this.location = this.location + diceRoll;
            }
            
        }
    }
}
