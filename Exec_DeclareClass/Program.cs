using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Address Addr = new Address();
			Addr.city = "板橋";
			Addr.ZipCode = "220";
			Addr.street = "大觀路";

			Telephone Tele = new Telephone();
			Tele.CountryCode = "886";
			Tele.AreaCode = "02";
			Tele.Number="2685 4433";
			Tele.Ext = "508";

			Member Mem = new Member();
			Mem.Name = "Evan";
			Mem.Account = "Evan0511";
			Mem.Password = "evan123456";
			Mem.Email = "Evan221023@gmail.com";
			Mem.Cellphone = "09445566";

			Mem.Register("Evan", "Evan0511", "evan123456", "evan123456", "Evan221023@gmail.com");
			Mem.ForgetPassword("Evan","Evan221023@gmail.com");
			Mem.Authenticate("Evan0511", "evan123456");

		}
	}
	class Address
	{
		public string city;
		public string ZipCode;
		public string street;
	}
	class Telephone
	{
		public string CountryCode;
		public string AreaCode;
		public string Number;
		public string Ext;
	}
	class Member
	{
		public string Name;
		public string Account { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string Cellphone { get; set; }
		public Address Addr{ get; set; }
		public Telephone Tele { get; set; }
		public void Register(string Name, string Account, string Password,string ConfirmPassword,string email) { }
		public void ForgetPassword(string Name, string Email) { }
		public void Authenticate(string Account, string Password) { }

	}

}
