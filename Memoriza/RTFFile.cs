using System.IO;
using System.Windows.Forms;

namespace Memoriza
{
    class RTFFile
    {
        private string _path = Application.StartupPath + "\\Resources\\Texto.txt";
        private string _texto;

        public string Texto
        {
            
            get
            {
                _texto = File.ReadAllText(_path);
                return _texto;
            }
        }
        public string Eliminar()
        {
            _texto = "";
            return _texto;
        }

        public string Gravar(string value)
        {
            _texto = value;
            File.WriteAllText(_path, _texto);
            return _texto;
        }

        public string MAIUSCULAS()
        {

        }
    }
}
