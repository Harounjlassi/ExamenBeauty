using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Prestation
    {
        //Prop de base
        
        //anotaion cote client : en web
        //sur plusieurs ligne 
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Intitule { get; set; }
        public int PrestationId { get; set; }
        public Type PrestationType { get; set; }

        [DataType(DataType.Currency)]
        public double Prix { get; set; }

        //prop de navigation 

        public int PrestataireFk { get; set; }

        [ForeignKey("PrestataireFk")]//renomer et config  de cle etranger par l'annotaiotn 
        public virtual Prestataire Prestataire { get; set; }
        public virtual IList<RDV> RDVs { get; set; }



    }
}
