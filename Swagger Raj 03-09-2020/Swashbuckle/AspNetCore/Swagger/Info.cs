﻿using Microsoft.OpenApi.Models;

namespace Swashbuckle.AspNetCore.Swagger
{
    internal class Info : OpenApiInfo
    {
        public string Version { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public object Contact { get; set; }
    }
}