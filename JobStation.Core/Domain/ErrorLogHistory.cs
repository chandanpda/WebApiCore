using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStation.Core.Domain
{
    public class ErrorLogHistory
    {
        public int Id { get; set; }
        public string ErrorDetails { get; set; }
        public DateTimeOffset ErrorDate { get; set; }
        public bool? IsFixed { get; set; }
        public DateTimeOffset? FixedDate { get; set; }
    }
}
