using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Motor.Maquina
{
    class SistemadeArrefecimento
    {

        /*  .Iniciar sistema: ler de um arquivo o nível atual de água, a temperatura atual e a temperatura de alerta.
  .Avaliar sistema: se a temperatura atual ultrapassar 70% da temperatura de alerta, acender a luz e ligar a ventoinha, ventoinha decrementa 1 grau a cada 3 segundos.
  O primeiro decrementa só ocorrera apos 8 segundos.A ventoinha desliga quando a temperatura atual estiver abaixo de 30% da temperatura de alerta.
          */
        private string _path = @"C:\Users\R-DRU\Desktop\Trabalho JP\Controle_Motor\Controle_Motor\Arquivos\SistemadeArrefecimento.txt";
        private string[] _dados = new string[5];

        private int _nivelAtualAgua;
        private int _TemperaturaAtual;
        private int _TemperaturaDeAlerta;
        private bool _primeiro = true;
        private long _tempoEspera;


        public SistemadeArrefecimento()
        {
            using (StreamReader reader = new StreamReader(_path))
            {
                this._dados = reader.ReadLine().Split(' ');
                _nivelAtualAgua = int.Parse(_dados[1]);
                _TemperaturaAtual = int.Parse(_dados[3]);
                _TemperaturaDeAlerta = int.Parse(_dados[5]);

            }
            AvaliarSistema();
        }
        public void AvaliarSistema()
        {
            ChegarTemperatura();
        }


        private void ChegarTemperatura()
        {
            if (_TemperaturaAtual > (_TemperaturaDeAlerta * 0.7))
            {

                while (_TemperaturaAtual > (_TemperaturaDeAlerta * 0.7))
                {
                    if (_primeiro)
                    {
                        SistemLog.SalvarLog("Ventilador ligado temperatura: " + _TemperaturaAtual);
                        SetTimer(8);
                        _TemperaturaAtual--;
                        _primeiro = false;
                        SistemLog.SalvarLog("Nivel da agua :" + _nivelAtualAgua + " Temperatura Atual " + _TemperaturaAtual + " TemperaturaDeAlerta: " + this._TemperaturaDeAlerta + " 70% TemperaturaDeAlerta: " + (_TemperaturaDeAlerta * 0.7) + " Primeira Ligação: " + _primeiro + " Tempo de espera aproximado: " + this._tempoEspera);
                    }
                    else
                    {
                        SetTimer(3);
                        _TemperaturaAtual--;
                        SistemLog.SalvarLog("Nivel da agua :" + _nivelAtualAgua + " Temperatura Atual " + _TemperaturaAtual + " TemperaturaDeAlerta: " + this._TemperaturaDeAlerta + " 70% TemperaturaDeAlerta: " + (_TemperaturaDeAlerta * 0.7) + " Primeira Ligação: " + _primeiro + " Tempo de espera aproximado: " + this._tempoEspera);

                    }

                }
            }
            else
            {
                SistemLog.SalvarLog("Nivel da agua :" + _nivelAtualAgua + " Temperatura Atual " + _TemperaturaAtual + " TemperaturaDeAlerta: " + this._TemperaturaDeAlerta + " 70% TemperaturaDeAlerta: " + (_TemperaturaDeAlerta * 0.7));
            }

        }

        private void SetTimer(int tempo)
        {
            Stopwatch watch = Stopwatch.StartNew();

            using (var task = Task.Delay(tempo * 1000))
            {
                task.Wait();
            }

            watch.Stop();

            this._tempoEspera = watch.ElapsedMilliseconds;

        }
    }

}
