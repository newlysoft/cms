﻿using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using SSCMS.Configuration;
using SSCMS.Services;

namespace SSCMS.Web.Controllers.Stl
{
    [OpenApiIgnore]
    [Route(Constants.ApiPrefix + Constants.ApiStlPrefix)]
    public partial class ActionsIfController : ControllerBase
    {
        private readonly ISettingsManager _settingsManager;
        private readonly IAuthManager _authManager;
        private readonly IParseManager _parseManager;

        public ActionsIfController(ISettingsManager settingsManager, IAuthManager authManager, IParseManager parseManager)
        {
            _settingsManager = settingsManager;
            _authManager = authManager;
            _parseManager = parseManager;
        }

        public class GetRequest
        {
            public string Value { get; set; }
            public int Page { get; set; }
        }

        public class GetResult
        {
            public bool Value { get; set; }
            public string Html { get; set; }
        }
    }
}
