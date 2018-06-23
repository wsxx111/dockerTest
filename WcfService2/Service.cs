using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService2
{
    public class Service : IService
    {
        public string GetData()
        {                    
            People p1 = new People();
            p1.Age=23;
            p1.Name = "小马";
             return JsonConvert.SerializeObject(p1);
            // return $"You entered:{ value}";
        }

        public string GetString()
        {
            return "哈哈哈";
        }
    }
    [DataContract]
    public class People
    {
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

}