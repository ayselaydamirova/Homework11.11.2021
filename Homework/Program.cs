using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //var meeting = new Meeting();
            var meetingSchedule = new MeetingSchedule();
            Console.WriteLine("Enter meeting name: ");
            var meetingName = Console.ReadLine();
            Console.WriteLine("Enter date(from): ");
            var dateFrom = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter date(to): ");
            var dateTo = DateTime.Parse(Console.ReadLine());
            meetingSchedule.SetMeeting(meetingName, dateFrom, dateTo);
            Console.WriteLine(meetingSchedule.FindMeetingsCount(new DateTime(2021, 11, 11)));
        }
    }

}

