using System.Collections.Generic;
using System.Linq;

namespace Advantage.API
{
    public class PageinatedResponse<T>
    {
        public PaginatedResponse(IEnumerable<T> data,int i, int len)
        {
            Data = data.Skip((i - 1) * len).Take(len).ToList();
            Total = Data.Count();
        }

        public int Total{get;set;}
        public IEnumerable<T> Data {get;set;}

    }
}