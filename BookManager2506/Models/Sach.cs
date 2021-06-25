﻿namespace BookManager2506.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        public int Id { get; set; }

        [Display(Name = "Tác giả")]
        [Required(ErrorMessage = "Tên tác giả không được trống")]
        [StringLength(30, ErrorMessage = "Tên tác giả sách không được vượt quá 30 ký tự")]
        public string Author { get; set; }

        [Display(Name = "Tựa sách")]
        [Required(ErrorMessage = "Tựa sách không được trống")]
        [StringLength(100, ErrorMessage = "Tựa sách sách không được vượt quá 100 ký tự.")]
        public string Tittle { get; set; }

        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Mô tả không được trống")]
        public string Description { get; set; }

        [Display(Name = "Hình ảnh")]
        [Required(ErrorMessage = "Hình ảnh không được trống")]
        public string ImageCover { get; set; }

        [Display(Name = "Giá bán")]
        [Required(ErrorMessage = "Giá tiền không được trống")]
        [Range(1000, 1000000, ErrorMessage = "Giá sách phải từ {1} đến {2}.")]
        public int Price { get; set; }
    }
}
