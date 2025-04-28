using Avalonia.Controls;
using Avalonia.Interactivity;

namespace DailyPlanner;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        SubmitButton.Click += SubmitButton_Click;
    }

    private void SubmitButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            var taskName = TextBoxTaskName.Text;

            var category = (CategoryCombo.SelectedItem as ComboBoxItem)?.Content?.ToString() ??
                           "Nie wybrano odpowiedzi";
        }
        catch{}
    }


    public class Zadanie
    {
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public bool CzyUkonczone { get; set; }

        public Zadanie(string nazwa, string kategoria, bool czyUkonczone)
        {
            Nazwa = nazwa;
            Kategoria = kategoria;
            CzyUkonczone = czyUkonczone;
        }






    }
}