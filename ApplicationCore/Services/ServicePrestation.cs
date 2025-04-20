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
    internal class ServicePrestation : Service<Prestation>, IServicePrestation
    {
        public ServicePrestation(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
