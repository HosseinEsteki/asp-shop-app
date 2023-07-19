using Microsoft.Identity.Client;
using ShopApp.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApp.Models.Design
{
	public class MenuItem
	{
		public MenuItem()
		{
			Suns = new List<MenuItem>();
		}
		public int Id { get; set; }
		[MaxLength(50)]
		[Required]
        public string Title { get; set; }
        [MaxLength(50)]

        public string? Classes { get; set; }
		[MaxLength(300)]
		public string? Path { get; set; }
		public int? Index { get; set; }
		public int? FatherId { get; set; } = null;
		public List<MenuItem>? Suns;

		#region Relations
		//public Role? Role { get; set; }
		//public int? RoleId { get; set; }
		//public Permission? Permission { get; set; }
		//public int? PermissionId { get; set; }
		#endregion
	}
}
