using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsApp_Core.Enums
{
    public enum UserType
    {
        [Display(Name = "Admin")]
        UserType1 = 1,
        [Display(Name = "Manager")]
        UserType2 = 2,
        [Display(Name = "Developer")]
        UserType3 = 3,
        [Display(Name = "Tester")]
        UserType4 = 4,
        [Display(Name = "Editor")]
        UserType5 = 5,
        [Display(Name = "User")]
        UserType6 = 6
    }
}
