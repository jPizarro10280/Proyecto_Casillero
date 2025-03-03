﻿using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class DetalleFactura
{
    public int Id { get; set; }

    public int FacturaId { get; set; }

    public string Concepto { get; set; } = null!;

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Factura Factura { get; set; } = null!;
}
