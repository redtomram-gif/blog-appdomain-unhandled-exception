using System;
using System.Security;
using System.Security.Permissions;
using System.Reflection;
using System.Runtime.Remoting;
public class Sample 
{
   public static void Example()
   {
        AppDomainSetup ads = new AppDomainSetup();
        ads.ApplicationBase = System.Environment.CurrentDirectory;
        PermissionSet psMain = new PermissionSet(PermissionState.None);
        SecurityPermission sec = new SecurityPermission(PermissionState.Unrestricted);
        ReflectionPermission sec1 = new ReflectionPermission(PermissionState.Unrestricted);
        FileIOPermission sec2 = new FileIOPermission (PermissionState.Unrestricted);
        UIPermission sec3 = new UIPermission (PermissionState.Unrestricted);
        psMain.AddPermission(sec);
        psMain.AddPermission(sec1);
        psMain.AddPermission(sec2);
        psMain.AddPermission(sec3);
        AppDomain md = AppDomain.CreateDomain("A", null, ads, psMain, null);
        md.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
        md.ExecuteAssembly("program.exe");
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