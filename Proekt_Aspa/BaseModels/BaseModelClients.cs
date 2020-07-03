using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proekt_Aspa.BaseModels
{
	public abstract class BaseModelClients
	{

		private string _firstname;
		private long _phonenumber;
		private string _lastname;
		private int _broiGosti;
		private int _id;



		public int ID
		{
			get { return _id; }
			set { _id = GenerateId(); }
		}

		public string FirstName
		{
			get { return _firstname; }
			set { _firstname = value; }
		}

		public string LastName
		{
			get { return _lastname; }
			set { _lastname = value; }
		}

		public long PhoneNumber
		{
			get { return _phonenumber; }
			set { _phonenumber = value; }
		}

		public DateTime DateCreated { get; set; }

		public DateTime DataClose { get; set; }



		public int BroiGosti
		{
			get { return _broiGosti; }
			set { _broiGosti = value; }
		}

		public int GenerateId()
		{
			int _id = 1;

			return _id++;
		}
	}
}
