using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Media.Imaging;

namespace LabService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILabService" in both code and config file together.
    [ServiceContract]
    public interface ILabService
    {
        [OperationContract]
        List<CPost> GetFeed(Guid userId, int startIndex, int length);

        [OperationContract]
        Guid GetCurrentUser();

        [OperationContract]
        CUser GetUserInfo(Guid userId);

        [OperationContract]
        List<CPost> GetUserPosts(Guid userId, int startIndex, int length);

        [OperationContract]
        CPost GetPost(Guid postId);

        [OperationContract]
        List<CComment> GetComments(Guid postId, int startIndex, int length);

        [OperationContract]
        List<CProcessingTemplate> GetTemplates(Guid userId, int startIndex, int length);
    }  
}
