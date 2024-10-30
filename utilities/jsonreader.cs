using Newtonsoft.Json.Linq;
using System;
//using System.Collections.Generic;
using System.IO;
/*using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace CSharpSeleniumFramework.utilities
{
    public class jsonreader
    {

        public jsonreader()
        {
           
        }

        public void extractData()
        {
         var myJsonString =  File.ReadAllText("utilities.testData.json");
         var jsonObject =   JToken.Parse(myJsonString);
           Console.WriteLine(jsonObject.SelectToken("user").Value<String>());
        }
    }
}
