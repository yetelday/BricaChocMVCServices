﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricachocBo
{
    public class Produit
    {
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Le champ {0} doit comprendre au moins {2} caractères et ne doit pas faire plus de {1} caractères.")]
        [Required(ErrorMessage = "Le {0} est requis.")]
        public string Cpu { get; set; }

        [StringLength(30, ErrorMessage = "Le champ {0} ne doit pas faire plus de {1} caractères.")]
        [Required(ErrorMessage = "La {0} est requise.")]
        public string Description { get; set; }

        [Range(0, (double)decimal.MaxValue, ErrorMessage = "Le {0} doit être compris entre {1} et {2} ")]
        [DisplayFormat(DataFormatString = "{0:F3}")] 
        public decimal PrixHt { get; set; }
        public bool Generic { get; set; }

        public Famille LaFamille { get; set; }
        // FK
        public int CodeFamille { get; set; }

        // Equals : code identique
        public override bool Equals(Object obj)
        {
            var produit = obj as Produit;
            if (produit != null)
                return
                   produit.Cpu.Equals(this.Cpu);
            else
                return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        // ajout d'une propriété calculée : prixTTC
        [DisplayFormat(DataFormatString = "{0:F3}")] 
        public decimal PrixTtc
        {
            get { return PrixHt * (1 + LaFamille.TxTva); }
        }
    }
}
