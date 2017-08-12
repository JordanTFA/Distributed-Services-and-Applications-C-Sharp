using System;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful
{
    [DataContract]
    class Student
    {
        [DataMember(Name = "matric_no")]
        public string Matric;

        [DataMember(Name = "name")]
        public string Name;
    }
}
