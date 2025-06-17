global using MediatR;
global using Serilog;
global using AutoMapper;
global using Microsoft.AspNetCore.Mvc;
global using CMMSAPP.API.Configuration;
global using CMMSAPP.Application.Extentions;
global using CMMSAPP.Application.Common.Dtos.Breakdown;
global using CMMSAPP.Application.Common.Dtos.Category;
global using CMMSAPP.Application.Common.Dtos.Group;
global using CMMSAPP.Application.Common.Dtos.Tool;
global using CMMSAPP.Application.Common.Dtos.Visit;
global using CMMSAPP.Application.Features.Breakdowns.Commands.CreateBreakdown;
global using CMMSAPP.Application.Features.Categories.Commands.CreateCategory;
global using CMMSAPP.Application.Features.Categories.Commands.DeleteBreakdown;
global using CMMSAPP.Application.Features.Categories.Commands.DeleteCategory;
global using CMMSAPP.Application.Features.Categories.Commands.DeleteVisit;
global using CMMSAPP.Application.Features.Categories.Commands.UpdateBreakdown;
global using CMMSAPP.Application.Features.Categories.Commands.UpdateCategory;
global using CMMSAPP.Application.Features.Categories.Commands.UpdateStatus;
global using CMMSAPP.Application.Features.Categories.Commands.UpdateVisit;
global using CMMSAPP.Application.Features.Categories.Queries.GetAllBreakdownQuery;
global using CMMSAPP.Application.Features.Categories.Queries.GetAllCategoryQuery;
global using CMMSAPP.Application.Features.Categories.Queries.GetAllVisitQuery;
global using CMMSAPP.Application.Features.Categories.Queries.GetBreakdownByIdQuery;
global using CMMSAPP.Application.Features.Categories.Queries.GetCategoryByIdQuery;
global using CMMSAPP.Application.Features.Categories.Queries.GetVisitByIdQuery;
global using CMMSAPP.Application.Features.Groups.Commands.CreateGroup;
global using CMMSAPP.Application.Features.Groups.Commands.DeleteGroup;
global using CMMSAPP.Application.Features.Groups.Commands.UpdateGroup;
global using CMMSAPP.Application.Features.Groups.Queries.GetAllGroupQuery;
global using CMMSAPP.Application.Features.Groups.Queries.GetGroupByIdQuery;
global using CMMSAPP.Application.Features.Tools.Commands.CreateTool;
global using CMMSAPP.Application.Features.Tools.Commands.DeleteTool;
global using CMMSAPP.Application.Features.Tools.Commands.UpdateStatusTool;
global using CMMSAPP.Application.Features.Tools.Commands.UpdateStatusToolType;
global using CMMSAPP.Application.Features.Tools.Commands.UpdateTool;
global using CMMSAPP.Application.Features.Tools.Commands.UpdateToolType;
global using CMMSAPP.Application.Features.Tools.Queries.GetAllToolQuery;
global using CMMSAPP.Application.Features.Tools.Queries.GetToolByIdQuery;
global using CMMSAPP.Application.Features.ToolTypes.Commands.CreateToolType;
global using CMMSAPP.Application.Features.ToolTypes.Commands.DeleteToolType;
global using CMMSAPP.Application.Features.ToolTypes.Queries.GetAllToolTypeQuery;
global using CMMSAPP.Application.Features.ToolTypes.Queries.GetToolTypeByIdQuery;
global using CMMSAPP.Application.Features.Visits.Commands.CreateVisit;
global using CMMSAPP.Common.Api;
global using CMMSAPP.Infrastructure.Configuration;
global using CMMSAPP.Infrastructure.Extensions;





