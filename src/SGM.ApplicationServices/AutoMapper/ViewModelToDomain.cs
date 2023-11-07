﻿using AutoMapper;
using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Entities;

namespace SGM.ApplicationServices.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<CLienteViewModel, Cliente>();
        }
    }
}