using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string  FullName { get; set; }
        public string Phone { get; set; }
        public  string Mobile { get; set; }
        public int IdCard { get; set; }
        public string Address { get; set; }
        public string RNC { get; set; }
        public string Email { get; set; }
    }
}
