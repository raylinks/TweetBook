﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ray1.Contracts.V1;
using ray1.Contracts.V1.Requests;
using ray1.Contracts.V1.Responses;
using ray1.Services;

namespace ray1.Controllers.V1
{
    public class IdentityController : Controller
    {
        private readonly IIdentityService _identityService;

        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost(ApiRoutes.Identity.Register)]
        public async Task<IActionResult>Register([FromBody] UserRegistrationRequest request)
        {
            var authResponse = await _identityService.RegisterAsync(request.Email, request.Password);

            if(!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }
            return Ok(new AuthSuccessResponse
            {
                Token =authResponse.Token
            });
        }

    }
}
