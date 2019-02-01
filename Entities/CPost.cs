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
    public class CPost
    {
        public CPost(CUser owner, Bitmap picture, List<CUser> likes, List<CComment> comments, DateTime date)
        {
            Owner = owner;
            Picture = picture;
            Likes = likes;
            Comments = comments;
            Date = date;
        }
        [DataMember]
        public CUser Owner { get; }
        [DataMember]
        public Bitmap Picture { get; }
        [DataMember]
        public List<CUser> Likes { get; }
        [DataMember]
        public List<CComment> Comments { get; }
        [DataMember]
        public DateTime Date { get; }
    }
}
