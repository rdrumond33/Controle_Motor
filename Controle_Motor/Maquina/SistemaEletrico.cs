using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Motor.Maquina
{
    class SistemaEletrico
    {
        /*
         * .iniciar sistema: gerar um numero aleatório entre 1 e 6 armazenar no atributo status_sistema.
          .checar sistema se o status_sistema for maior que 4, informar falha, caso contrario, informar sucesso.
    */

        private Random rnd;
        private int _status_sistema;
        private bool _error;

        public bool error { get { return _error; } set { this._error = value; } }
        public int status_sistema { get { return _status_sistema; } set { _status_sistema = value; } }

        public SistemaEletrico()
        {
            rnd = new Random();
            this.status_sistema = rnd.Next(1, 6);
        }

        public void ChecarSistemaEletrico()
        {

            if (this.status_sistema > 4)
            {
                this.error = true;
                SistemLog.SalvarLog("Error no Sistema Eletrico Gentileza Numero: " + this.status_sistema);
            }
            else
            {
                SistemLog.SalvarLog("Sistema Eletrico online  Numero: " + this.status_sistema);
            }
        }



    }

}
