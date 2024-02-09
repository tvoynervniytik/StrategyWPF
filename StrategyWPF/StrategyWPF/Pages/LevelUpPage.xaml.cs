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
using StrategyWPF.Classes;

namespace StrategyWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для LevelUpPage.xaml
    /// </summary>
    public partial class LevelUpPage : Page
    {
        public LevelUpPage(Unit CheckUnit)
        {
            InitializeComponent();
            NameTb.Text = CheckUnit.Name;
            dexterityTb.Text = CheckUnit.Dexterity + "/" + CheckUnit.MaxDexterity;
            inteligenceTb.Text = CheckUnit.Intelligence + "/" + CheckUnit.MaxIntelligence;
            strengthTb.Text = CheckUnit.Strength + "/" + CheckUnit.MaxStrength;
            vitalityTb.Text = CheckUnit.Vitality + "/" + CheckUnit.MaxVitality;
            if (CheckUnit.Name == "Wizard") wizImg.Visibility = Visibility.Visible;
            if (CheckUnit.Name == "Rogue") rogImg.Visibility = Visibility.Visible;
            if (CheckUnit.Name == "Warrior") warImg.Visibility = Visibility.Visible;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ChooseBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
