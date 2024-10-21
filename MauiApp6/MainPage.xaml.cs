using System.Collections.ObjectModel;

namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<String> Items1 = new ObservableCollection<String>();
        ObservableCollection<String> Items2 = new ObservableCollection<String>();

        public MainPage()
        {
            InitializeComponent();
            List1.ItemsSource = Items1;
            List2.ItemsSource = Items2;
        }

        private void Add1_Clicked(object sender, EventArgs e)
        {
            Items1.Add(Text1.Text);
        }

        private void Add2_Clicked(object sender, EventArgs e)
        {
            Items2.Add(Text2.Text);
        }

        private void Right_Clicked(object sender, EventArgs e)
        {
            if (List1.SelectedItems.Count > 0)
            {
                for (int i = List1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    Items2.Add((String)List1.SelectedItems[i]);
                    Items1.Remove((String)List1.SelectedItems[i]);
                }
            }
        }

        private void Left_Clicked(object sender, EventArgs e)
        {
            if (List2.SelectedItems.Count > 0)
            {
                for (int i = List2.SelectedItems.Count - 1;i >= 0;i--)
                {
                    Items1.Add((String)List2.SelectedItems[i]);
                    Items2.Remove((String)List2.SelectedItems[i]);
                }
            }
        }

        private void Clear1_Clicked(object sender, EventArgs e)
        {
            Items1.Clear();
        }

        private void Clear2_Clicked(object sender, EventArgs e)
        {
            Items2.Clear();
        }
    }

}
