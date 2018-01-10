﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lykke.Service.EthereumCore.Services;
using Nethereum.Web3;
using System.Threading;
using System.Text;
using System;
using Lykke.Service.EthereumCore.Core.Services;
using System.Dynamic;
using System.Collections.Generic;
using Common;
using Swashbuckle.AspNetCore.SwaggerGen;
using Lykke.Common.Api.Contract.Responses;
using System.Net;
using System.Linq;

namespace Lykke.Service.EthereumCore.Controllers
{
    //[Route("api")]
    //[Produces("application/json")]
    //public class SystemController : Controller
    //{
    //    private readonly IHealthService _healthService;

    //    public SystemController(IHealthService healthService)
    //    {
    //        _healthService = healthService;
    //    }

    //    [Route("isalive")]
    //    [HttpGet]
    //    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    //    public async Task<IActionResult> NewClient()
    //    {
    //        var indicators = await _healthService.GetHealthIssues();

    //        IDictionary<string, object> result = new ExpandoObject();

    //        foreach (var item in indicators)
    //        {
    //            result[item.Type] = item.Value;
    //        }

    //        return Ok(result);
    //    }
    //}

    [Route("api/[controller]")]
    public class IsAliveController : Controller
    {
        private readonly IHealthService _healthService;

        public IsAliveController(IHealthService healthService)
        {
            _healthService = healthService;
        }

        /// <summary>
        /// Checks service is alive
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerOperation("IsAlive")]
        [ProducesResponseType(typeof(IsAliveResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var healthViloationMessage = await _healthService.GetHealthViolationMessage();
            if (healthViloationMessage != null)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse
                {
                    ErrorMessage = $"Service is unhealthy: {healthViloationMessage}"
                });
            }

            var healthIssues = await _healthService.GetHealthIssues();

            // NOTE: Feel free to extend IsAliveResponse, to display job-specific indicators
            return Ok(new IsAliveResponse
            {
                Name = Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.ApplicationName,
                Version = Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.ApplicationVersion,
#if DEBUG
                IsDebug = true,
#else
                IsDebug = false,
#endif
                IssueIndicators = healthIssues
                    .Select(i => new IsAliveResponse.IssueIndicator
                    {
                        Type = i.Type,
                        Value = i.Value
                    })
            });
        }
    }
}
