using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TestApplication.Data.Enums;

namespace TestApplication.Data.Entities
{
    public class Enrolment : BaseEntity
    {
        public Status Status { get; set; }

        public int SupplyAddress_Id { get; set; }

        public PaymentType PaymentType { get; set; }

        public MeterType MeterType { get; set; }

        [ForeignKey("SupplyAddress_Id")]
        public virtual Address SupplyAddress { get; set; }
    }
}
