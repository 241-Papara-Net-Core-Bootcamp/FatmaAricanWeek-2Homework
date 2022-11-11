using System;

namespace Week2.Models
{
    public class ExceptionMessage
    {
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public string RequestId { get; set; }
        public DateTime Date { get; set; }
    }
}
