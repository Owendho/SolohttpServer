using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace HttpServer
{
    class HttpRequestParser
    {
        //Need to find a way to listen for http requests


        //Receive http request from browser
        //Setup server
        //Need an ip address that the browser can use to send requests. could be localhost

        //Ip address method

        //Http parser method

        //i need to create functionality that listens for http requests
        //Need to open a port

        //Use Httpclient if httplistener does not work well.

        public void httpListener()
        {
            
            string[] prefixes = { "http://localhost:80/" }; //Change to url later

            if (prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");

            //Create listener
            HttpListener httpListener = new HttpListener();

            foreach (string prefix in prefixes)
            {
                httpListener.Prefixes.Add(prefix);
            }
            //Have to run program as admin or i get access denied error. use the links below to fix this issue
            //https://learn.microsoft.com/en-us/dotnet/framework/wcf/feature-details/configuring-http-and-https?redirectedfrom=MSDN

            httpListener.Start();
            Console.WriteLine("Listening...");

            HttpListenerContext context = httpListener.GetContext();
            HttpListenerRequest request = context.Request;

            // Obtain a response object.
            HttpListenerResponse response = context.Response;
            //Construct response
            string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);

            // You must close the output stream.
            output.Close();
            httpListener.Stop();

        }

    }


    

}
