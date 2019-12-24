using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QLCT
{
    public class RestService : IRestService
    {
        HttpClient _client;

        public List<Wallet> Items { get; private set; }

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Wallet>> RefreshDataAsync()
        {
            Items = new List<Wallet>();

            var uri = new Uri(string.Format(Constants.TodoItemsUrl, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<Wallet>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }

        public async Task SaveTodoItemAsync(Wallet item, bool isNewItem)
        {
            var uri = new Uri(string.Format(Constants.TodoItemsUrl, string.Empty));

            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    response = await _client.PostAsync(uri, content);
                }
                else
                {
                    response = await _client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tWallet successfully saved.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

        public async Task DeleteTodoItemAsync(string _id)
        {
            var uri = new Uri(string.Format(Constants.TodoItemsUrl, _id));

            try
            {
                var response = await _client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tWallet successfully deleted.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }
    }
}
