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

        //Use Httpclient if httplistener does not work well.

        //Seemingly need to create a httplistener object for every single prefix that i have.

        public void httpHomePageListener()
        {
            string[] prefixes = { "http://localhost:80/homePage" };
            string responseBody = "<HTML><BODY> HomePage</BODY></HTML>"; //responseBody should be data from data source. Let separate frontend handle the visual presentation

            setupListener(prefixes, responseBody);

        }

        public void httpListener()
        {
            string responseBody = "<HTML><BODY> Hello world!</BODY></HTML>";

            string[] prefixes = { "http://localhost:80/" }; //Change to url later

            setupListener(prefixes, responseBody);
        }


        public void setupListener(string[] prefixes, string responseBody)
        {
            if (prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");

            HttpListener httpListener = new HttpListener();

            foreach (string prefix in prefixes)
            {
                httpListener.Prefixes.Add(prefix);
            }

            httpListener.Start();
            Console.WriteLine("Listening...");

            while (httpListener.IsListening)
            {
                HttpListenerContext context = httpListener.GetContext();
                HttpListenerRequest request = context.Request;

                // Obtain a response object.
                HttpListenerResponse response = context.Response;
                //Construct response
                string responseString = responseBody;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();

                //TODO: break out of loop

            }
            httpListener.Stop();
        }

    }


    

}
