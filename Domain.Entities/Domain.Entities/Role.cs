using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface Role
	{
		int Id { get; }
		IList<IPermission> permission { get; }
	}
}
