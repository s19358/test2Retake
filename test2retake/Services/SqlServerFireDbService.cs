using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2retake.DTOs;
using test2retake.Exceptions;
using test2retake.Models;

namespace test2retake.Services
{
    public class SqlServerFireDbService : IFireDbService
    {
        private readonly DBContext _dbcontext;

        public SqlServerFireDbService(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }



        public ICollection<FirefighterActionResponse> GetActions(int id)
        {
            var res = _dbcontext.FireFighter.Any(e => e.IdFireFighter == id);
            if (res == false)
            {
                throw new FireManDoesNotExistsException($"Fireman with id ={id} doesnt exists!");
            }

            var res2 = _dbcontext.FireFighter_Action.Where(e => e.IdFireFighter == id).Join(_dbcontext.Action, e => e.IdAction, d => d.IdAction,
                        (e, d) => new FirefighterActionResponse
                        {
                            IdAction = d.IdAction,
                            StartDate = d.StartDate,
                            EndDate = d.EndDate
                        }).ToList();

            res2 = res2.OrderByDescending(e => e.EndDate).ToList();
            return res2;
        }

        public string assignFireTruck(int id, AssignFireTruckRequest req)
        {
            var res = _dbcontext.FireTruck.Any(e => e.IdFireTruck == id);
            if (res == false)
            {
                throw new FireTruckDoesNotExistsException($"FireTruck with id ={id} doesnt exists!");
            }

            if (_dbcontext.Action.Any(e => e.FireTruck_Actions.Any(e => e.IdFireTruck == id) && e.EndDate == null))
            {
                throw new OnGoingActionException("Action is not finished...");
            }


            var newAction = new FireTruck_Action()
            {
                IdFireTruckAction = _dbcontext.FireTruck_Action.Max(e => e.IdFireTruckAction) + 1,
                IdAction = req.idAction,
                IdFireTruck = req.IdFireTruck

            };
                  _dbcontext.FireTruck_Action.Add(newAction);
                  _dbcontext.SaveChanges();
            return "succesfully assigned..";


        }
}
}

