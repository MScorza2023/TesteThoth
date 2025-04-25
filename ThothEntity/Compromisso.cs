using System;

namespace ThothEntity
{
    public class Compromisso
    {
        public Usuario Usuario { get; set; }
        public DateTime Data { get; set; }
        public string HorarioInicial { get; set; }
        public string HorarioFinal { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public bool DiaTodo { get; set; }
        public int IdCompromisso { get; set; }
    }
}
