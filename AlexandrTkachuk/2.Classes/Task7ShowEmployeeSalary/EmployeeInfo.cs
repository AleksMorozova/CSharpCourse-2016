using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7ShowEmployeeSalary
{
    struct EmployeeInfo
    {
        Position position;
        int workExperience;

        public int WorkExperience
        {
            get { return workExperience; }
        }
        internal Position Position
        {
            get { return position; }
        }

        public EmployeeInfo(Position position, int workExperience)
        {
            this.position = position;
            this.workExperience = workExperience;       
        }
        
    }
}
