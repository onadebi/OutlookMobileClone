using OutlookMobileClone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMobileClone.Services
{
    public class MonkeyService
    {
        List<Monkey> monkeyList = new();
        HttpClient _httpClient;
        public MonkeyService() {
            this._httpClient = new HttpClient();

        }

        public async Task<List<Monkey>> GetMonkeys()
        {
            if (monkeyList.Count > 0) return monkeyList;
            var response = await _httpClient.GetAsync("https://montemagno.com/monkeys.json");
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            }

            return monkeyList;
        }

    }
}
