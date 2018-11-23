using PagedList;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoE.Auth.Identity.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name="Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public partial class RegisterViewModel
    {
        //public IEnumerable<EduDbRespositoryLayer.ApplicationDbContext.vwMembersPerRole> MembersPerRole { get; set; }

        public int MemberTotal { get; set; }

        //public IEnumerable<EduDbRespositoryLayer.ApplicationDbContext.vwMailbox> ActiveMailBoxes { get; set; }
    }

    public partial class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [Required]
        [Display(Name = "Role")]
        public string UserRoles { get; set; }

        [Required]
        [Display(Name="Emis Code")]
        public string UserName { get; set; }

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class PersonViewModel
    {
    //    public IPagedList<EduDbRespositoryLayer.ApplicationDbContext.vwPersonalDetail> Persons { get; set; }

    //    public EduDbRespositoryLayer.ApplicationDbContext.vwPersonalDetail Person { get; set; }
    }


    public partial class AccountDetailsViewModel
    {
    //    public EduDbRespositoryLayer.ApplicationDbContext.Person PersonalDetails { get; set; }

    //    public EduDbRespositoryLayer.ApplicationDbContext.vwAddressDetail Address { get; set; }

    //    public EduDbRespositoryLayer.ApplicationDbContext.vwPositionDetail Position { get; set; }

    //    public EduDbRespositoryLayer.ApplicationDbContext.vwAccountSetting Settings { get; set; }

    //    public EduDbRespositoryLayer.ApplicationDbContext.Contact Contact { get; set; }

    }


/* Resets Password */
    public partial class AccountDetailsViewModel
    {
        [Required]
        public int EmisCode { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }

    }

    public class PasswordResetResponseViewModel
    {
        public int IsResetSuccess { get; set; }
    }

    public class ImpersonateViewModel
    {
        [Required]
        [Display(Name = "Impersonate")]
        public string UserName { get; set; }

    }

}
