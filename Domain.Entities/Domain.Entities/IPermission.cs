using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public class Permission
	{
		int Id { get; set; }
		string Description { get; set; }
		string Name { get; set; }
	}
}
