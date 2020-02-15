﻿namespace Panda.Models
{
    using Enums;

    using System;
    using System.ComponentModel.DataAnnotations;

    public class Package
    {
        public Package()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Status = StatusEnums.Pending;
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Description { get; set; }

        public decimal Weight { get; set; }

        public string ShippingAddress { get; set; }

        public StatusEnums Status { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        [Required]
        public string RecipientId { get; set; }

        public virtual User Recipient { get; set; }
    }
}