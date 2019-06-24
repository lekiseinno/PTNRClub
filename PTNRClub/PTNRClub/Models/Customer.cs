using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PTNRClub.Models
{

    [Table("Customers")]
    public class Customer
    {
        //  [PrimaryKey, AutoIncrement] //มันจะ Effect ที่ตัวล่างมันตัวเดียว

        [MaxLength(200), NotNull]
        public string cust_id { get; set; }

        [MaxLength(200), NotNull]
        public string cust_name { get; set; }


        [MaxLength(20), NotNull, Unique]
        public string cust_surname { get; set; }

        [MaxLength(100)]
        public string cust_email { get; set; }

        [MaxLength(20)]
        public string cust_tel { get; set; }

        [MaxLength(50), NotNull]
        public string cust_password { get; set; }

        [MaxLength(50), NotNull]
        public string cust_card { get; set; }

        public int point { get; set; }

    }
}

