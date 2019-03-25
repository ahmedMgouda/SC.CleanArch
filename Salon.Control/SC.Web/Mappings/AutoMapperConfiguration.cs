﻿using AutoMapper;

namespace SC.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelProfile>();
                x.AddProfile<ViewModelToDomainProfile>();
            });
        }
    }
}