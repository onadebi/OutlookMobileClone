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

    protected override void OnAppearing()
    {
        LoadingIndicator.IsVisible = true;

        base.OnAppearing();

        var httpClient = new HttpClient();

        var jsonResponse = new List<Simpson>
        {
            new Simpson() {image = "https://images.pexels.com/photos/6801642/pexels-photo-6801642.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",character=$"Onasonic {Guid.NewGuid().ToString().Substring(0,5)}",quote="lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum " },
            new Simpson() {image = "https://images.pexels.com/photos/6801642/pexels-photo-6801642.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",character=$"Onasonic {Guid.NewGuid().ToString().Substring(0,5)}",quote="lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum " },
            new Simpson() {image = "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",character=$"Onasonic {Guid.NewGuid().ToString().Substring(0,5)}",quote="lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum " },
            new Simpson() {image = "https://images.pexels.com/photos/6801642/pexels-photo-6801642.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",character=$"Onasonic {Guid.NewGuid().ToString().Substring(0,5)}",quote="lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum " },
            new Simpson() {image = "https://images.pexels.com/photos/6801642/pexels-photo-6801642.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",character=$"Onasonic {Guid.NewGuid().ToString().Substring(0,5)}",quote="lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum " },
            new Simpson() {image = "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",character=$"Onasonic {Guid.NewGuid().ToString().Substring(0,5)}",quote="lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum " },
            new Simpson() {image = "https://images.pexels.com/photos/6801642/pexels-photo-6801642.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",character=$"Onasonic {Guid.NewGuid().ToString().Substring(0,5)}",quote="lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum " },
            new Simpson() {image = "https://images.pexels.com/photos/6801642/pexels-photo-6801642.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",character=$"Onasonic {Guid.NewGuid().ToString().Substring(0,5)}",quote="lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum " },
            new Simpson() {image = "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",character=$"Onasonic {Guid.NewGuid().ToString().Substring(0,5)}",quote="lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum " },
            new Simpson() {image = "https://images.pexels.com/photos/6801642/pexels-photo-6801642.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",character=$"Onasonic {Guid.NewGuid().ToString().Substring(0,5)}",quote="lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum lorem Ipsum " },
        };
            //await httpClient.GetFromJsonAsync<List<Simpson>>(contentUri);

        jsonResponse.ForEach(s => Simpsons.Add(s));
        
        LoadingIndicator.IsVisible = false;
    }

    private async void NewBtn_Clicked(object sender, EventArgs e)
	{
		await DisplayAlert("New Mail", "Create new mail?", "Ok", "Cancel");
	}
}

