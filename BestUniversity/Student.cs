using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BestUniversity.Enums;

namespace BestUniversity
{
    class Student 
    {
        public Names Name { get; set; }
        public Surnames Surname { get; set; }
        public University University { get; set; }
        public Gender Gender { get; set; }
        public byte Mark { get; set; }
    }
}
