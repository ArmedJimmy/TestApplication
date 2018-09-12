using System;
using System.Collections.Generic;
using System.Text;
using TestApplication.Data.Enums;

namespace TestApplication.Data.Entities
{
    public class Enrolment : BaseEntity
    {
        public Status Status { get; set; }
    }
}
