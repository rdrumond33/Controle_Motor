using Controle_Motor.Maquina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Motor
{
    class Facade
    {
        public bool error;

        public Facade()
        {
           
        }

        public void startFacade()
        {
            SistemaEletrico se = new SistemaEletrico();
            se.ChecarSistemaEletrico();
            this.error = se.error;
            SistemaDeInjecao sdi = new SistemaDeInjecao();
            SistemadeArrefecimento sda = new SistemadeArrefecimento();
        }

    }
}
