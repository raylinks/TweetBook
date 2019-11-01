using System;
using System.Collections.Generic;
using ray1.Domain;

namespace ray1.Services
{
    public interface IPostService
    {
        List<Post> GetPosts();
        Post GetPostById(Guid postId);
        bool UpdatePost(Post postToUpdate);
        bool DeletePost(Guid postId);
    }
}
