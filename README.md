c:\test\FormatterWrongVersionRepro\src>dotnet publish -r linux-x64 -c Release --self-contained

c:\test\FormatterWrongVersionRepro\bin\Release\linux-x64\publish\System.Runtime.Serialization.Formatters.dll
114KB // wrong, it took the one from the runtime instead of the nuget

c:\test\FormatterWrongVersionRepro\bin\Release\System.Runtime.Serialization.Formatters.dll
133KB

As long as I only have App and Ext in the solution, it works. Adding an extra project and it seems to  collapses.

So if you remove/delete ClassLibrary1 project, it suddenly start working and both places get the correct dll of 133KB.