using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FontStyleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontStyleComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string fontFamily = selectedItem.Content.ToString();
                TextBox1.FontFamily = new System.Windows.Media.FontFamily(fontFamily);
                TextBox2.FontFamily = new System.Windows.Media.FontFamily(fontFamily);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CloseButton.IsEnabled = string.IsNullOrWhiteSpace(TextBox1.Text) && string.IsNullOrWhiteSpace(TextBox2.Text);
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика открытия файла
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
