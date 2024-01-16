﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ImageId { get; set; }
        public int Order { get; set; }
        public Product? Product { get; set; }
        public Image? Image { get; set; }

        [NotMapped]
        private static int _order = 0;
        public ProductImage()
        {
            Order = _order;
            _order++;
        }
    }
}