﻿global using FluentValidation;
global using FluentValidation.AspNetCore;
global using Microsoft.Extensions.DependencyInjection;
global using MediatR;
global using AutoMapper;
global using ResumeAppApi.Domain.Entities.PortfolioAgg;
global using ResumeAppApi.Domain.Repositories;
global using ResumeAppApi.Application.ContactInfos.Dtos;
global using ResumeAppApi.Domain.Entities.MessageAgg;
global using ResumeAppApi.Application.Messages.Dtos;
global using ResumeAppApi.Application.Skills.Dtos;
global using ResumeAppApi.Application.Skills.Commands.CreateSkill;
global using ResumeAppApi.Application.WorkSamples.Dtos;
global using ResumeAppApi.Domain.Entities.WorkSampleAgg;
global using ServiceHost.FileUploader;