﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloAPI.Dominio.Entidades
{
    public class Marca
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Modelo> Modelos { get; set; }
    }
}
