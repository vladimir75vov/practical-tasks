using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Authorization_Form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool validateLogin(string login)
        {
            if (login.Length < 3 || login.Length > 20)
                return false;

            return true;
        }

        public bool validatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 20)
                return false;

            if (!password.Any(Char.IsLower))
                return false;

            if (!password.Any(Char.IsUpper))
                return false;

            if (!password.Any(Char.IsDigit))
                return false;

            if (password.Intersect("!@#$%^&*()_+=-<>,./?';:\\|").Count() == 0)
                return false;

            return true;
        }

        public bool validatePasswordSecond(string passwordOne, string passwordTwo)
        {
            if (passwordOne != passwordTwo)
                return false;

            return true;
        }

        public bool validateEmail(string email)
        {
            if (email.Length < 3)
                return false;

            if (!email.Contains("@") || !email.Contains("."))
                return false;

            return true;
        }

        public bool validate(string login, string passOne, string passTwo, string email)
        {
            string toolTip = "Это поле введено не корректно!";

            SolidColorBrush brushesError = Brushes.PaleVioletRed;
            SolidColorBrush brushesAccses = Brushes.Transparent;

            if (validateLogin(login) == false)
            {
                textBoxLogin.ToolTip = toolTip;
                textBoxLogin.Background = brushesError;

                return false;
            }

            textBoxLogin.ToolTip = "";
            textBoxLogin.Background = brushesAccses;

            if (validatePassword(passOne) == false)
            {
                passwordBoxPassOne.ToolTip = toolTip;
                passwordBoxPassOne.Background = brushesError;

                return false;
            }

            passwordBoxPassOne.ToolTip = "";
            passwordBoxPassOne.Background = brushesAccses;

            if (validatePasswordSecond(passOne, passTwo) == false)
            {
                passwordBoxPassTwo.ToolTip = toolTip;
                passwordBoxPassTwo.Background = brushesError;

                return false;
            }

            passwordBoxPassTwo.ToolTip = "";
            passwordBoxPassTwo.Background = brushesAccses;


            if (validateEmail(email) == false)
            {
                textBoxEmail.ToolTip = toolTip;
                textBoxEmail.Background = brushesError;

                return false;
            }

            textBoxEmail.ToolTip = "";
            textBoxEmail.Background = brushesAccses;

            return true;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string passOne = passwordBoxPassOne.Password.Trim();
            string passTwo = passwordBoxPassTwo.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            validate(login, passOne, passTwo, email);

            var test = DBMySQL.getDBArrayData("INSERT INTO `mydb`.`user` (`idUser`, `login`, `pass`, `email`) VALUES ('5', 'asdad', 'sda', 'zasdsdazxc@gmail.com');").ToString();
            MessageBox.Show(test);
        }
    }
}
