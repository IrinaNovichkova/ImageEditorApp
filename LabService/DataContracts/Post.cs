using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;

namespace LabService
{
    [DataContract]
    public class CPost
    {
        [DataMember]
        public CUser Owner { get; set; }
        [DataMember]
        public Bitmap Picture { get; set; }
        [DataMember]
        public List<CUser> Likes { get; set; }
        [DataMember]
        public List<CComment> Comments { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
    }
}
