﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Remito:DocumentoComercial
    {
        public DateTime FechaEntrega { get; set; }

        public Remito(DateTime fechaentrega, string numero, DateTime fecha, string cliente, string direccion, string condicioniva, string condicionventa, string detalle, decimal total)
            :base(numero,fecha, cliente, direccion, condicioniva, condicionventa, detalle, total)
        {
            FechaEntrega = fechaentrega;
        }
    }
}
