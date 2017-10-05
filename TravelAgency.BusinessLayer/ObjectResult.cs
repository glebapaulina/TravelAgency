using System.Net;

namespace TravelAgency.BusinessLayer
{
    public class ObjectResult<T>
    {
        public T Result { get; set; }
        public bool Success { get; set; }

        public ObjectResult()
        {
        }
        public ObjectResult(T result)
        {
            this.Result = result;
            this.Success = true;
        }
    }
}