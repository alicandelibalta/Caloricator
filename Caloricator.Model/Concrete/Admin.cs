using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caloricator.Model.Concrete
{
	public class Admin
	{
		int AdminId { get; set; }
		string AdminName { get; set; }
		string AdminSurname { get; set; }
		string Password { get; set; }
		string Email { get; set; }

	}
}
