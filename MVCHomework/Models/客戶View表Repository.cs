using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVCHomework.Models
{   
	public  class 客戶View表Repository : EFRepository<客戶View表>, I客戶View表Repository
	{

	}

	public  interface I客戶View表Repository : IRepository<客戶View表>
	{

	}
}