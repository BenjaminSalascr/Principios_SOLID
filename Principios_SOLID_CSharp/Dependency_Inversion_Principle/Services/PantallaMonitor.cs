using Dependency_Inversion_Principle.Models;

namespace Dependency_Inversion_Principle.Services
{
    public class PantallaMonitor
    {
        private IInfo _info;

        public PantallaMonitor(IInfo info)
        {
            _info = info;
        }

        public async Task Show()
        {
            //PantallaMonitor es una clase de alto nivel y no debe depender de InfoByRequest que es clase de bajo nivel
            //var info = new InfoByRequest(_origen); // evitamos la dependencia con la interfaz
            var info = await _info.GetInfoAsync();
            foreach (var item in info)
            {
                Console.WriteLine("titulo: {0}", item.title);
            }
        }
    }
}
