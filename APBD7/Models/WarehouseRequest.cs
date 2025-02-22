﻿using System.ComponentModel.DataAnnotations;

namespace APBD7.Models;

public class WarehouseRequest
{
    [Required]
    public int IdProduct { get; set; }
    [Required]
    public int IdWarehouse { get; set; }
    [Required]
    public int Amount { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    
}