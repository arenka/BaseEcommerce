﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Business.Dtos
{
    public class CommentDto
    {
        public string? Descrpition { get; set; }
        public string? UserId { get; set; }
        public int? ProductId { get; set; }
    }
}
