using System;
using System.Collections.Generic;
using System.Linq;

class LAstKNumbers
{

    static void Main(string[] args)
    {

        string url = Console.ReadLine();

        //string[] temp = input.Split(':');

        int razdelitel = url.IndexOf(':');
        string server = string.Empty;
        string resource = string.Empty;
        string protocol = string.Empty;
        string server_input = url;
        if (razdelitel != -1)
        {
            protocol = url.Substring(0, razdelitel);


        
        int server_int = razdelitel + 3;

          server_input = url.Substring(server_int);

          }
        if (server_input.IndexOf('/') != -1)

        {
            server = server_input.Substring(0, server_input.IndexOf('/'));
        

            int resource_int = server_input.IndexOf('/');

            resource = server_input.Substring(resource_int + 1);
            

        }

        if (server == string.Empty)
        {
            server = server_input;
        }
        char a = '"';
        Console.WriteLine("[protocol] = {0}{1}{0}", a, protocol);
        Console.WriteLine("[server] = {0}{1}{0}", a, server);
        Console.WriteLine("[resource] = {0}{1}{0}", a, resource);



    }
}