using A.NET___IndividuelltProject.API.Model;
using A.NET___IndividuelltProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.NET___IndividuelltProject.API.Services
{
    public class EmployeeRepository : Iiproject<Employee>
    {
        private AppDbContext _appContext;
        public EmployeeRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        //------------------ GETALL
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _appContext.Employees.ToListAsync();
        }

        //----------------- GETSINGEL
        public async Task<ICollection> GetSingel(int id)
        {
            throw new NotImplementedException();
        }

        //-----------------ADD
        public async Task<Employee> Add(Employee newEntity)
        {
            var result = await _appContext.Employees.AddAsync(newEntity);
            await _appContext.SaveChangesAsync();
            return result.Entity;
            //throw new NotImplementedException();
        }

        //-----------------UPDATE
        public async Task<Employee> Update(Employee Entity)
        {
            var result = await _appContext.Employees.FirstOrDefaultAsync(emp => emp.EmployeeID == Entity.EmployeeID);
            if (result != null)
            {
                result.FirstName = Entity.FirstName;
                result.LastName = Entity.LastName;
                result.Birth = Entity.Birth;
                result.PhoneNumber = Entity.PhoneNumber;
                result.Email = Entity.Email;
                result.Adress = Entity.Adress;
                result.ProjectID = Entity.ProjectID;

                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
            //throw new NotImplementedException();
        }

        //-----------------DELETE
        public async Task<Employee> Delete(int id)
        {
            var result = await _appContext.Employees.FirstOrDefaultAsync(emp => emp.EmployeeID == id);
            if (result != null)
            {
                _appContext.Remove(result);
                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;

            //throw new NotImplementedException();
        }

        //-----------------GETSINGELEMP-----employee with hour rapport
        public async Task<IEnumerable<Employee>> GetSingelOne(int id)
        {
            IQueryable<Employee> quer = _appContext.Employees.Include(hr => hr.HourRapports);
            if (!quer.Equals(id))
            {
                quer = quer.Where(emp => emp.EmployeeID == id);
            }
            return quer.ToList();
        }

        //-----Singel use for the other 
        public async Task<Employee> GetOne(int id)
        {
            return await _appContext.Employees.FirstOrDefaultAsync(emp => emp.EmployeeID == id);
        }

        public Task<int> GetDate(int id, int week)
        {
            throw new NotImplementedException();
        }
    }
}
