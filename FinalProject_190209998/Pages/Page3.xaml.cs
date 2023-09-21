namespace FinalProject_190209998;

public partial class Page3 : ContentPage
{
    int Price;
	public Page3()
	{
		InitializeComponent();
		App.DB.Init();
        ALL.TotalPrice = App.DB.GetOrdPrice();
        Cart_List.ItemsSource = App.DB.getALLorder();
        Price = App.DB.GetOrdPrice();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Cart_List.ItemsSource = App.DB.getALLorder();
        Price = App.DB.GetOrdPrice();
        TotalPrice.Text = Price.ToString();

    }

    private async void Pay_Clicked(object sender, EventArgs e)
    {
        if(Cardholder.Text == null || Card_NO == null || CVV == null || Date == null)
        {
            await DisplayAlert("Missing", "Please Write Your Informaion", "OK");
        }
        else if (Price == 0)
        {
            await DisplayAlert("Add to cart", "Please put anything in cart", "OK");
        }
        else
        {
            DateTime local = DateTime.Now;

            App.DB.AddPay(new Models.Payment
            {
                Date = local,
                Pay_amt = Price
            });

            App.DB.DeleteOrd();
            Cart_List.ItemsSource = App.DB.getALLorder();
            Price = App.DB.GetOrdPrice();
            TotalPrice.Text = Price.ToString();

            await DisplayAlert("Good", "Your Order is on the way :D", "OK");
        }

    }
}