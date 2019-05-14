using System;

namespace  PalTracker
{
    public class TimeEntry
    {
            int id ;
            int projectId;
            int userId ;
            DateTime date;
             int hours;
           //  static int currid;

            public int Id
            { 
                get { return id; }
                set { id = value; } 
            }
            public int ProjectId
            {
                    get { return projectId; }
                    set { projectId = value; }
            }
            public int UserId
            {
                    get { return userId; }
                    set { userId = value; }
            }
            public DateTime Date
            {
                    get { return date; }
                    set { date = value; }
            }
             public int Hours
             {
                     get { return hours; }
                     set { hours = value; }
             }

            public TimeEntry(int id , int projectId,int userId,DateTime date , int hours)
            {
                    this.id = id;
                    this.projectId = projectId;
                    this.userId = userId ;
                    this.date = date;
                    this.hours = hours;
            }


          public TimeEntry(int projectId,int userId,DateTime date , int hours)
            {
                    //    this.id =  ;
                    this.projectId = projectId;
                    this.userId = userId ;
                    this.date = date;
                    this.hours = hours;
            }

            public String ToString() {
                    return "<TimeEntry id="+id+", projectId="+ProjectId+", userId="+UserId+", date="+Date+", hours="+hours+">";
            }

            override public bool Equals(Object o) {
                    var timeEntry = o as TimeEntry;
                return this.id == timeEntry.id 
                && this.projectId == timeEntry.projectId
                && this.userId == timeEntry.userId
                && this.date == timeEntry.date
                && this.hours == timeEntry.hours;
            }



    }


}
