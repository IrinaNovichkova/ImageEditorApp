using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace LabService
{
    [DataContract]
    public class CProcessingTemplate
    {
        [DataMember]
        public Bitmap Example { get; set; }

        [DataMember]
        public Guid Id { get; set; }
    }
}
