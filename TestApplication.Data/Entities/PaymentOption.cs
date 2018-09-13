using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestApplication.Data.Entities
{
    public class PaymentOption : BaseEntity
    {
        public string CardType { get; set; }

        public string CardNumber { get; set; }

        public string CardName { get; set; }

        public DateTime ValidUntil { get; set; }

        public int Enrolment_Id { get; set; }

        [ForeignKey("Enrolment_Id")]
        public virtual Enrolment Enrolment { get; set; }
    }
}
