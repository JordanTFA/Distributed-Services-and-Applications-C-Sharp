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
        public string matric;

        [DataMember(Name = "first_name")]
        public string firstName;

        [DataMember(Name = "last_name")]
        public string lastName;

        [DataMember(Name = "programme")]
        public string programme;
    }
}
