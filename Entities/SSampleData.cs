using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Lab
{
    public static class SSampleData
    {
        private static Bitmap s_image = new Bitmap(new Uri(@"\Resorces\SampleImage.png", UriKind.Relative).AbsolutePath); 
        public static CPost[] GetSamplePosts()
        {
            return new[]
            {
                new CPost(GetSampleUser(), s_image, GetSampleUsers().ToList(), GetSampleComments().ToList(), DateTime.Now),
                new CPost(GetSampleUser(), s_image, GetSampleUsers().ToList(), GetSampleComments().ToList(), DateTime.Now),
                new CPost(GetSampleUser(), s_image, GetSampleUsers().ToList(), GetSampleComments().ToList(), DateTime.Now)
            };
        }

        public static CComment[] GetSampleComments()
        {
            return new[]
            {
                new CComment(GetSampleUser(), "Comment1", DateTime.Now), 
                new CComment(GetSampleUser(), "Comment2", DateTime.Now), 
                new CComment(GetSampleUser(), "Comment3", DateTime.Now), 
            };
        }

        public static CUser[] GetSampleUsers()
        {
            return new[]
            {
                new CUser(s_image, "FirstName1", "LastName1", "Description1"),
                new CUser(s_image, "FirstName2", "LastName2", "Description2"),
                new CUser(s_image, "FirstName3", "LastName3", "Description3")
            };
        }

        public static CUser GetSampleUser()
        {
            return new CUser(s_image, "FirstName", "LastName", "Description");
        }
    }
}
