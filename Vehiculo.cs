﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOHerencia
{
    class Vehiculo
    {
        private int _id;
        private string _marca;
        private string _modelo;
        private int _km;
        private double _precio;

        public Vehiculo(int id,string marca,string modelo,int km,double precio)
        {
            this._id = id;
            this._marca = marca;
            this._modelo = modelo;
            this._km = km;  
            this._precio = precio;
        }
        public int id { get => _id; set => _id = value; }
        public string marca { get => _marca; set => _marca = value; }
        public string modelo { get => _modelo; set => _modelo = value; }
        public int km { get => _km; set => _km = value; }
        public virtual double precio { get => _precio; set => _precio = value; }

        public override string ToString()
        {
            return "Detalles\n" + marca + "\n" + modelo + "\n" + km + "kms\n" + "$" + precio;
        }
    }
}
