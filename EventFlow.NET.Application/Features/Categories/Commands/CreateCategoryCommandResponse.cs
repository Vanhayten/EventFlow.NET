﻿using EventFlow.NET.Application.Responses;

namespace EventFlow.NET.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse(): base()
        {

        }

        public CreateCategoryDto Category { get; set; } = default!;
    }
}