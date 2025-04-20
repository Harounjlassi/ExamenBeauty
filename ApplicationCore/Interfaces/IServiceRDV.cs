using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Interfaces;
using ApplicationCore.Domain;

namespace ApplicationCore.Interfaces
{
    public interface IServiceRDV:IService<RDV>
    {
        IEnumerable<IGrouping<DateTime, RDV>> RDvConfirmes(Client c);

    }
}
