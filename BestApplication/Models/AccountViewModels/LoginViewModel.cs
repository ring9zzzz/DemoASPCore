using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestApplication.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Vui lòng nhập email")]
        [EmailAddress(ErrorMessage ="Vui lòng nhập đúng định dạng email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Ghi nhớ tài khoản")]
        public bool RememberMe { get; set; }
    }
}
