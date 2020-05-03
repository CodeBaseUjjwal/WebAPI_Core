using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
	public class UserRequestModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Age { get; set; }
		public string ImageUploadFilePath { get; set; }
	}
}
