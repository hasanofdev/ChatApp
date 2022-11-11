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

namespace ChatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();


        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(MessageTxt.Text))
                return;

            MessageControl msgcontrol = new MessageControl(MessageTxt.Text);
            
            MessagesPanel.Items.Add(msgcontrol);
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UsernameTxt.Text))
                MessageBox.Show("Username Is Incorrect!");
            UserChip.Content = UsernameTxt.Text.ToUpper();
            LogInGrid.Visibility = Visibility.Collapsed;
        }
    }
}
