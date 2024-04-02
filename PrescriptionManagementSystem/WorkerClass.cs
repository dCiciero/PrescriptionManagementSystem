using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrescriptionManagementSystem
{
    public class WorkerClass
    {
        public static string getSourceCode(string siteURL)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(siteURL);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string sourceCode = sr.ReadToEnd();
            sr.Close();
            resp.Close();
            return sourceCode;
        }

        public static void parseSource(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string source = sr.ReadToEnd();
            sr.Close();

            ArrayList arrayList = new ArrayList();
            Regex r = new Regex(@"<a[\s]+[^>]*?href[\s]?=[\s\""\']+(?<href>.*?)[\""\']+.*?>(?<fileName>[^<]+|.*?)?<\/a>");
            MatchCollection matchCollection = r.Matches(source);
            foreach (Match match in matchCollection)
            {
                foreach (Group g in match.Groups)
                {
                    string b = g.Value +"";
                    arrayList.Add(b);
                }
            }

            StreamWriter streamWriter = new StreamWriter("links.txt");
            foreach (string link in arrayList)
                streamWriter.WriteLine(link);
            streamWriter.Close();
        }
    }
}
