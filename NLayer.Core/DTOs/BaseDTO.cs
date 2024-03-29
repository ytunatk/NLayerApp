﻿namespace NLayer.Core.DTOs
{
    public abstract class BaseDTO
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
