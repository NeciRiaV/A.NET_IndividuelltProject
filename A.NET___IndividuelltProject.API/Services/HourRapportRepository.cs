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
    public class HourRapportRepository : Iiproject<HourRapport>
    {
        private AppDbContext _appContext;
        public HourRapportRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }
        //-----------------
        public async Task<IEnumerable<HourRapport>> GetAll()
        {
            return await _appContext.HourRapports.ToListAsync();
        }

        //----------------
        public async Task<HourRapport> Add(HourRapport newEntity)
        {
            var result = await _appContext.HourRapports.AddAsync(newEntity);
            await _appContext.SaveChangesAsync();
            return result.Entity;
        }

        //------------------
        public async Task<HourRapport> Update(HourRapport Entity)
        {
            var result = await _appContext.HourRapports.FirstOrDefaultAsync(p => p.ProjectID == Entity.ProjectID);
            if (result != null)
            {
                result.ProjectID = Entity.ProjectID;
                result.EmployeeID = Entity.EmployeeID;
                result.WeekNumber = Entity.WeekNumber;
                result.Start = Entity.Start;
                result.End = Entity.End;

                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        //-------------------
        public async Task<HourRapport> Delete(int id)
        {
            var result = await _appContext.HourRapports.FirstOrDefaultAsync(p => p.HourRapportID == id);
            if (result != null)
            {
                _appContext.HourRapports.Remove(result);
                await _appContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        //-------------------
        public async Task<HourRapport> GetOne(int id)
        {
            return await _appContext.HourRapports.FirstOrDefaultAsync(hr => hr.HourRapportID == id);
        }



        public Task<IEnumerable<HourRapport>> GetSingelOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection> GetSingel(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetDate(int id, int week)
        {
            var search = await _appContext.HourRapports.Where(hr => hr.EmployeeID == id && hr.WeekNumber == week).CountAsync();
            return search * 8;

            //throw new NotImplementedException();
        }
    }
}
