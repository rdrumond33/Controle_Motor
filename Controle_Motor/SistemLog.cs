using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Controle_Motor
{
    static class SistemLog
    {
        
        public static string data_sistema { get { return DateTime.Now.ToString("dd/MM/yyyy"); } }
        public static string hora_sistema { get { return DateTime.Now.ToString("HH:mm:ss"); } }

        private static string _textLog;
        private static string _path = @"C:\Users\R-DRU\Desktop\Trabalho JP\Controle_Motor\Controle_Motor\Arquivos\log\Log.TXT";

        public static string textLog { get { return _textLog; } set { _textLog = value; } }

        public static void IniciarLOG(string Text)
        {
            Console.WriteLine(_path);
            try
            {
                if (!File.Exists(_path))
                {
                    using (StreamWriter write = new StreamWriter(_path, true, Encoding.UTF8))
                    {
                        write.WriteLine(SistemLog.StringLog(Text));
                        write.Flush();
                        write.Close();
                    }
                }
                else
                {
                    File.Delete(_path);
                    using (StreamWriter write = new StreamWriter(_path, true, Encoding.UTF8))
                    {
                        write.WriteLine(SistemLog.StringLog(Text));
                        write.Flush();
                        write.Close();
                    }
                }
            }
            catch (Exception e)
            {
            }
        }

        public static void SalvarLog(string Text)
        {
            try
            {
                using (StreamWriter write = new StreamWriter(_path, true, Encoding.UTF8))
                {
                    write.WriteLine(SistemLog.StringLog(Text));
                    write.Flush();
                    write.Close();
                }
    
            }
            catch (Exception e)
            {

            }


        }

        public static string LerLog()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_path, Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception e ) {
                return "Erro de leitura arquivo de log";

            }

        }



        private static String StringLog(string Text)
        {
            return "Data: " + SistemLog.data_sistema + "-" + " Hora: " + SistemLog.hora_sistema + "-->" + Text;
        }
    }

}
