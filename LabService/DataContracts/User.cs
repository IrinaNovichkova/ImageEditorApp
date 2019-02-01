using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace LabService
{
    [DataContract]
    public class CUser
    {
        [DataMember]
        public Bitmap UserPicture { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String Surname { get; set; }
        [DataMember]
        public String Description { get; set; }
    }
}
