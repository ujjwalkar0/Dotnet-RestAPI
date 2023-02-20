using Microsoft.AspNetCore.Mvc;

// using RestAPI.Models;
namespace RestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController :  ControllerBase
{
    List<Users> users = new List<Users>()
    {
        new Users{FName="Ujjwal", LName="Kar", EmailId="ujjwalkar21@gmail.com", PhoneNo="+918388823359", Password="123456"}

    };

    [HttpGet]
    IEnumerable<Users> Get()
    {
        return users;
    }

    [HttpPost]
    async public void Post(){
        string content = await new StreamReader(Request.Body).ReadToEndAsync();
        System.Console.WriteLine(content);
    }
}
