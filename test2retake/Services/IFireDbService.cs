using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2retake.DTOs;

namespace test2retake.Services
{
    public interface IFireDbService
    {

        ICollection<FirefighterActionResponse> GetActions(int id);
        string assignFireTruck(int id, AssignFireTruckRequest req);
    }
}
