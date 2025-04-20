using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using ApplicationCore.Domain;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Services
{
    public class ServicePrestataire : Service<Prestataire>, IServicePrestataire
    {
        public ServicePrestataire(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public IEnumerable<Prestataire> Get3Prestataire()
        {
            //foreach(var item in )
            return GetMany(p => p.Zone == Zone.Raoued)
                .OrderBy(p => p.Note).Take(3);
        }





    }
}
