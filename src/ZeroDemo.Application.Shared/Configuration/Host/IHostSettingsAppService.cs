﻿using System.Threading.Tasks;
using Abp.Application.Services;
using ZeroDemo.Configuration.Host.Dto;

namespace ZeroDemo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
