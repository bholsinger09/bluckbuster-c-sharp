namespace myblockbuster.Models
{

  class Dvd : Movie
  {
    public string Madeby { get; set; }
    public Dvd(string title, string plot, int releaseDate) : base(title, plot, releaseDate)
    {
      Madeby = Madeby;
    }
  }
}