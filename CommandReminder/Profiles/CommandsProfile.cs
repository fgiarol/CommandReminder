﻿using AutoMapper;
using CommandReminder.Dtos;
using CommandReminder.Models;

namespace CommandReminder.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}