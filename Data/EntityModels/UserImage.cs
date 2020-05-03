using System;

namespace Data.EntityModels
{
	public class UserImage
	{
		public int UserImageId { get; set; }
		public Guid ImageId;
		public Users User;
	}
}