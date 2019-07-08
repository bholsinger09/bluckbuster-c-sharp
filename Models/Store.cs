using System;
using System.Collections.Generic;

namespace myblockbuster.Models
{
  class Store
  {
    public string Name { get; private set; }
    public string Address { get; private set; }

    private List<Movie> AvailableMovies { get; set; }
    public List<Movie> CheckedOutMovies { get; set; }

    public void AddMovie(Movie movieToAdd)
    {
      AvailableMovies.Add(movieToAdd);
    }
    public void RemoveMovie(Movie movieToRemove)
    {
      AvailableMovies.Remove(movieToRemove);
    }

    public void PrintAvailableMovies()
    {
      int num = 1;
      System.Console.WriteLine("Available Movies: ");
      foreach (var movie in AvailableMovies)
      {
        System.Console.WriteLine($"{num} {movie.Title}");
        num++;
      }
      System.Console.WriteLine("Please Select a number to rent a movie out or type 'return' to see movies to return: ");
    }

    public void PrintCheckedOutMovies()
    {
      int num = 1;
      System.Console.WriteLine("Checked out movies: ");
      foreach (var movie in CheckedOutMovies)
      {
        System.Console.WriteLine($"{num}  {movie.Title}");
        num++;
      }
      System.Console.WriteLine("Please select a number to return or type 'available' to see the movies to rentout: ");

    }




    public Store(string name, string address)
    {
      Name = name;
      Address = address;
      AvailableMovies = new List<Movie>(); // instantiate any list/dictionary inside ctor
    }




    //name 
    //address
    //avaiable movies
    // rented movies

  }


}
