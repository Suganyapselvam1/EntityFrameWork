using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproch
{
    public class CodeFirstRepository
    {
        public List<Department> Departments() 
        {
            CodeFirstDBContext codeFirstDBContext = new CodeFirstDBContext();
            return codeFirstDBContext.Departments.ToList();
        }
    }
}