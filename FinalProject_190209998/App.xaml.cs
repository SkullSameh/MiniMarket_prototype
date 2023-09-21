using FinalProject_190209998.DataTrans;

namespace FinalProject_190209998;

public partial class App : Application
{
	public static MarketDB DB { get; private set; }
	public App(MarketDB trans)
	{
		InitializeComponent();

		MainPage = new AppShell();
		DB = trans;
	}
}
