using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
     class JSONSerialization
    {
        

        public void JsonSerialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "sam",
                Description = "welcome to universe"
            };
        string jsonData = JsonConvert.SerializeObject(bsObj);
        Console.WriteLine(jsonData);
        }
    }
[DataContract]
class BlogSites
{
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string Description { get; set; }
}



    class JSONDeSerialization
    {


        public void JsonDeSerialize()
        {
            string json = @"{
                  Name:'Sam',
                 Description:'welcome to universe'

             }";
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj.Name);
        }
    }
    
    
}
