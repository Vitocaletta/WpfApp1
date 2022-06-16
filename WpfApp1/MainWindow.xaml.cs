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
        qwertyEntities context;
        public MainWindow()
        {
            InitializeComponent();
            context = new qwertyEntities();
        }
        private void EnterClick(object sender, RoutedEventArgs e)
        {
            int IdWorker = Convert.ToInt32(Login.Text);
            string pass = Password.Text;

            Worker worker = context.Worker.ToList().Find(x => x.idWorker == IdWorker);
            if (worker == null)
            {
                MessageBox.Show("Работника с таким логином не существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else
            {
                if (worker.password.Equals(pass))
                {
                    MessageBox.Show("Успешная авторизация!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }


    }
}



