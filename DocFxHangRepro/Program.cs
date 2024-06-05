// See https://aka.ms/new-console-template for more information

using Docfx.Dotnet;

Console.WriteLine("Hello, World!");

DotnetApiCatalog.GenerateManagedReferenceYamlFiles(Path.Combine(AppContext.BaseDirectory, @"..\..\..\..\docfx\docfx.json")).Wait();
