// See https://aka.ms/new-console-template for more information
using Entity;
using BzLayer;
// Console.WriteLine("Hello, World!");
MovieBz bz = new MovieBz();
List<Movie> movies = bz.GetMovies();
if(movies != null)
{
    foreach(var m in movies)
    {
        System.Console.WriteLine($"{m.ID} {m.Name} {m.Ratings} {m.RYear}");
    }
}
else
{
    System.Console.WriteLine("No Movies Present");
}