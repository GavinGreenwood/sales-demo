﻿using System.ComponentModel.DataAnnotations;

namespace SalesDemo.DynamicEntityPropertyValues.Dto
{
    public class GetAllDynamicEntityPropertyValuesInput
    {
        [Required]
        public string EntityFullName { get; set; }

        [Required]
        public string EntityId { get; set; }
    }
}
