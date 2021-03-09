using ProjectGmud.PO.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectGmud.PO
{
    public class Gmud
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim{ get; set; }
        public StatusGmud StatusGmud { get; set; }
    }
}