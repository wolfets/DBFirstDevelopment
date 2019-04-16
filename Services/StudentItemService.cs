using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBFirstDevelopment.Models.DB;

namespace DBFirstDevelopment.Services
{
    public class StudentItemService : IStudentItemService
    {
        private List<Student> _liste = null;
        public List<Student> Liste
        {
            get
            {
                if (_liste == null)
                {
                    Liste = new List<Student>
                    {
                        new Student{Id = Guid.NewGuid(), LastName = "nom1"},
                        new Student{Id = Guid.NewGuid(), LastName = "nom2"},
                        new Student{Id = Guid.NewGuid(), LastName = "nom3"}
                    };
                }
                return _liste;
            }
            set
            {
                _liste = value;
            }
        }

        Task<bool> IStudentItemService.delByIdAsync(Guid Id)
        {
            try
            {
                Student item = Liste.Where(s => s.Id == Id).SingleOrDefault();
                if(item!= null)
                    Liste.Remove(item);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        Task<Student[]> IStudentItemService.getAllAsync()
        {
            try
            {
                return Task.FromResult(Liste.ToArray());
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        Task<Student> IStudentItemService.getByIdAsync(Guid id)
        {
            try
            {
                return Task.FromResult(Liste.Where(s=>s.Id == id).SingleOrDefault());
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }
    }
}
