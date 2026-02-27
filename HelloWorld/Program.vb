Imports System
Imports Microsoft.AspNetCore.Builder

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        Dim app = builder.Build()
        app.UseDefaultFiles()
        app.UseStaticFiles()
        app.MapGet("/hello", Function() "Hello, World!!!")
        app.Run()
    End Sub
End Module
