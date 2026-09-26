using System;
using System.Security;
using System.Security.Permissions;
using System.Reflection;
using System.Runtime.Remoting;
public class Sample 
{
   public static void Example()
   {
      AppDomain currentDomain = AppDomain.CurrentDomain;
 //     currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);

      try 
      {
         throw new Exception("First Handled Exception");
      } 
      catch (Exception e) 
      {
         Console.WriteLine("Catch clause caught : " + e.Message);
      }

      try
      {
          throw new Exception("Second Handled Exception");
      }
      catch (Exception e)
      {
          Console.WriteLine("Catch clause caught : " + e.Message);
          // throw;
          // throw new Exception("Re-throw second exception", e);
      }

      throw new Exception("Un-Handled Exception");
   }

   static void MyHandler(object sender, UnhandledExceptionEventArgs args) 
   {
      Exception e = (Exception) args.ExceptionObject;
      Console.WriteLine("Exception Message: {0}", e.Message);
   }

   public static void Main() 
   {
      Example();
   }
}