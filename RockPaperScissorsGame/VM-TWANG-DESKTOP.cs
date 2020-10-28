using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RockPaperScissorsGame
{
    public class VM : INotifyPropertyChanged
    {
        private readonly Random random = new Random();
        private String compWin = "0";
        public String CompWin
        {
            get { return compWin; }
            set { compWin = value; onChange(); }
        }
        private int compWinNum = 0;
        private String playerWin = "0";

        public String PlayerWin
        {
            get { return playerWin; }
            set { playerWin = value; onChange(); }
        }
        private int playerWinNum = 0;
        public void ResetScore()
        {
            compWinNum = 0;
            CompWin = compWinNum.ToString();
            playerWinNum = 0;
            PlayerWin = playerWinNum.ToString();
            Message = null;
            onChange();
        }
        public int CompChoice()
        {
            int value = random.Next(0, 5);
            return value;
        }
        public int UserChoice(int x)
        {
            return x;
        }
        private String message;
        public String Message
        {
            get { return message; }
            set { message = value; onChange(); }
        }
        public void WinOrLose(int CompNum, int UserNum)
        {
            int diff = (CompNum - UserNum);
            if (diff < 0) diff += 5;
            if (diff == 2 | diff == 4)
            {
                Message = "Computer wins!";
                compWinNum++;
                CompWin = compWinNum.ToString();
                onChange();
            }
            else if (diff == 1 | diff == 3)
            {
                Message = "User wins!";
                playerWinNum++;
                PlayerWin = playerWinNum.ToString();
                onChange();
            }
            else
            {
                Message = "Computer and User tie!";
                onChange();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void onChange([CallerMemberName]string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
