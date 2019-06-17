using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class User
    {    
        /// <summary>
        /// id identity of user
        /// </summary>
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// tz 
        /// </summary>
        [Required]
        public int TZ { get; set; }
        /// <summary>
        /// name of user
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// email of user
        /// </summary>
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        /// date of bith
        /// </summary>
        [DataType(DataType.Date), Required]
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// phone
        /// </summary>
        public int Phone { get; set; }
    }
}
