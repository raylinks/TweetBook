﻿using System;
using System.Collections.Generic;

namespace ray1.Contracts.V1.Responses
{
    public class AuthFailedResponse
    {
       public IEnumerable<string> Errors { get; set; }
    }
}
