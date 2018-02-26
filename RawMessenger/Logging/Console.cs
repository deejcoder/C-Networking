using System.IO;
using System;
using System.Globalization;
using RawMessenger;

namespace RawMessenger.Logging
{
    class Console
    {
        const string LOG_PATH = "./logs/";
        private MessengerWindow window;
        public Console(MessengerWindow app)
        {
            window = app;
        }

        public void ServerLog(string msg)
        {

            string path = LOG_PATH + "server.log";
            //add date&time at front of msg
            msg = GetDateTime() + " " + msg + "\n";

            //create the file if it doesn't exist then append the msg
            if(!File.Exists(path))
            {
                File.WriteAllText(path, msg);

            }
            else
            {
                //the using block automatically flushes & closes the file
                using (StreamWriter file =
                    new StreamWriter(path, true))
                {
                    file.WriteLine(msg);
                }
            }
            window.AppendToMessages(msg);
            return;
        }

        public void MessageLog(string who, string msg)
        {
            string path = LOG_PATH + who + ".log";
            msg = GetDateTime() + " " + msg + "\n";

            if(!File.Exists(path))
            {
                File.WriteAllText(path, msg);
            }
            else
            {
                using (StreamWriter file =
                    new StreamWriter(path, true))
                {
                    file.WriteLine(msg);
                }
            }
            window.AppendToMessages(msg);
            return;
        }


        //Gets the time and formats in the format, Tuesday, April 10, 2001 3:51 PM
        public static string GetDateTime()
        {
            DateTime dt = DateTime.Now;
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            CultureInfo ci = new CultureInfo("en-US");

            return dt.ToString("u");
        }
    }
}
