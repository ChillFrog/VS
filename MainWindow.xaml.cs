using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool xturn = true;
        int Owin = 0;
        int Xwin = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button SenderB = (Button)sender;
            if (SenderB.Content == "")
            {
                if (xturn)
                {
                    SenderB.Content = "X";
                    Move.Content = "  O";
                }
                else
                {
                    SenderB.Content = "O";
                    Move.Content = "  X";
                }
            }
            xturn = !xturn;
            CheckWin(SenderB);
        }
        public void CheckWin(Button pressedbutton)
        {
            XWins.Content = Xwin;
            if (Button11.Content == Button12.Content && Button12.Content == Button13.Content && Button12.Content != "")
            {
                if (pressedbutton.Content == "X")
                {
                    Xwin++;
                    XWins.Content = Xwin;
                }
                else if (pressedbutton.Content == "O")
                {
                    Owin++;
                    OWins.Content = Owin;
                }
                MessageBox.Show("Победили " + pressedbutton.Content);
                NewGame();
            }
            if (Button21.Content == Button22.Content && Button22.Content == Button23.Content && Button22.Content != "")
            {
                if (pressedbutton.Content == "X")
                {
                    Xwin++;
                    XWins.Content = Xwin;
                }
                else if (pressedbutton.Content == "O")
                {
                    Owin++;
                    OWins.Content = Owin;
                }
                MessageBox.Show("Победили " + pressedbutton.Content);
                NewGame();
            }
            if (Button31.Content == Button32.Content && Button32.Content == Button33.Content && Button32.Content != "")
            {
                if (pressedbutton.Content == "X")
                {
                    Xwin++;
                    XWins.Content = Xwin;
                }
                else if (pressedbutton.Content == "O")
                {
                    Owin++;
                    OWins.Content = Owin;
                }
                MessageBox.Show("Победили " + pressedbutton.Content);
                NewGame();
            }
            if (Button11.Content == Button21.Content && Button21.Content == Button31.Content && Button31.Content != "")
            {
                if (pressedbutton.Content == "X")
                {
                    Xwin++;
                    XWins.Content = Xwin;
                }
                else if (pressedbutton.Content == "O")
                {
                    Owin++;
                    OWins.Content = Owin;
                }
                MessageBox.Show("Победили " + pressedbutton.Content);
                NewGame();
            }
            if (Button12.Content == Button22.Content && Button22.Content == Button32.Content && Button22.Content != "")
            {
                if (pressedbutton.Content == "X")
                {
                    Xwin++;
                    XWins.Content = Xwin;
                }
                else if (pressedbutton.Content == "O")
                {
                    Owin++;
                    OWins.Content = Owin;
                }
                MessageBox.Show("Победили " + pressedbutton.Content);
                NewGame();
            }
            if (Button13.Content == Button23.Content && Button23.Content == Button33.Content && Button23.Content != "")
            {
                if (pressedbutton.Content == "X")
                {
                    Xwin++;
                    XWins.Content = Xwin;
                }
                else if (pressedbutton.Content == "O")
                {
                    Owin++;
                    OWins.Content = Owin;
                }
                MessageBox.Show("Победили " + pressedbutton.Content);
                NewGame();
            }
            if (Button11.Content == Button22.Content && Button22.Content == Button33.Content && Button22.Content != "")
            {
                if (pressedbutton.Content == "X")
                {
                    Xwin++;
                    XWins.Content = Xwin;
                }
                else if (pressedbutton.Content == "O")
                {
                    Owin++;
                    OWins.Content = Owin;
                }
                MessageBox.Show("Победили " + pressedbutton.Content);
                NewGame();
            }
            if (Button31.Content == Button22.Content && Button22.Content == Button13.Content && Button22.Content != "")
            {
                if (pressedbutton.Content == "X")
                {
                    Xwin++;
                    XWins.Content = Xwin;
                }
                else if (pressedbutton.Content == "O")
                {
                    Owin++;
                    OWins.Content = Owin;
                }
                MessageBox.Show("Победили " + pressedbutton.Content);
                NewGame();
            }
            if (Button11.Content !="" && Button12.Content !="" && Button13.Content != "" && Button21.Content != "" && Button22.Content != "" && Button23.Content != "" && Button31.Content != "" && Button32.Content != "" &&Button33.Content!= "")
            {
                MessageBox.Show("Ничья");
                NewGame();
            }
        }
        public void NewGame()
        {
            xturn = true;
            Button11.Content = "";
            Button12.Content = "";
            Button13.Content = "";
            Button21.Content = "";
            Button22.Content = "";
            Button23.Content = "";
            Button31.Content = "";
            Button32.Content = "";
            Button33.Content = "";
        }

        private void New_game_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }
    }
}
