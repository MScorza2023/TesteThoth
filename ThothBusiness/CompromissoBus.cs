using System;
using ThothEntity;
using ThothDataAccess;
using System.Collections.Generic;

namespace ThothBusiness
{
    public class CompromissoBus
    {
        public bool AlterarCompromisso(Compromisso compromisso)
        {
            CompromissoDal compromissoDal = new CompromissoDal();
            return compromissoDal.AlterarCompromisso(compromisso);
        }

        public bool ExcluirCompromisso(int idUsuario, int idCompromisso)
        {
            CompromissoDal compromissoDal = new CompromissoDal();
            return compromissoDal.ExcluirCompromisso(idUsuario, idCompromisso);
        }

        public bool ExisteOutroCompromisso(int idUsuario, string dataAgenda, int idCompromisso)
        {
            CompromissoDal compromissoDal = new CompromissoDal();
            return compromissoDal.ExisteCompromisso(idUsuario, dataAgenda, idCompromisso);
        }

        public int InserirCompromisso(Compromisso compromisso)
        {
            CompromissoDal compromissoDal = new CompromissoDal();
            return compromissoDal.InserirCompromisso(compromisso);
        }

        public List<Compromisso> ListarCompromissos(int idUsuario, string dataAgenda)
        {
            CompromissoDal comprDal = new CompromissoDal();
            return comprDal.ListarCompromissos(idUsuario, dataAgenda);
        }
    }
}
