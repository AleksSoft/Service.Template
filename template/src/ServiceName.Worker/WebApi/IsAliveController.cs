﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ServiceName.Worker.WebApi.Models.IsAlive;
using Swisschain.Sdk.Server.Common;

namespace ServiceName.Worker.WebApi
{
    [ApiController]
    [Route("api/isalive")]
    public class IsAliveController : ControllerBase
    {
        [HttpGet]
        public IsAliveResponse Get()
        {
            var response = new IsAliveResponse
            {
                Name = ApplicationInformation.AppName,
                Version = ApplicationInformation.AppVersion,
                StartedAt = ApplicationInformation.StartedAt,
                Env = ApplicationEnvironment.Environment,
                HostName = ApplicationEnvironment.HostName,
                StateIndicators = new List<IsAliveResponse.StateIndicator>()
            };

            return response;
        }
    }
}
