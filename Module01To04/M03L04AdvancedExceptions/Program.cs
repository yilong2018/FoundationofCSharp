using System;

namespace M03L04AdvancedExceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      //   string name = "";
      //   try
      //   {
      //     DifferentMethod();
      //     Console.Write("What is your name: ");
      //     name = Console.ReadLine();
      //     ComplexMethod(name);
      //     SimpleMethod();
      //   }
      //   catch (NotImplementedException)
      //   {
      //     Console.WriteLine("You forgot to finish your code!!!");
      //   }
      //   catch (InvalidOperationException ex)
      //   {
      //     Console.WriteLine("You should not be calling these methods. ");
      //     Console.WriteLine(ex.Message);
      //   }
      //   catch (System.Exception ex) when (name.ToLower() == "yi")
      //   {
      //     Console.WriteLine("You used Yi's name, didn't you?");
      //     Console.WriteLine(ex);
      //   }
      //   catch (System.Exception ex)
      //   {
      //     Console.WriteLine(ex);
      //   }
      //   finally
      //   {
      //     Console.WriteLine("I always run");
      //     Console.WriteLine("Close database connection.");
      //     Console.WriteLine("Close IO connection");
      //   }



      //Homework
      // Create a console application that throws an exception in a method that you catch in the main method.

      try
      {
        // MyNullMethod();
        MyFileMethod();
      }
      catch (ArgumentNullException)
      {
        Console.WriteLine("Error, the arguments is null.");
      }
      catch (FieldAccessException ex)
      {
        Console.WriteLine(ex);
      }
      catch (System.Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        Console.WriteLine("Always Do Lines");
      }


      Console.ReadLine();
    }
    private static void MyNullMethod()
    {
      throw new ArgumentNullException();
    }
    private static void MyFileMethod()
    {
      throw new FieldAccessException();
    }
    private static void SimpleMethod()
    {
      throw new InvalidOperationException("You should not be calling the SimpleMethod.");
    }
    private static void DifferentMethod()
    {
      Console.WriteLine("This is the different method working properly.");
      //   throw new NotImplementedException();
    }

    private static void ComplexMethod(string name)
    {
      if (name.ToLower() == "yi")
      {
        throw new InsufficientMemoryException("Yi is too tall for this method.");
      }
      else
      {
        throw new ArgumentException("This person isn't Yi.");
      }
    }
  }
}
