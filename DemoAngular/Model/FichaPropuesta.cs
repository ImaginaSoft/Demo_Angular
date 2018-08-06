using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DemoAngular.Model
{
    public class FichaPropuesta
    {

        [JsonProperty(PropertyName = "NroPedido")]
        public int NroPedido { get; set; }

        [JsonProperty(PropertyName = "NroPropuesta")]
        public int NroPropuesta { get; set; }

        [JsonProperty(PropertyName = "DesPropuesta")]
        public string DesPropuesta { get; set; }

        [JsonProperty(PropertyName = "NroDia")]
        public int NroDia { get; set; }

        [JsonProperty(PropertyName = "NroOrden")]

        public int NroOrden { get; set; }

        [JsonProperty(PropertyName = "NroServicio")]

        public int NroServicio { get; set; }

        [JsonProperty(PropertyName = "DesServicio")]

        public string DesServicio { get; set; }

        [JsonProperty(PropertyName = "DesServicioDet")]

        public string DesServicioDet { get; set; }



    }
}
