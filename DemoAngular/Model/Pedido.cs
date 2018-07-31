using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAngular.Model
{
    public class Pedido
    {

        [JsonProperty(PropertyName = "NroPedido")]
        public int NroPedido { get; set; }

        [JsonProperty(PropertyName = "DesPedido")]
        public string DesPedido { get; set; }

        [JsonProperty(PropertyName = "FchPedido")]
        public DateTime FchPedido { get; set; }

        [JsonProperty(PropertyName = "CodVendedor")]
        public char CodVendedor { get; set; }
                
    }
}
