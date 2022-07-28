using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingAppCore.Dtos
{
    public class MeetingUserDto
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoomId { get; set; }
    }
}
