using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPersonService
    {
        int Id { get; set; }
        string Name { get; set; }
        string surName { get; set; }
        int Age { get; set; }
        string Department { get; set; }
    }
}
