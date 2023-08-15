﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace API.Models
{
    [Table("users")]
    public class Users
    {
        [Key, Column("user_code", TypeName = "char(5)")]
        public string user_code { get; set; }
        [Column("password", TypeName = "varchar(50)")]
        public string password { get; set; }
        [Column("name", TypeName = "varchar(50)")]
        public string name { get; set; }
        [Column("position", TypeName = "varchar(50)")]
        public string position { get; set; }
        [Column("gender", TypeName = "char(1)")]
        public string gender { get; set; }
   
        [Column("address", TypeName = "varchar(255)")]
        public string address { get; set; }
        [Column("phone_number", TypeName = "varchar(50)")]
        public string phone_number { get; set; }
    }
}