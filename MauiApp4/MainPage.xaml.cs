namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
        {
            MenuFlyoutItem text = (MenuFlyoutItem)sender;

            lbl1.Text = text.Text;
        }
    }

}
