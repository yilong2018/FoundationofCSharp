using DemoLibrary;

namespace M0605AccessModifiersDemo
{
    internal class ModiffiedDataAccess: DataAccess
    {
        public void GetUNsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }
}
