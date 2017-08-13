using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful
{
    [CollectionDataContract(Name = "students", Namespace = "httpL//www.napier.ac.uk")]
    class StudentList: List<Student>
    {
    }
}
