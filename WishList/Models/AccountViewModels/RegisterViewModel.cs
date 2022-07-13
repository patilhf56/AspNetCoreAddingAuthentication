using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccontViewModels
{
    public class DataTypeAttribute
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(100, MinimumLength = 8)],private DataTypeAttribute(DataType.Password)]
        public string Phone Password { get; set; }
        [Required, System.ComponentModel.DataAnnotations.DataType(DataType.Password), Compare("Password", ErrorMessage = "The New Password and confirm New Password fields did not match.")]
        public string ConfirmPassword { get; set; }
    }
}
