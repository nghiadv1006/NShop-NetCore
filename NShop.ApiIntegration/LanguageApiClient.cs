﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using NShop.ApiIntegration.Interfaces;
using NShop.Models.Common;
using NShop.Models.Languages;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NShop.ApiIntegration
{
    public class LanguageApiClient : BaseApiClient, ILanguageApiClient
    {
        public LanguageApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            return await GetAsync<ApiResult<List<LanguageVm>>>("/api/languages");
        }
    }
}
