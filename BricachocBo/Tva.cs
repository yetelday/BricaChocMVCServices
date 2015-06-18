using System;
using System.ComponentModel.DataAnnotations;

namespace BricachocBo
{
   public class Tva
   {
       public int Code { get; set; }

       [DisplayFormat(DataFormatString = "{0:F3}")] 
       public decimal Taux { get; set; }
   
   }
}