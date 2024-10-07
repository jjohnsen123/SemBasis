namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                Btn1.Text = $"Clicked this button {count} time";
            else
                Btn1.Text = $"Clicked this button {count} times";
            SemanticScreenReader.Announce(Btn1.Text);  

        }
    }

}
