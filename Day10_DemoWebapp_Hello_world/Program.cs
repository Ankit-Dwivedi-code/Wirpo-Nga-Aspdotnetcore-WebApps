var builder = WebApplication.CreateBuilder(args);
// Adding MVC
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");  //minimal API
// Ex1 : Returning a list (hard coded)
// here i am testing end points
app.MapGet("/Mobilephones", () => new List<string> { "iPhone", "Samsung", "OnePlus",  "Xiaomi"});

//Ex2 : Dynamic List(Query parameters)
app.MapGet("/RepeatNames", (string name, int count) => Enumerable.Repeat(name, count).ToList());

//Adding MVC Route
app.MapControllerRoute(
    name: "default" ,
    pattern : "{controller=Home}/{action=Index}/{id?}"
 );

app.Run();


// Setp1: Run this template as it is 
// Step2: Need to add MVC(html Page)
            // We will be adding MVC 
            // Create a controller 
            // Creating a view 
            // Running your App