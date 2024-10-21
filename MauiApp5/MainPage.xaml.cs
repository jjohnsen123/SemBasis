namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void DirectionChoice_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                RadioButton selected = (RadioButton)sender;
                RadioStatus.Text = $"Selected direction: {selected.Content}";
            }
        }

        private void FruitChkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            string selectedFruits = "";
            if (LemonChkBox.IsChecked) selectedFruits += "Lemon, ";
            if (OrangeChkBox.IsChecked) selectedFruits += "Orange, ";
            if (BananaChkBox.IsChecked) selectedFruits += "Banana, ";

            if (selectedFruits.EndsWith(", "))
                selectedFruits = selectedFruits.Substring(0, selectedFruits.Length - 2);

            CheckboxStatus.Text = String.IsNullOrEmpty(selectedFruits) ? "No fruits selected" : $"Selected fruits: {selectedFruits}";
        }
    }

}
