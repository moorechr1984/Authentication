﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUser
    {
	    string FirstName { get; }
		string LastName { get; }
		Guid UserId { get; }
		string UserName { get; }

		
	}
}
