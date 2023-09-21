namespace FinalProject_190209998;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
		App.DB.Init();

		Pay_List.ItemsSource = App.DB.GetPayList();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Pay_List.ItemsSource = App.DB.GetPayList();
    }
}