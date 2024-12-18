﻿using JobStation.Utility;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services.Interfaces
{
    public interface IHttpService
    {
        (RestClient, IRestRequest) Call(string url, Method method, string contentType = ContentTypes.Json, string token = "");
    }
}
