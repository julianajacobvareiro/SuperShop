﻿using System.ComponentModel.DataAnnotations;
using System;

namespace SuperShop.Data.Entities
{
    public class Product : IEntity 
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(50, ErrorMessage ="The field {0} can contain {1} characters lenght.")]
        public string Name { get; set; }



        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }



        [Display(Name = "Image")]
        public string ImageUrl { get; set; }



        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase { get; set; }



        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }



        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }



        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double StockPrice { get; set; }


        public User User { get; set; }


        public string ImageFullPath 
        { 
            get
            {
                if(string.IsNullOrEmpty(ImageUrl))
                {
                    return null;
                }

                return $"https://localhost:44389{ImageUrl.Substring(1)}";
            }
        }
    }
}
