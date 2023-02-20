// using RestAPI;

// List<Users> users = new List<Users>()
//     {
//         new Users(){FName="Ujjwal", LName="Kar", EmailId="ujjwalkar21@gmail.com", PhoneNo="+918388823359", Password="123456"}

//     };

// // foreach (var item in users)
// // {
// //     System.Console.WriteLine(item.FName);
// // }

// users.ForEach(delegate (Users user){
//     string? FName = user.FName;
// });


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
