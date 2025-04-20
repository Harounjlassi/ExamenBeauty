using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Type = ApplicationCore.Domain.Type;

namespace ApplicationCore.Services
{
    public class ServicePrestation : Service<Prestation>, IServicePrestation
    {
        public ServicePrestation(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public double PrixMoyen()
        {
            return GetMany(p=>p.PrestationType.Equals(Type.Coiffure)).Average(p=>p.Prix);

        }
      /*  public IEnumerable<Prestataire> Get3Prestataire()
        {
            return GetAll().Select(p=>p.Prestataire).Where(p=>p.Zone==Zone.Raoued)
                .OrderBy(p => p.Note).Take(3); ;
        }*/
    }
}
