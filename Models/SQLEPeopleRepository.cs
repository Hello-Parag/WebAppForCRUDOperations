using CRUD_DOTNET6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_DOTNET6.Models
{
    public class SQLEPeopleRepository : IEPersonRepository
    {

        private readonly CRUD_DOTNET6Context context;

        public SQLEPeopleRepository(CRUD_DOTNET6Context context)
        {
            this.context = context;
        }

        public ExaminePerson Add(ExaminePerson examineperson)
        {
            context.ExaminePerson.Add(examineperson);
            context.SaveChanges();
            return examineperson;
        }

        public ExaminePerson Delete(int id)
        {
            ExaminePerson examinePerson = context.ExaminePerson.Find(id);
            if(examinePerson!=null)
            {
                context.ExaminePerson.Remove(examinePerson);
                context.SaveChanges();
            }
            return examinePerson;
        }

        public IEnumerable<ExaminePerson> GetAllExaminePeople()
        {
            return context.ExaminePerson;
        }

        public ExaminePerson GetExaminePerson(int Id)
        {
            return context.ExaminePerson.Find(Id);
        }

        public ExaminePerson Upadte(ExaminePerson epeopleChanges)
        {
            var epeople=context.ExaminePerson.Attach(epeopleChanges);
            epeople.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return epeopleChanges;
        }
    }
}
