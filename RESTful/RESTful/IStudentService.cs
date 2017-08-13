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
    interface IStudentService
    {
        [OperationContract]
        [WebGet(UriTemplate = "")]
        StudentList GetStudents();

        [OperationContract]
        [WebGet(UriTemplate = "/{matric}")]
        Student GetStudent(string matric);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "")]
        Student PostStudent(Student student);
    
    }
}
