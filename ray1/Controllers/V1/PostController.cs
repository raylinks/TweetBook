using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ray1.Contracts.V1;
using ray1.Contracts.V1.Requests;
using ray1.Contracts.V1.Responses;
using ray1.Domain;
using ray1.Services;

namespace ray1.Controllers.VI
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PostController : Controller
    {

        private IPostService _postService;


        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpGet("ApiRoutes.Posts.GetAll")]
        //[HttpGet("api/v1/posts")]
        public IActionResult GetAll()
        {
            return Ok(_postService.GetPosts());
        }


        [HttpGet("ApiRoutes.Posts.Get")]
        public IActionResult Get([FromRoute]Guid postId)
        {
            var post = _postService.GetPostById(postId);
            if (post == null)
                return NotFound();
            return Ok(post);
        }

        [HttpPut("ApiRoutes.Posts.Update")]
        public IActionResult Update([FromRoute]Guid postId, [FromBody] UpdatePostRequest request)
        {
            var post = new Post
            {
                Id = postId,
                Name = request.Name

            };
            var updated = _postService.UpdatePost(post);
            if (updated)
                return Ok(post);
            return NotFound();
        }

        // [HttpGet("ApiRoutes.Posts.Create")]
        [HttpPost("api/v1/posts")]
        public IActionResult Create([FromBody] CreatePostRequest postRequest)
        {
            var post = new Post { Id = postRequest.Id };
            if (post.Id != Guid.Empty)
                
            _postService.GetPosts().Add(post);
            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUrl = baseUrl + "/" + ApiRoutes.Posts.Get.Replace("{postId}" , post.Id.ToString());
            var response = new PostResponse { Id = post.Id };
            return Created(locationUrl, response);


        }

        public IActionResult Delete([FromRoute] Guid postId)
        {
            var deleted = _postService.DeletePost(postId);
            if (deleted)
                return NoContent();
            return NotFound();
        }


        
    }
}
