using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;

namespace Poroject.DataLayer.Entities.Wallet
{
    public class WalletType
    {
        public WalletType()
        {
                
        }


        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [Required]
        [MaxLength(150)]
        public string TypeTitle { get; set; }



        #region Relation
        public List<Wallet> wallet { get; set; }
        #endregion
    }
}
