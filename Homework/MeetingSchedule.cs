using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework
{
    class MeetingSchedule
    {
        public List<Meeting> Meetings { get; set; }
        public MeetingSchedule()
        {
            Meetings = new List<Meeting>();
        }

        public void SetMeeting(string fullName, DateTime fromDate, DateTime toDate)
        {
            var meeting = Meetings.FirstOrDefault(x => fromDate >= x.FromDate && toDate <= x.ToDate);
            if (meeting != null)
            {
                throw new Exception();
            }
            else
            {
                var isOk = new Meeting();
                Meetings.Add(isOk);
            }
        }

        public int FindMeetingsCount(DateTime dateTime)
        {
            var meeting = Meetings.Where(x => dateTime > x.ToDate);
            return meeting.Count();
        }

        //public List<Meeting> FindMeetings(Predicate<string> predicate)
        //{
        //    return
        //}

        //public bool ExistMeetings(Predicate<string> predicate)
        //{
        //}

        public bool ExistMeetingsByName(string name)
        {
            var meeting = Meetings.FirstOrDefault(x => x.Name == name);
            if (meeting != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
