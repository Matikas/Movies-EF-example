using Movies;


var moviesService = new MoviesService();

AssignGenreToMovie();

void CreateDirector()
{
    Console.WriteLine("Iveskite rezisieriaus varda:");
    var directorFirstName = Console.ReadLine();

    Console.WriteLine("Iveskite pavarde:");
    var directorLastName = Console.ReadLine();

    Console.WriteLine("Gimimo data:");
    var directorBirthDate = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Mirties data:");
    var directorDeathDateStr = Console.ReadLine();
    DateTime? directorDeathDate = string.IsNullOrWhiteSpace(directorDeathDateStr)
        ? null
        : DateTime.Parse(directorDeathDateStr);

    moviesService.CreateDirector(directorFirstName, directorLastName, directorBirthDate, directorDeathDate);
}

void PrintAllDirectorsToConsole()
{
    var directors = moviesService.GetAllDirectors();
    foreach (var director in directors)
    {
        Console.WriteLine($"{director.FirstName} {director.LastName}, date of birth {director.BirthDate.ToString("yyyy-MM-dd")}");
    }
}

void GetDirectorById()
{
    Console.WriteLine("Iveskite rezisieriaus ID kuri norite pamatyti");
    var id = int.Parse(Console.ReadLine());
    var director = moviesService.GetDirectorById(id);
    Console.WriteLine(director.FirstName + " " + director.LastName);
}

void AssignGenreToMovie()
{
    Console.WriteLine("Iveskite filmo ID kuriam norite priskirti zanra");
    var id = int.Parse(Console.ReadLine());
    Console.WriteLine("Iveskite zanra kuri norite priskirti filmui");
    var genre = Console.ReadLine();

    moviesService.AssignGenreToMovie(id, genre);
}