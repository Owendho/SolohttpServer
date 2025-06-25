using HttpServer;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Datasource datasource = new Datasource();
datasource.readAppsettings();

HttpRequestParser httpRequestParser = new HttpRequestParser();

httpRequestParser.httpListener();

//Datasource.ReadBook();