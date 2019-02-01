using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Lab
{
    [DataContract]
    public class CUser
    {
        public CUser(Bitmap userPicture, string name, string surname, string description)
        {
            UserPicture = userPicture;
            Name = name;
            Surname = surname;
            Description = description;
        }

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
