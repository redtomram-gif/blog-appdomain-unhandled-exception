# AppDomain UnhandledException handler

Sample showing how to attach an `UnhandledExceptionEventHandler` to a sandboxed `AppDomain` to collect information about unexpected exceptions. `program.cs` throws handled and unhandled exceptions; `excep.cs` creates the AppDomain with an explicit `PermissionSet` and runs it.

Originally published at [AppDomain UnhandledException handler](https://blogs.msdn.microsoft.com/thottams/2008/04/30/unhandled-exception-handler-unhandledexceptioneventhandler-to-collect-more-information-about-unexpected-exceptions/) on the MSDN `thottams` blog.

## Building

<!-- Console -->

    csc program.cs
    csc excep.cs
    excep.exe

## Note

This is archived sample code from a blog post written years ago. It targets the .NET Framework / Visual Studio versions of that era and is kept here for reference.

