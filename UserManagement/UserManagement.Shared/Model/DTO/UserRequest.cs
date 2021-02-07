using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Model
{
    [Table("Users")]
    public class UserRequest
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string UserName { get; set; }

        public string LastName { get; set; }

        public string TimeZone { get; set; }

        public string WebSite { get; set; }

        public string PhoneSkype { get; set; }

        public string ImageData { get; set; }

        public string About { get; set; }
    }
}