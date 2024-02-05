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
using Homework.Helper;

namespace Homework
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : ContentControl
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            var user = ClassDB.entity.User.Where(i => i.Login == txbLogin.Text && i.Password == psbPassword.Password).FirstOrDefault();

            if (user.IdRole == 1)
            {
                ClassFrame.frameAuth.Content = new Admin();
            }
            else if (user.IdRole == 2)
            {
                ClassFrame.frameAuth.Content = new Userrr();
            }
            else if (user.IdRole == 3)
            {
                ClassFrame.frameAuth.Content = new Student();
            }
            
        }
    }
}
