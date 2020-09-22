namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "XXXXXXXXXXXXXXXXXXXXX";
            string password = "XXXXXXXXXXXXXXXXXX";

           WebRequest req = WebRequest.Create(@"https://api.xforce.ibmcloud.com:443/resolve/schneider-electric.com");
            req.Method = "GET";
            req.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password));
            HttpWebResponse response = req.GetResponse() as HttpWebResponse;


            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string strResponse = reader.ReadToEnd();

            Console.WriteLine(strResponse);
           
        }
    }
}
