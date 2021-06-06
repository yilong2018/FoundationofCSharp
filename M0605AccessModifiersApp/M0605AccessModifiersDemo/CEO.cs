using DemoLibrary;

namespace M0605AccessModifiersDemo
{
    public class CEO: Manager
    {
        public void GetConnectionInfo()
        {
            ModiffiedDataAccess data = new ModiffiedDataAccess();
            data.GetUNsecureConnectionInfo();
            //formerLastName = "test";
        }
    }
}
