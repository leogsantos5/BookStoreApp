﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.API.Data
{
    [Index("ISBN", Name = "UQ__Books__447D36EAF537BD44", IsUnique = true)]
    public partial class Book
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public int? Year { get; set; }
        [StringLength(50)]
        public string ISBN { get; set; }
        [StringLength(250)]
        public string Summary { get; set; }
        [StringLength(50)]
        public string Image { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        public int? AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        [InverseProperty("Books")]
        public virtual Author Author { get; set; }
    }
}