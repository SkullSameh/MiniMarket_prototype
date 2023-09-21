namespace FinalProject_190209998;

public partial class Page2 : ContentPage
{
	public List<ALL> all = new List<ALL>();
	public Page2()
	{
		InitializeComponent();

		App.DB.Init();
	//	App.DB.DeletePro();
        /*
        App.DB.AddPro(new Models.Peoduct
		{
			Pro_Name = "Apple",
			Pro_IMG = "apple.jpeg",
			Pro_Price = 12
		});

        App.DB.AddPro(new Models.Peoduct
        {
            Pro_Name = "Orange",
            Pro_IMG = "orange.png",
            Pro_Price = 10
        });

        App.DB.AddPro(new Models.Peoduct
        {

            Pro_Name = "Tea",
            Pro_IMG = "tea.jpeg",
            Pro_Price = 23
        });

        App.DB.AddPro(new Models.Peoduct
        {

            Pro_Name = "Coffe",
            Pro_IMG = "coffe.jpeg",
            Pro_Price = 40
        });
        */


        Pro_List.ItemsSource = null;
        Pro_List.ItemsSource = App.DB.GetProList();
        ALL.TotalPrice = App.DB.GetOrdPrice();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Pro_List.ItemsSource = null;
        Pro_List.ItemsSource = App.DB.GetProList();
        ALL.TotalPrice = App.DB.GetOrdPrice();
    }

    private void ADD_Clicked(object sender, EventArgs e)
    {
        ALL.TotalPrice += PPrice;
        App.DB.AddOrder(new Models.Order
        {
            Pro = new Models.Peoduct
            {
                Pro_Name = PName,
                Pro_Price = PPrice,
            },
            Ord_Pro = PName,
            Ord_Pro_Price = PPrice,
            Ord_Price = ALL.TotalPrice,
        }) ;
    }

   public string PName;
   public int PPrice;
    private void Pro_List_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tap = e.Item as Models.Peoduct;
        PName = tap.Pro_Name; 
        PPrice = tap.Pro_Price;
    }
}