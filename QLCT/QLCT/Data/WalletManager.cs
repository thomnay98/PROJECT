using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLCT
{
	public class WalletManager : Wallet
	{
		IRestService restService;

		public WalletManager (IRestService service)
		{
			restService = service;
		}

		public Task<List<Wallet>> GetTasksAsync ()
		{
			return restService.RefreshDataAsync ();	
		}

		public Task SaveTaskAsync (Wallet item, bool isNewItem = false)
		{
			return restService.SaveTodoItemAsync (item, isNewItem);
		}

		public Task DeleteTaskAsync (Wallet item)
		{
			return restService.DeleteTodoItemAsync (item._id);
		}
	}

}
