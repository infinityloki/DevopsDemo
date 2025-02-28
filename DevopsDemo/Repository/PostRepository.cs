using DevOpsDemo.Models;
using System.Collections.Generic;
namespace DevOpsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var posts = new List<PostViewModel> {
 new PostViewModel(){ PostId =101, Title = "DevOps Demo Title 1", Description ="DevOps DemoDescription 1", Author="raju"},
 new PostViewModel(){ PostId =102, Title = "DevOps Demo Title 2", Description ="DevOps DemoDescription 2", Author="mukesh"},
 new PostViewModel(){ PostId =103, Title = "DevOps Demo Title 3", Description ="DevOps DemoDescription 3", Author="brother"},
 };
            return posts;
        }
    }
}