namespace SelTarot.Models
{
    public class UserManagementViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public IList<string> Roles { get; set; } // Roller için liste
       
    }

}
