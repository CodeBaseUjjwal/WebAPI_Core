using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Data.EntityModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Services.User;

namespace API.Controllers
{
	[Route("api/[controller]")]
	public class UsersController : Controller
	{
		public IUserService _userService;

		private readonly IWebHostEnvironment _webHostEnvironment;
		public UsersController(IUserService userService, IWebHostEnvironment webHostEnvironment)
		{
			_userService = userService;
			_webHostEnvironment = webHostEnvironment;
		}

		// GET: api/<controller>
		[HttpGet]
		public IEnumerable<Users> Get()
		{
			return _userService.GetUserDetails();
		}

		// POST api/<controller>
		[HttpPost]
		public ActionResult Post([FromBody]UserRequestModel userDetails)
		{
			Users user = new Users();
			if (userDetails != null)
			{
				user.UserId = Guid.NewGuid();
				user.Age = Convert.ToInt32(userDetails.Age);
				user.FirstName = userDetails.FirstName;
				user.LastName = userDetails.LastName;

				if (!string.IsNullOrEmpty(userDetails.ImageUploadFilePath))
				{
					UploadedFile(userDetails.ImageUploadFilePath, user.UserId);
				}
				_userService.AddUserDetails(user);
			}
			else
			{
				return BadRequest("Invalid Request Body");
			}

			return Ok("User Added Successfully");
		}

		private void UploadedFile(string sourcePath, Guid userGuid)
		{
			string targetFolder = @"c:\\UserDetails\\UploadImage";

			if (Directory.Exists(sourcePath))
			{
				string[] files = Directory.GetFiles(sourcePath);

				if (!Directory.Exists(targetFolder)) Directory.CreateDirectory(targetFolder);

				foreach (string s in files)
				{
					string destFile = Path.Combine(targetFolder, userGuid.ToString());
					System.IO.File.Copy(s, destFile, true);
				}
			}
			else
			{
				Console.WriteLine("Source path does not exist!");
			}
		}
	}
}
