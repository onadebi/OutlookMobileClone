using OutlookMobileClone.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace OutlookMobileClone;

public partial class MainPage : ContentPage
{
    private string contentUri = "https://thesimpsonsquoteapi.glitch.me/quotes?count=20";

    public ObservableCollection<Simpson> Simpsons = new();

    public MainPage()
	{
		InitializeComponent();
        MessageCollection.ItemsSource = Simpsons;
    }

    protected async override void OnAppearing()
    {
        LoadingIndicator.IsVisible = true;

        base.OnAppearing();

        var httpClient = new HttpClient();

        var jsonResponse = await httpClient.GetFromJsonAsync<List<Simpson>>(contentUri);

        jsonResponse.ForEach(s => Simpsons.Add(s));
        
        LoadingIndicator.IsVisible = false;
    }

    private async void NewBtn_Clicked(object sender, EventArgs e)
	{
		await DisplayAlert("New Mail", "Create new mail?", "Ok", "Cancel");
	}
}

