﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FireCodingDesign.Models
{
    public class WorkOrder
    {
        [Key]
        public int WorkOrderId { get; set; }
        public string? WorkOrderName { get; set; }
        public int OrderNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? OrderDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? OrderDoneDate { get; set; }
        public string? Description { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public byte[]? ImageData { get; set; }
        public string? ImageContentType { get; set; }
        [Display(Name = "Thumbnail")]
        public string? ImageDataThumbnail { get; set; }
        public Customer? Customer { get; set; }
        [DisplayName("Orderd by")]
        public int? DepartmentId { get; set; }
        public List<Department>? Departments { get; set; }
        public string? DepartmentName => Departments?.FirstOrDefault(d => d.Id == DepartmentId)?.DepartmentDescription; // ändrat
        public string? CustomerName { get; set; }
        public List<Order>? WorkOrders { get; set; }
    }
}