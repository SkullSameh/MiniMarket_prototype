namespace FinalProject_190209998;

public partial class AdminPage : ContentPage
{
	public AdminPage()
	{
		InitializeComponent();
        Access.IsVisible = true;
        App.DB.Init();
        Name.Text = App.DB.GetName();
    }

    private void Login_Clicked(object sender, EventArgs e)
    {
        if (Name.Text == "Skull" && Pass.Text == "12")
		{
            Access.IsVisible = true;
        }
    }
    int Price;
    private void ADD_Clicked(object sender, EventArgs e)
    {
        int.TryParse(Pro_Price.Text, out Price);
        App.DB.AddPro(new Models.Peoduct
        {
            Pro_Name = Pro_Name.Text,
            Pro_Price = Price
        });
    }

    int ID;
    private void Remove_Clicked(object sender, EventArgs e)
    {
        int.TryParse(Pro_Name.Text, out ID);
        App.DB.DeleteOnePro(ID);
    }
}