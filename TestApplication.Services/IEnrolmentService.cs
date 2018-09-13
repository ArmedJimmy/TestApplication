using System.Collections.Generic;
using TestApplication.Data.Entities;

namespace TestApplication.Services
{
    public interface IEnrolmentService
    {
        void Create(Enrolment enrolment);
        Enrolment GetEnrolment(int id);
        List<Enrolment> GetEnrolments();
    }
}