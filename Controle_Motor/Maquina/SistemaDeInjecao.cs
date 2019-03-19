using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Motor.Maquina
{
    class SistemaDeInjecao
    {
        /*
         * .carregar sistema: ler de um arquivo o tipo de combustível (etanol, gasolina ou diesel) e armazenar um atributo.
           .testar qualidade: ler um valor aleatório entre 1 e 4. valor igual a 4 indica qualidade ruim do combustível.
         * 
         */
        private string _path = @"C:\Users\R-DRU\Desktop\Trabalho JP\Controle_Motor\Controle_Motor\Arquivos\Sistemadeinjecao.txt";
        private Random rnd;

        public int qualidadeCombustivel;

        public string combutivel;

        public SistemaDeInjecao()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_path))
                {
                    combutivel = reader.ReadLine();
                    rnd = new Random();
                    this.qualidadeCombustivel = rnd.Next(1, 4);
                }
                SistemLog.SalvarLog("Combustivel: " + this.combutivel + " Qualidade: " + this.qualidadeCombustivel);
            }
            catch (Exception e)
            {
                SistemLog.SalvarLog("Erro na leitura do arquivo Sistemadeinjecao.txt");
            }
        }


    }


}
