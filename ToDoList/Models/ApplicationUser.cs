using System.Security.Claims;
using Microsoft.AspNetCore.Identity;


namespace ToDoList.Models;

public class ApplicationUser:IdentityUser
{
    public async Task GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
    {
       
    }
}