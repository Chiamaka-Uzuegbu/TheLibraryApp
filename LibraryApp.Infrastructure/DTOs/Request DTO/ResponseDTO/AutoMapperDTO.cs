using AutoMapper;
using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Infrastructure.DTOs.Request_DTO.ResponseDTO
{
    public class AutoMapperDTO: Profile
    {
        public AutoMapperDTO()
        {
            CreateMap<BookDetails, BookDTO>().ReverseMap();
        }
    }
}
