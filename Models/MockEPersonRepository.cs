using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_DOTNET6.Models
{
    public class MockEPersonRepository : IEPersonRepository
    {

        private List<ExaminePerson> _examinePeopleList;

        public MockEPersonRepository()
        {
            _examinePeopleList = new List<ExaminePerson>()
            {
                new ExaminePerson { Id=5, Name = "Arun", ContactDetails="32654.1254.2645", Feedback="N/A", Oraganization="Hello World" }
            };
        }

        public ExaminePerson Add(ExaminePerson examineperson)
        {
            examineperson.Id = _examinePeopleList.Max(e => e.Id) + 1;
            _examinePeopleList.Add(examineperson);
            return examineperson;
        }

        public ExaminePerson Delete(int id)
        {
            ExaminePerson examinePerson =_examinePeopleList.FirstOrDefault(e => e.Id ==id);
            if (examinePerson!=null)
            {
                _examinePeopleList.Remove(examinePerson);
            }
            return examinePerson;
        }

        public IEnumerable<ExaminePerson> GetAllExaminePeople()
        {
            return _examinePeopleList;
        }

        public ExaminePerson GetExaminePerson(int Id)
        {
            return _examinePeopleList.FirstOrDefault(e => e.Id==Id);
        }

        public ExaminePerson Upadte(ExaminePerson epeopleChanges)
        {
            ExaminePerson examinePerson = _examinePeopleList.FirstOrDefault(e => e.Id == epeopleChanges.Id);
            if (examinePerson != null)
            {
                examinePerson.Name = epeopleChanges.Name;
                examinePerson.Oraganization = epeopleChanges.Oraganization;
                examinePerson.ContactDetails = epeopleChanges.ContactDetails;
                examinePerson.Feedback = epeopleChanges.Feedback;
            }
            return examinePerson;
        }
    }
}
