using StrategyWPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StrategyWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChoosingUnitPage.xaml
    /// </summary>
    public partial class ChoosingUnitPage : Page
    {
        public Classes.Unit unit;
        public ChoosingUnitPage()
        {
            InitializeComponent();
        }
        
        private void WizardBtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.Wizard wizard = new Classes.Wizard(0, 0, 0, 0);
            strengthTb.Text = wizard.Strength.ToString() + "/" + wizard.MaxStrength.ToString();
            inteligenceTb.Text = wizard.Intelligence.ToString() + "/" + wizard.MaxIntelligence.ToString();
            dexterityTb.Text = wizard.Dexterity.ToString() + "/" + wizard.MaxDexterity.ToString();
            vitalityTb.Text = wizard.Vitality.ToString() + "/" + wizard.MaxVitality.ToString();
            unit = wizard;
        }
        private void RogueBtn_Click(object sender, RoutedEventArgs e)
        {
            Rogue rogue = new Rogue(0, 0, 0, 0);
            strengthTb.Text = rogue.Strength.ToString() + "/" + rogue.MaxStrength.ToString();
            inteligenceTb.Text = rogue.Intelligence.ToString() + "/" + rogue.MaxIntelligence.ToString();
            dexterityTb.Text = rogue.Dexterity.ToString() + "/" + rogue.MaxDexterity.ToString();
            vitalityTb.Text = rogue.Vitality.ToString() + "/" + rogue.MaxVitality.ToString();
            unit = rogue;
        }

        private void WarriorBtn_Click(object sender, RoutedEventArgs e)
        {
            Warrior warrior = new Warrior(0, 0, 0, 0);
            strengthTb.Text = warrior.Strength.ToString() + "/" + warrior.MaxStrength.ToString();
            inteligenceTb.Text = warrior.Intelligence.ToString() + "/" + warrior.MaxIntelligence.ToString();
            dexterityTb.Text = warrior.Dexterity.ToString() + "/" + warrior.MaxDexterity.ToString();
            vitalityTb.Text = warrior.Vitality.ToString() + "/" + warrior.MaxVitality.ToString();
            unit = warrior;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ChooseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (unit == null) MessageBox.Show("Choose someone!!!");
            else
                NavigationService.Navigate(new LevelUpPage(unit));
        }
    }
}
