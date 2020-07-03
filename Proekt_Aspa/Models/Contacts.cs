using Proekt_Aspa.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proekt_Aspa.Models
{
	public class Contacts : BaseModelClients
	{
		private int _telNumber;
		private string _adress;
		private string _email;

		public int TelNumber
		{
			get { return _telNumber; }
			set { _telNumber = value; }
		}
		public string Adress
		{
			get { return _adress; }
			set { _adress = value; }
		}
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}



		public Contacts()
		{
			this.Email = "contact@aspa-hotel.com";
			this.TelNumber = 0887518407;
		}



	}
}
