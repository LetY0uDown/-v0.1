using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Tick += Timer_Tick;
        }

        private DispatcherTimer timer = new DispatcherTimer();
        private int index = 0;

        private void bStartJourney_Click(object sender, RoutedEventArgs e)
        {
            bStartJourney.Visibility = Visibility.Collapsed;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            textCatJourney.Text = messages[index++];
        }

        private string[] messages =
        {
            "Лёха Пожиратель Миров съел целый мир",
            "Лёха Пожиратель Миров растворяет мир в глубинах своего желудка",
            "Лёха Пожиратель Миров заснул великим сном",
            "Вселенные исчезают пока Лёха Пожиратель Миров видит великие сны",
            "Лёха Пожиратель Миров вот-вот восстанет ото сна, и отправится искать очередной мир",
            "Лёха Пожиратель Миров в поисках своей новой жертвы",
            "Лёха Пожиратель Миров обратил свой взор на чей-то уютный мирок",
            "Лёха Пожиратель Миров съел ещё один мир",
        };
    }
}
