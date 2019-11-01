using System;
using System.Collections.Generic;
using Cosmonaut;
using Cosmonaut.Extensions;
using ray1.Domain;

namespace ray1.Services
{
    public class CosmosPostService : IPostService
    {
        private readonly ICosmosStore<CosmosPostDto> _cosmosStore;
        public CosmosPostService(ICosmosStore<CosmosPostDto> cosmosStore)
        {
            _cosmosStore = cosmosStore;
        }
        public  bool DeletePost(Guid postId)
        {
            throw new NotImplementedException();
        }

        public Post GetPostById(Guid postId)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetPosts()
        {
            //var posts = _cosmosStore.Query().ToListAsync();
            //return posts.select(x => new Post)
        }

        public bool UpdatePost(Post postToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
