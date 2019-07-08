namespace myblockbuster.Models
{
  class Movie
  {

    public string Title { get; set; }
    public string Plot { get; set; }

    public int ReleaseYear { get; set; }

    public bool Available { get; set; }


    public Movie(string title, string plot, int releaseDate)
    //constructor 
    {
      Title = title;
      Plot = plot;
      ReleaseYear = releaseDate;
      Available = true;
    }
    // Actors
  }



}