global using AutoMapper;
global using CMMSAPP.Application.Behaviours;
global using CMMSAPP.Application.Common.Dtos.Breakdown;
global using CMMSAPP.Application.Common.Dtos.Category;
global using CMMSAPP.Application.Common.Dtos.Group;
global using CMMSAPP.Application.Common.Dtos.Visit;
global using CMMSAPP.Application.Features.Breakdowns.Commands.CreateBreakdown;
global using CMMSAPP.Application.Features.Visits.Commands.CreateVisit;
global using CMMSAPP.Common.Exceptions;
global using CMMSAPP.Common.Extensions;
global using CMMSAPP.Common.Utilities;
global using CMMSAPP.Domain.AggregatesModel.AssetCategoryAggregate;
global using CMMSAPP.Domain.AggregatesModel.AssetGroupAggregate;
global using CMMSAPP.Domain.AggregatesModel.BreakdownAggregate;
global using CMMSAPP.Domain.AggregatesModel.VisitAggregate;
global using CMMSAPP.Domain.Enums;
global using CMMSAPP.Domain.Repositories;
global using CMMSAPP.Domain.SeedWork;
global using FluentValidation;
global using MediatR;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using System.Reflection;
global using System.Text.Json.Serialization;
global using CMMSAPP.Application.Common.Dtos.Tool;
global using CMMSAPP.Domain.AggregatesModel.ToolsAggregate;
global using CMMSAPP.Domain.AggregatesModel.ToolTypeAggregate;
global using CMMSAPP.Application.Features.Tools.Commands.UpdateStatusToolType;
//global using CMMSAPP.Application.Features.ToolTypes.Commands.CreateToolType;








