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
      Dvd hobbit = new Dvd("The Hobbit", "Hobbit finds ring of power", 1977);
      Dvd unexpected = new Dvd("Unexpected Journey, The Hobbit", "Hobbit goes on mission", 2012);
      blockBuster.AddDvd(hobbit);
      blockBuster.AddDvd(unexpected);
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

        string selection = Console.ReadLine().ToLower();

        // determine if need to change active menu

        if (selection == "return")
        {
          Console.Clear();
          menu = "return";
          continue;
        }
        if (selection == "available")
        {
          Console.Clear();
          menu = "available";
          continue;
        }


        // This switch handles either returning or renting movie

        switch (menu)
        {
          case "available":
            blockBuster.CheckedOutMovies
        }


      }







    }
  }
}
