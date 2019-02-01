using System;
using System.Runtime.Serialization;

namespace LabService
{
    [DataContract]
    public class CComment
    {
        [DataMember]
        public CUser Owner { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public String Text { get; set; }
    }
}
