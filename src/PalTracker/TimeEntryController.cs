using System;
using Microsoft.AspNetCore.Mvc;


namespace PalTracker
{

    public class TimeEntryController
    {
        ITimeEntryRepository TimeEntryRepository;
        public TimeEntryController(ITimeEntryRepository timeEntryRepository  )
        {
            TimeEntryRepository = timeEntryRepository;
        }

        public ActionResult Read(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Create(TimeEntry timeEntry)
        {
            throw new NotImplementedException();
        }
        public ActionResult List( )
        {
            throw new NotImplementedException();
        }
        public ActionResult Update(int id , TimeEntry timeEntry )
        {
            throw new NotImplementedException();
        }


        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }


    }

}