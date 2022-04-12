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
    public class ProjectRepository : Iiproject<Project>
    {
        private AppDbContext _appContext;
        public ProjectRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }
        //-----------------GETALL
        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _appContext.Projects.ToListAsync();
        }
        //-----------------GETSINGEL
        public async Task<ICollection> GetSingel(int id)
        {
            var list = (from p in _appContext.Projects
                        where p.ProjectID == id
                        join emp in _appContext.Employees
                        on p.ProjectID equals emp.ProjectID
                        select new
                        {
                            ProjectID = p.ProjectID,
                            ProjectName = p.ProjectName,
                            ProjectDescription = p.Description,
                            EmployeeID = emp.EmployeeID,
                            FullName = emp.FirstName + " " + emp.LastName
                        }).ToListAsync();
            return await list;
        }

        //----------------ADD
        public async Task<Project> Add(Project newEntity)
        {
            var result = await _appContext.Projects.AddAsync(newEntity);
            await _appContext.SaveChangesAsync();
            return result.Entity;
        }

        //----------------UPDATE
        public async Task<Project> Update(Project Entity)
        {
            var result = await _appContext.Projects.FirstOrDefaultAsync(p => p.ProjectID == Entity.ProjectID);
            if (result != null)
            {
                result.ProjectName = Entity.ProjectName;
                result.Description = Entity.Description;
                result.InitiationDate = Entity.InitiationDate;
                result.FinishDate = Entity.FinishDate;

                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        //----------------DELETE
        public async Task<Project> Delete(int id)
        {
            var result = await _appContext.Projects.FirstOrDefaultAsync(p => p.ProjectID == id);
            if (result != null)
            {
                _appContext.Projects.Remove(result);
                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        //-----------------
        public async Task<Project> GetOne(int id)
        {
            return await _appContext.Projects.FirstOrDefaultAsync(p => p.ProjectID == id);
        }



        public Task<IEnumerable<Project>> GetSingelOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetDate(int id, int week)
        {
            throw new NotImplementedException();
        }
    }
}
