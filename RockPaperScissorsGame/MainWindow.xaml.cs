using System.Windows;

namespace RockPaperScissorsGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public int value;
        public string src;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
            value = vm.CompChoice();
            HideChoiceImg();
        }
        private void rockBtn_Click(object sender, RoutedEventArgs e)
        {
            vm.UserChoice(0);
            vm.WinOrLose(value, 0);
            ShowChoiceImg(value, 0);
            value = vm.CompChoice();
        }
        private void lizardBtn_Click(object sender, RoutedEventArgs e)
        {
            vm.UserChoice(1);
            vm.WinOrLose(value, 1);
            ShowChoiceImg(value, 1);
            value = vm.CompChoice();
        }
        private void spockBtn_Click(object sender, RoutedEventArgs e)
        {
            vm.UserChoice(2);
            vm.WinOrLose(value, 2);
            ShowChoiceImg(value, 2);
            value = vm.CompChoice();
        }
        private void scissorsBtn_Click(object sender, RoutedEventArgs e)
        {
            vm.UserChoice(3);
            vm.WinOrLose(value, 3);
            ShowChoiceImg(value, 3);
            value = vm.CompChoice();
        }
        private void paperBtn_Click(object sender, RoutedEventArgs e)
        {
            vm.UserChoice(4);
            vm.WinOrLose(value, 4);
            ShowChoiceImg(value, 4);
            value = vm.CompChoice();
        }
        private void ShowChoiceImg(int compNum, int playerNum)
        {
            HideChoiceImg();
            if (playerNum == 0)
                playerRock.Visibility = Visibility.Visible;
            else if (playerNum == 1)
                playerLizard.Visibility = Visibility.Visible;
            else if (playerNum == 2)
                playerSpock.Visibility = Visibility.Visible;
            else if (playerNum == 3)
                playerScissors.Visibility = Visibility.Visible;
            else
                playerPaper.Visibility = Visibility.Visible;
            if (compNum == 0)
                compRock.Visibility = Visibility.Visible;
            else if (compNum == 1)
                compLizard.Visibility = Visibility.Visible;
            else if (compNum == 2)
                compSpock.Visibility = Visibility.Visible;
            else if (compNum == 3)
                compScissors.Visibility = Visibility.Visible;
            else
                compPaper.Visibility = Visibility.Visible;
        }
        private void HideChoiceImg()
        {
            compRock.Visibility = Visibility.Hidden;
            compLizard.Visibility = Visibility.Hidden;
            compSpock.Visibility = Visibility.Hidden;
            compScissors.Visibility = Visibility.Hidden;
            compPaper.Visibility = Visibility.Hidden;
            playerRock.Visibility = Visibility.Hidden;
            playerLizard.Visibility = Visibility.Hidden;
            playerSpock.Visibility = Visibility.Hidden;
            playerScissors.Visibility = Visibility.Hidden;
            playerPaper.Visibility = Visibility.Hidden;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.ResetScore();
            HideChoiceImg();
        }
    }
}
