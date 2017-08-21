using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace DaSite.Models
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
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        public string selectedValue { get; set; }

        public class GenItem
        {
            public string Value { get; set; }
            public string Text { get; set; }           
        }

        //Gender
        public IEnumerable<GenItem> GenderItems =
             new List<GenItem>
                {
                    new GenItem { Value="Male", Text="Male"},
                    new GenItem { Value="Female", Text="Female"},
                };

        public string Gender { get; set; }

        //Ethnicity
        public IEnumerable<GenItem> EthItems =
             new List<GenItem>
                {
                    new GenItem { Value="Caucasian", Text="Caucasian"},
                    new GenItem { Value="Black", Text="Black"},
                    new GenItem { Value="Hispanic", Text="Hispanic"},
                    new GenItem { Value="Indian", Text="Indian"},
                    new GenItem { Value="Middle Eastern", Text="Middle Eastern"},
                    new GenItem { Value="Native American", Text="Native American"},
                    new GenItem { Value="Asian", Text="Asian"},
                    new GenItem { Value="Mixed race", Text="Mixed race"},
                };
        public string Ethnicity { get; set; }

        //Height
        public string Height { get; set; }

        //Hair Color
        public IEnumerable<GenItem> HairItems =
            new List<GenItem>
                {
                    new GenItem { Value="Black", Text="Black"},
                    new GenItem { Value="Blond", Text="Blond"},
                    new GenItem { Value="Brown", Text="Brown"},
                    new GenItem { Value="Red", Text="Red"},
                    new GenItem { Value="Grey", Text="Grey"},
                    new GenItem { Value="Bald", Text="Bald"},
                    new GenItem { Value="Mixed Color", Text="Mixed Color"}
                };
        public string Hair { get; set; }

        //
        //seeking variables

        //
        //Seeking
        public IEnumerable<GenItem> SeekingItems =
            new List<GenItem>
                {
                    new GenItem { Value="Male", Text="Male"},
                    new GenItem { Value="Female", Text="Female"},
                };
        public string Seeking { get; set; }

        //Trans Option
        public bool Toption { get; set; }

        //Trans Yes
        public bool tyes { get; set; }

        //User Biography
        public string Bio { get; set; }

        //
        //location variables
        //
        //Country
        public IEnumerable<GenItem> CounItems =
             new List<GenItem>
                {
                    new GenItem { Value="Canada", Text="Canada"},
                    new GenItem { Value="USA", Text="USA"},
                    new GenItem { Value="UK", Text ="UK"}
                };
        public string Country { get; set; }
        //
        //Province
        public IEnumerable<GenItem> ProvItems =
            new List<GenItem>
                {
                    new GenItem { Value="Alberta", Text="Alberta"},
                    new GenItem { Value="British Columbia", Text="British Columbia"},
                    new GenItem { Value="New Brunswick", Text ="New Brunswick"},
                    new GenItem { Value="Newfoundland", Text ="Newfoundland"},
                    new GenItem { Value="N. W. Territories", Text ="N. W. Territories"},
                    new GenItem { Value="Nova Scotia", Text ="Nova Scotia"},
                    new GenItem { Value="Ontario", Text ="Ontario"},
                    new GenItem { Value="Prince Edward Island", Text ="Prince Edward Island"},
                    new GenItem { Value="Nunavut", Text ="Nunavut"},
                    new GenItem { Value="Saskatchewan", Text ="Saskatchewan"},
                    new GenItem { Value="Yukon Territory", Text ="Yukon Territory"},
                    new GenItem { Value="Quebec", Text ="Quebec"}
                };
        public string Province { get; set; }
        //City
        public string City { get; set; }

        //
        //
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

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
        //new
        public DateTime BirthDate { get; set; }

        //Birth Date vars
        //Month
        public IEnumerable<GenItem> MonthItems =
            new List<GenItem>
                {
                    new GenItem { Value="1", Text="January"},
                    new GenItem { Value="2", Text="February"},
                    new GenItem { Value="3", Text ="March"},
                    new GenItem { Value="4", Text ="April"},
                    new GenItem { Value="5", Text ="May"},
                    new GenItem { Value="6", Text ="June"},
                    new GenItem { Value="7", Text ="July"},
                    new GenItem { Value="8", Text ="August"},
                    new GenItem { Value="9", Text ="September"},
                    new GenItem { Value="10", Text ="October"},
                    new GenItem { Value="11", Text ="November"},
                    new GenItem { Value="12", Text ="December"}
                };

        public int Month { get; set; }

        //Day
        public int Day { get; set; }
        //Year
        public int Year { get; set; }

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
}
