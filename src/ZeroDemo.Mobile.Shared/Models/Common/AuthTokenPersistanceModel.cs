﻿using System;
using Abp.AutoMapper;
using ZeroDemo.Sessions.Dto;

namespace ZeroDemo.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}