using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.ViewModels
{
	public class BasketSummaryViewModel
	{
		public int BastCount { get; set; }
		public decimal BasketTotal { get; set; }

		public BasketSummaryViewModel()
		{

		}

		public BasketSummaryViewModel(int basketCount, decimal basketTotal)
		{
			this.BasketTotal = basketTotal;
			this.BastCount = basketCount;
		}
	}
}
