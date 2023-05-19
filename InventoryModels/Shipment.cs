﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class Shipment
    {
        public int Id { get; set; }
        [Display(Name="Shipment Number")]
        public string ShipmentName { get; set; }
        [Display(Name ="Sales Order")]
        public int SalesOrderId { get; set; }
        public DateTimeOffset ShipmentDate { get; set; }
        [Display(Name ="Shipment Type")]
        public int ShipmentTypeId { get; set; }
        [Display(Name ="Warehouse")]
        public int WarehouseId { get; set; }
        public bool IsFullShipment { get; set; } = true;
    }
}
