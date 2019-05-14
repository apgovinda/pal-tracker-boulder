using System;
using System.Collections.Generic;


namespace PalTracker
{

    public class InMemoryTimeEntryRepository : ITimeEntryRepository
    {
        private Dictionary<int, TimeEntry> timeEntries = new Dictionary<int, TimeEntry>();
        private int currentId = 1;
        public TimeEntry Create( TimeEntry timeEntry) 
        {
            var _timeentry = new TimeEntry(currentId,timeEntry.ProjectId, timeEntry.UserId, timeEntry.Date, timeEntry.Hours);
            currentId++;
            timeEntries.Add(_timeentry.Id, _timeentry);
            return _timeentry;
        }

        public TimeEntry Find(int id)
        {
            return timeEntries[id];
        }

        public bool Contains(int id)
        {
            try {
                return timeEntries[id] != null;
            } catch(System.Collections.Generic.KeyNotFoundException e) {
                return false;
            }
            
        }
        public List<TimeEntry> List()
        {
            List<TimeEntry> list = new List<TimeEntry>();
            list.AddRange(timeEntries.Values);
            return list;

        }
        public TimeEntry  Update(int id , TimeEntry timeEntry)
        {
            if ( this.Contains(id) )
            {
                 var _timeEntry =   timeEntries[id];
                 _timeEntry.ProjectId = timeEntry.ProjectId;
                 _timeEntry.UserId     = timeEntry.UserId;
                 _timeEntry.Date  = timeEntry.Date;
                 _timeEntry.Hours = timeEntry.Hours;
                return _timeEntry;
            }
            return timeEntry;
        }

        public void  Delete(int id )
        {
            if ( this.Contains(id) )
            {
                    timeEntries.Remove(id);
            }
        }
    }    

}