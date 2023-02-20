using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ForecastController : ControllerBase
{
    // public List<dynamic> users = new List<dynamic>()
    // {
    //     new {FName="Ujjwal", LName="Kar", EmailId="ujjwalkar21@gmail.com", PhoneNo="+918388823359", Password="123456"}

    // };


    // [HttpGet]
    // public IEnumerable<dynamic> Get()
    // {
    //     return users;
    // }

    // {
    //     new Users(){FName="Ujjwal", LName="Kar", EmailId="ujjwalkar21@gmail.com", PhoneNo="+918388823359", Password="123456"}

    // };
    List<Users> users = new List<Users>();

    public ForecastController()
    {

        Users user1 = new Users();
        user1.FName = "Ujjwal";
        user1.LName = "Kar";
        user1.EmailId = "ujjwalkar21@gmail.com";
        user1.PhoneNo = "+918388823359";
        user1.Password = "123456";

        users.Add(user1);
    }

    [HttpGet]
    public IEnumerable<dynamic> Get()
    {
        return users;
    }


    [HttpPost]
    async public void Post()
    {
        string content = await new StreamReader(Request.Body).ReadToEndAsync();
        System.Console.WriteLine(content);
    }

    [HttpPut]
    async public void Put()
    {
        string content = await new StreamReader(Request.Body).ReadToEndAsync();
        System.Console.WriteLine(content);
    }

    [HttpDelete]
    async public void Delete()
    {
        string content = await new StreamReader(Request.Body).ReadToEndAsync();
        System.Console.WriteLine(content);
    }

}
