using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using ApplicationCore.Domain;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Services
{
    public class ServiceRDV : Service<RDV>, IServiceRDV
    {
        public ServiceRDV(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
         
        }

        public IEnumerable<IGrouping<DateTime, RDV>> RDvConfirmes(Client c)
        {
            //return c.RDVs.Where(p => p.Confiramtion).GroupBy(r => r.DateRDV);
            //groupement : cle :valeur
            return GetAll().Where(r => r.ClientFk==c.Id && r.Confiramtion).GroupBy(r => r.DateRDV);
           /* return GetMany(p => p.ClientFk == c.Id && p.Confiramtion)
            .GroupBy(p => p.DateRDV);
*/
        }
    }
}
