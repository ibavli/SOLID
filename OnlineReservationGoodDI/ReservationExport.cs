using OnlineReservationGoodDI.Entities;
using OnlineReservationGoodDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationGoodDI
{
    public class ReservationExport
    {
        IExport _export;
        public ReservationExport(IExport export)
        {
            this._export = export;
        }

        public void ReservationExportMethod(List<Reservation> reservations)
        {
            _export.Export(reservations);
        }
    }
}
