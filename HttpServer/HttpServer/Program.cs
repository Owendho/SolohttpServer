using HttpServer;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

HttpRequestParser httpRequestParser = new HttpRequestParser();

httpRequestParser.httpListener();

Datasource.ReadBook();