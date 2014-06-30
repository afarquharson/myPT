using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Model
{
    class HistoryItem : IHistoryItem
    {
        public DateTime Date { get; set; }
        public string Summary { get; set; }
        public string SessionId { get; set; }
        public string GUID { get; set; }

        public override bool Equals(object obj)
        {
            var other = (HistoryItem)obj;
            if (other == null)
            {
                return false;
            } 
            else 
            {
                return (this.Date == other.Date) 
                    && String.Equals(this.Summary, other.Summary) 
                    && String.Equals(this.SessionId, other.SessionId) 
                    && String.Equals(this.GUID, other.GUID);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
