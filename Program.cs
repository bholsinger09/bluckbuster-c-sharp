using System;
using myblockbuster.Models;

namespace myblockbuster
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      #region Create Data
      Store blockBuster = new Store("Blockbuster", "Idaho");
      Movie hobbit = new Movie("The Hobbit", "Hobbit finds ring of power", 1977);
      Movie unexpected = new Movie("Unexpected Journey, The Hobbit", "Hobbit goes on mission", 2012);
      blockBuster.AddMovie(hobbit);
      blockBuster.AddMovie(unexpected);
      #endregion

      bool inStore = true;
      string menu = "available";

      while (inStore)
      {

        //which list of movie to print
        switch (menu)
        {
          case "available":
            blockBuster.PrintAvailableMovies();
            break;

          case "return":
            blockBuster.PrintCheckedOutMovies();
            break;

        }


      }







    }
  }
}
