using Proekt_Aspa.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proekt_Aspa.Models
{
	class Rooms : BaseModelClients
	{
		private decimal _price;
		private string _type;

		public decimal Price
		{
			get { return _price; }
			set { _price = value; }
		}
		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public void whatRoom()
		{

		}
		public void room()
		{

			Room_Price room1 = new Room_Price();
			room1.ID = 1;
			room1.Type = "double room";
			room1.Price = 50;

			Room_Price ap = new Room_Price();
			ap.ID = 2;
			ap.Type = "apartment";
			ap.Price = 70;
		}
	}
}
