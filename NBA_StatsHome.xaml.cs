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

namespace NBA_Stats
{
    /// <summary>
    /// Interaction logic for NBA_StatsHome.xaml
    /// </summary>
    public partial class NBA_StatsHome : Page
    {
        public NBA_StatsHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            View_Stats viewStatsPage = new View_Stats(this.playerListBox.SelectedItem);
            this.NavigationService.Navigate(viewStatsPage);
        }
    }
}
