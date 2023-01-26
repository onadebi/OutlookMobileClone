using OutlookMobileClone.Models;
using OutlookMobileClone.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace OutlookMobileClone.ViewModel
{
    public class MonkeysViewModel : BaseViewModel
    {
        MonkeyService _monkeyService;
        public ObservableCollection<Monkey> Monkeys { get; } = new();
        public Command GetMonkeysCommand { get; }
        public MonkeysViewModel(MonkeyService monkeyService)
        {
            Title = "Monkey Finder";
            this._monkeyService = monkeyService;
            GetMonkeysCommand = new Command(async ()=> await GetMonkeysAsync());
        }

        async Task GetMonkeysAsync()
        {
            if (IsBusy) return;
            try
            {
                IsBusy = true;
                if (Monkeys.Count != 0) { Monkeys.Clear(); }
                var allMonkeys = await _monkeyService.GetMonkeys();
                allMonkeys.ForEach(m =>
                {
                    Monkeys.Add(m);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
