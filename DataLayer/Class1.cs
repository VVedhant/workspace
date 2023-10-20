using Entity;
namespace DataLayer;
public class DataAccess
{
    public static List<Movie> movies = new List<Movie>(){
        new Movie {ID=1, Name="Toofan", RYear = 2021, Ratings =3},
        new Movie {ID=2, Name="Ludo", RYear = 2020, Ratings =4},
        new Movie {ID=3, Name="Gunjan", RYear = 2020, Ratings =1},
        new Movie {ID=4, Name="Big Bull", RYear = 2021, Ratings =3},
        new Movie {ID=5, Name="Laxmi", RYear = 2020, Ratings =2}
    };
    public List<Movie> GetMovies()
    {
        return movies;
    }
}