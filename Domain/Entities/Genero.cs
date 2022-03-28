﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
  public  class Genero
    {
        [Key]
        public Guid IdGenero { get; set; }
        public string Descricao { get; set; }
    }
}
