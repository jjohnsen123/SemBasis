namespace MauiApp2;

public partial class SuperHero : ContentPage
{
	public SuperHero()
	{
		InitializeComponent();
	}


    private void Btn1_Clicked(object sender, EventArgs e)
    {
        string text = lbl1.Text;

        lbl1.Text = lbl3.Text;
        lbl3.Text = text;
    }

    private void Btn2_Clicked(object sender, EventArgs e)
    {
        string text = lbl4.Text;

        lbl4.Text = lbl2.Text;
        lbl2.Text = text;
    }
}