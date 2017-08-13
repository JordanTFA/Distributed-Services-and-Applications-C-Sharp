using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful
{
    [ServiceContract]
    class Students
    {
        [OperationContract]
        [WebGet(UriTemplate = "")]
        public Student GetStudent()
        {
            Student student = new Student();
            student.matric = "01010101";
            student.firstName = "Bob Bobson";
            return student;
        }
    }
}
