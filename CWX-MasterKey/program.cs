using Aki.Common.Utils;

namespace CWX_MasterKey
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log.Info("LOADING: CWX-MASTERKEY - V1.0.0");
            new Patch().Enable();
        }
    }
}
