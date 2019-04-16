using DBFirstDevelopment.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBFirstDevelopment.Services
{
    public interface IStudentItemService
    {
        /// <summary>
        /// Get all 
        /// </summary>
        /// <returns></returns>
        Task<Student[]> getAllAsync();

        /// <summary>
        /// Get one by his Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Student> getByIdAsync(Guid Id);


        /// <summary>
        /// Delete a student
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<bool> delByIdAsync(Guid Id);


    }
}
