using OutlookMobileClone.ViewModel;

namespace OutlookMobileClone.Views;

public partial class MonkeyMainPage : ContentPage
{
	public MonkeyMainPage(MonkeysViewModel monkeysViewModel)
	{
		InitializeComponent();
		BindingContext= monkeysViewModel;
	}
}