using System;
using System.Collections.Generic;
using System.Text;

namespace Cuerpe_humaneLU
{
    class Objetos
    {
        private double peso;
        private string tipo;
        public CajonDeVerduras _cajonDeVerduras;
        public Camperon _camperon;
        // Silla _silla;

        // BidonDeAgua _bidonDeAgua;


        /* public void setSilla()
         {
             _silla = new Silla();
             _silla.getPeso());
             _silla.getTipo();
         }*/


        /*public void setBidon()
        {
            _bidonDeAgua = new BidonDeAgua();
            _bidonDeAgua.getTipo();
            _bidonDeAgua.getPeso();
        }*/

        public void setCajon()
        {
            _cajonDeVerduras = new CajonDeVerduras();
            _cajonDeVerduras.getTipo();
            _cajonDeVerduras.getPeso();
        }

        public void setCampera()
        {
            _camperon = new Camperon();
            _camperon.getTipo();
            _camperon.getPeso();
        }
    }
}

