using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeleStock.Models
{
    public class Produit
    {
        [Key]
        public int produitID { get; set; }

        [Display(Name = "Code")]
        public string codeProduit { get; set; }


        [Display(Name = "Référence")]
        public string refProduit { get; set; }


        [Display(Name = "Désignation")]
        public string desProduit { get; set; }


        [Display(Name = "Prix Vte HT")]
        public decimal? prixVenteHtProduit { get; set; }


        [Display(Name = "Prix Achat HT")]
        public decimal? prixAchatHtProduit { get; set; }


        [Display(Name = "TVA")]
        public string tvaProduit { get; set; }

        [RegularExpression(@"^\d+.\d{0,2}$")]
        [Display(Name = "Qte En Stock")]
        public decimal? qteEnStockProduit { get; set; }


        [Display(Name = "Qte Rupture")]
        public decimal? qteRuptureProduit { get; set; }


        [Display(Name = "Qte Sur Stock")]
        public decimal? qteSurStockProduit { get; set; }


        [Display(Name = "Remarque")]
        public string remarqueProduit { get; set; }


        //public int EmployeeID { get; set; }
        //[Required(ErrorMessage = "This Field is Required")]
        //public string Name { get; set; }
        //[Required(ErrorMessage = "This Field is Required")]
        //public string Position { get; set; }
        //public string Office { get; set; }
        //public Nullable<int> Age { get; set; }
        //public Nullable<int> Salary { get; set; }


        //[Display(Name = "Release Date")]
        //[DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }
        //public string Genre { get; set; }

        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal Price { get; set; }
    }
}
