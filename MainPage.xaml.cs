using OutlookMobileClone.Models;
using OutlookMobileClone.Views;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Windows.Input;

namespace OutlookMobileClone;


public partial class MainPage : ContentPage
{
    public ICommand LabelALertCommand = new Command((sender) =>
    {
        Label lbl = (Label)sender;
        Console.Write(lbl.Text); 
    });
    private string _contentUri = "https://thesimpsonsquoteapi.glitch.me/quotes?count=20";

    public ObservableCollection<Simpson> Simpsons = new();

    public MainPage()
    {
        InitializeComponent();
        MessageCollection.ItemsSource = Simpsons;
    }

    protected async override void OnAppearing()
    {
        LoadingIndicator.IsVisible = true;
        Simpsons.Clear();

        base.OnAppearing();

        var httpClient = new HttpClient();
        try
        {

        var jsonResponse = await httpClient.GetFromJsonAsync<List<Simpson>>(_contentUri);

        jsonResponse.ForEach(s => Simpsons.Add(s));
        }catch(Exception ex) { 
            Console.WriteLine(ex.Message); }

        LoadingIndicator.IsVisible = false;
    }

    private async void NewBtn_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("New Mail", "Create new mail?", "Ok", "Cancel");
        await Shell.Current.GoToAsync(nameof(MonkeyMainPage));
    }

    void AlertLabelContentClicked(object sender, TappedEventArgs e)
    {
        Label lbl = (Label)sender;
        Console.WriteLine(lbl.Text);
    }
}

