using System.Collections.Generic;

namespace SC.Core.Common
{
    public class QueryResult
    {
        public bool Succeeded { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
