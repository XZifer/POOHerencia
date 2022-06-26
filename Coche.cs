using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOHerencia
{
    class Coche:Vehiculo
    {
        private bool _airbag { get; set; }
        public Coche(int id,string marca,string modelo,int km,double precio,bool airbag)
            :base(id,marca,modelo,km,precio) 
        {
            this._airbag = airbag;
        }
        public bool airbag { get => _airbag; set => _airbag = value; }

        public override double precio 
        {
            get
            {
                if (this.airbag)
                {
                    return base.precio + 200;
                }
                else
                {
                    return base.precio;
                }
            } 
        }

    }
}
