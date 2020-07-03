using Proekt_Aspa.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proekt_Aspa.Models
{
	public class Room_Price : BaseModelClients
	{
		private string _type;
		private decimal _price;
		//private int _id;

		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public decimal Price
		{
			get { return _price; }
			set { _price = value; }
		}



		public Room_Price()
		{

		}
	}
}
