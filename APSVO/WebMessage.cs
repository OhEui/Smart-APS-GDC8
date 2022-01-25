using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class WebMessage
    {
        public bool IsSuccess { get; set; }
        public string ResultMessage { get; set; }
    }

    public class WebMessage<T> : WebMessage
    {
        public T Data { get; set; }
    }

    public class Message<T>
    {
        public bool IsSuccess { get; set; }
        public string ResultMsg { get; set; }
        public T Data { get; set; }
    }
    public class ModelMessage
    {
        public string Message { get; set; }
        public Dictionary<string, IList<string>> ModelState { get; set; }
    }
}
