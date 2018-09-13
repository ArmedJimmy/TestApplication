using System;
using System.Collections.Generic;
using System.Linq;
using TestApplication.Data;
using TestApplication.Data.Entities;

namespace TestApplication.Services
{
    public class EnrolmentService : IEnrolmentService
    {
        private readonly DataContext _dataContext;

        public EnrolmentService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Enrolment> GetEnrolments()
        {
            return _dataContext.Enrolments.ToList();
        }

        public Enrolment GetEnrolment(int id)
        {
            return _dataContext.Find<Enrolment>(id);
        }

        public void Create(Enrolment enrolment)
        {
            _dataContext.Add(enrolment);
            _dataContext.SaveChanges();
        }
    }
}
