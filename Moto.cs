using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOHerencia
{
    class Moto:Vehiculo
    {
        private bool _sideCard { get; set; }
        public Moto(int id, string marca, string modelo, int km, double precio, bool sideCard)
            : base(id, marca, modelo, km, precio)
        {
            this._sideCard = sideCard;
        }
        public bool sideCard { get => _sideCard; set => _sideCard = value; }

        public override double precio
        {
            get
            {
                if (this.sideCard)
                {
                    return base.precio + 50;
                }
                else
                {
                    return base.precio;
                }
            }
        }
    }
}
