using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_DOTNET6.Models
{
    public interface IEPersonRepository
    {
        ExaminePerson GetExaminePerson(int Id);
        IEnumerable<ExaminePerson> GetAllExaminePeople();
        ExaminePerson Add(ExaminePerson examineperson);
        ExaminePerson Upadte(ExaminePerson epeopleChanges);
        ExaminePerson Delete(int id);
    }
}
