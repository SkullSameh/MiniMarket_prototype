namespace FinalProject_190209998;
using SQLite;
public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        App.DB.Init();

        UserName.Text = App.DB.GetName();
        Address.Text = App.DB.GetAddress();
        Email.Text = App.DB.GetEmail();
        Phone.Text = App.DB.GetPhone();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    private async void Save_Clicked(object sender, EventArgs e)
    {

         if (UserName.Text == null || Email.Text == null || Phone.Text == null || Address.Text == null)
        {
            await DisplayAlert("Error", "Enter_Inputs", "OK");
        }
        else
        {
            App.DB.Add(new Models.Customer
            {
                Cust_Name = UserName.Text,
                Cust_Address = Address.Text,
                Cust_Email = Email.Text,
                Cust_Phone = Phone.Text,
            });
        }



    }

    private void Clear_Clicked(object sender, EventArgs e)
    {
        App.DB.Delete();
        UserName.Text = null;
        Address.Text = null;
        Email.Text = null;
        Phone.Text = null;
    }
}

