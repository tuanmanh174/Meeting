using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingAppCore.Dtos
{
    public class InsertRoomDto
    {
        public string RoomName { get; set; }
        public int CountMember { get; set; }
        public DateTime? TimeMeeting { get; set; }
        public int? TimeRange { get; set; }
        public int? MeetingPlaceId { get; set; }
        public string MeetingNote { get; set; }
        public string MeetingFile { get; set; }
        public List<MeetingUserDto> MeetingUser { get; set; }

       
    }
}
