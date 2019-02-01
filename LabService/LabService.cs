using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Media.Imaging;

namespace LabService
{
    public partial class LabService : ILabService
    {
        public List<CPost> GetFeed(Guid userId, int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public Guid GetCurrentUser()
        {
            throw new NotImplementedException();
        }

        public CUser GetUserInfo(Guid userId)
        {
            throw new NotImplementedException();
        }

        public List<CPost> GetUserPosts(Guid userId, int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public CPost GetPost(Guid postId)
        {
            throw new NotImplementedException();
        }

        public List<CComment> GetComments(Guid postId, int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public List<CProcessingTemplate> GetTemplates(Guid userId, int startIndex, int length)
        {
            throw new NotImplementedException();
        }
    }
}
