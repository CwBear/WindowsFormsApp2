using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Pizza
    {
        string _tipopizza, _tamanopizza, _tipobebida;

        public Pizza(string tipopizza, string tamanopizza, string tipobebida)
        {
            _tipopizza = tipopizza;
            _tamanopizza = tamanopizza;
            _tipobebida = tipobebida;
        }

        public string Tipopizza { get => _tipopizza; set => _tipopizza = value; }
        public string Tamanopizza { get => _tamanopizza; set => _tamanopizza = value; }
        public string Tipobebida { get => _tipobebida; set => _tipobebida = value; }
    }
}
