namespace Lek12MauiApp1;
using CommunityToolkit.Maui.Views;


public partial class EditDialogue : Popup
{
	public EditDialogue(Car carForEdit)
	{
		InitializeComponent();
		CarForEdit = carForEdit;
	}

	private Car carForEdit;

	internal Car CarForEdit
	{
		get { return carForEdit; }
		set
		{
			carForEdit = value;
			ModelEntry.BindingContext = carForEdit;
			HorsePowerEntry.BindingContext = carForEdit;
            IsElectricChkBox.BindingContext = carForEdit;

        }
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		this.Close();
    }
}