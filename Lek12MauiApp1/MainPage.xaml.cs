namespace Lek12MauiApp1
{
    public partial class MainPage : ContentPage
    {
        Car car = new Car { Model = "Tesla Model Y", Horsepower = 342, IsElectric = true };

        public MainPage()
        {
            InitializeComponent();
            entrycontainer.BindingContext = car;
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Car", $"Model: {car.Model}, Horsepower: {car.Horsepower}, Is Electric: {car.IsElectric}", "Ok");
        }
    }
}
