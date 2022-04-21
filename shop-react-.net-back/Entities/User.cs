using System;
using Microsoft.AspNetCore.Identity;

namespace shop_react_.net_back.Entities
{
    public class User : IdentityUser     // będziemy używać IdentityUser, aby mieć dostęp do wszystkich propertisów
    {
        // public int Id { get; set; }
        // public string UserName { get; set; }
        // public string FirstName { get; set; }
        // public string LastName { get; set; }
        // public DateTime? DateOfBirth { get; set; } // data urodzenia, moze byc null
        // public string Email { get; set; }
        // public string Password/PasswordHash { get; set; }    // hash hasła
        
        // public int RoleId { get; set; }
        // public virtual Role Role { get; set; }  // RoleId - klucz obcy, Role - referencja do Role
    }
}
