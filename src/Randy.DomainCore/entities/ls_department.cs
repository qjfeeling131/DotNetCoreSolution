﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Randy.Infrastructure.entities
{
    public class ls_department
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }
        public int CompanyId { get; set; }
        public string Code { get; set; }

        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int CreateByUserId { get; set; }
        public int ModifyByUserId { get; set; }
    }
}
