using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Views;

namespace Lek12MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Car> cars = new ObservableCollection<Car>();

        public MainPage()
        {
            InitializeComponent();
            cars.Add(new Car("Tesla Model Y", 342, true));
            cars.Add(new Car("Ford Ka", 800, false));
            CarList.ItemsSource = cars;
        }

        private void CarList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EditArea.BindingContext = CarList.SelectedItem;
        }

        private void ShowCars_Clicked(object sender, EventArgs e)
        {
            foreach (var car in cars)
            {
                DisplayAlert("Car", $"Model: {car.Model}, HorsePowers: {car.HorsePower}, Electric? {car.IsElectric}", "OK");
            }
        }

        private void EditCar_Clicked(object sender, EventArgs e)
        {
            cars[0].Model = "Berlingo";
        }

        private async void ShowEditDialogue_Clicked(object sender, EventArgs e)
        {
            EditDialogue popup = new EditDialogue((Car)CarList.SelectedItem);
            await this.ShowPopupAsync(popup);
        }
    }
}
