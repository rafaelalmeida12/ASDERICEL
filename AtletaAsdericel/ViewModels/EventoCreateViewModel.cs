using AtletaAsdericel.Models;

namespace AtletaAsdericel.ViewModels
{
    public class EventoCreateViewModel
    {
        public string Nome { get; set; }
        public string Edicao { get; set; }
        public string Promotor { get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }

        public Evento ToEntity()
        {
            return new Evento { Nome = Nome, Edicao = Edicao, Promotor = Promotor, Local = Local, DataInicio = DataInicio.ToUniversalTime(), DataTermino = DataTermino.ToUniversalTime()
        };
        }
    }
}
