using System;

class Program 
  {
  public static void Main (string[] args) 
    {
    Console.WriteLine ("Height: ");
    int height = get_rows();
    switch (height)
    {
      case 1:
      Console.WriteLine ("        #");
      break;
        
      case 2:
      Console.WriteLine ("        #");
      Console.WriteLine ("       ##");
      break;
        
      case 3:
      Console.WriteLine ("        #");
      Console.WriteLine ("       ##");
      break;

      case 4:
      Console.WriteLine ("        #");
      Console.WriteLine ("       ##");
      Console.WriteLine ("      ###");
      Console.WriteLine ("     ####");
      break;

      case 5:
      Console.WriteLine ("        #");
      Console.WriteLine ("       ##");
      Console.WriteLine ("      ###");
      Console.WriteLine ("     ####");
      Console.WriteLine ("    #####");
      break;

      case 6:
      Console.WriteLine ("        #");
      Console.WriteLine ("       ##");
      Console.WriteLine ("      ###");
      Console.WriteLine ("     ####");
      Console.WriteLine ("    #####");
      Console.WriteLine ("   ######");
      break;

      case 7:
      Console.WriteLine ("        #");
      Console.WriteLine ("       ##");
      Console.WriteLine ("      ###");
      Console.WriteLine ("     ####");
      Console.WriteLine ("    #####");
      Console.WriteLine ("   ######");
      Console.WriteLine ("  #######");
      break;

      case 8:
      Console.WriteLine ("        #");
      Console.WriteLine ("       ##");
      Console.WriteLine ("      ###");
      Console.WriteLine ("     ####");
      Console.WriteLine ("    #####");
      Console.WriteLine ("   ######");
      Console.WriteLine ("  #######");
      Console.WriteLine (" ########");
      break;
    }
    Console.WriteLine(height);
  }
  public static int get_rows()
 {
   string rows = Console.ReadLine();
   try 
   {
     int n= Convert.ToInt32(rows);
     return n;
   }
  catch(FormatException)
    {
      Console.WriteLine("Invalid Input");
      int n = get_rows();
      return n;
    }
 }
}