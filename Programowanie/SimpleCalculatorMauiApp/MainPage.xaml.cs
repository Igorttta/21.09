namespace SimpleCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //pobranie danych
            //    pobranie pierwszej liczby
            //    pobranie drugiej liczby
            //obliczenie wyniku
            //pokazanie wyniku

            //int firstNumber = int.Parse(firstNumberEntry.Text);

            //int firstNumber;
            if (int.TryParse(firstNumberEntry.Text, out int firstNumber)
                && int.TryParse(secondNumberEntry.Text, out int secondNumber))
            {
                int result = firstNumber + secondNumber;
                resultLabel.Text = "Wynik to " + result;
                resultLabel.BackgroundColor = Colors.Green;
            }
            else
            {
                resultLabel.Text = "Podałeś nieprawidłowe dane";
                resultLabel.BackgroundColor = Colors.Red;
            }
        }
    }
}
