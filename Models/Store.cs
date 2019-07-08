using System;
using System.Collections.Generic;

namespace myblockbuster.Models
{
  class Store
  {
    public string Name { get; private set; }
    public string Address { get; private set; }

    private List<Movie> AvaiableMovies { get; set; }

    public void AddMovie(Movie movieToAdd)
    {
      AvaiableMovies.Add(movieToAdd);
    }
    public void RemoveMovie(Movie movieToRemove)
    {
      AvaiableMovies.Remove(movieToRemove);
    }


    public Store(string name, string address)
    {
      Name = name;
      Address = address;
      AvaiableMovies = new List<Movie>(); // instantiate any list/dictionary inside ctor
    }




    //name 
    //address
    //avaiable movies
    // rented movies

  }


}
