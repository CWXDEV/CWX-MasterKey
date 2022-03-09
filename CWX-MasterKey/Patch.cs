using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Reflection.Utils;
using EFT;
using Aki.Common.Utils;

namespace CWX_MasterKey
{
    public class Patch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            var result = typeof(MainApplication).GetMethod("method_41", PatchConstants.PrivateFlags);
            
            return result;
        }

        [PatchPostfix]
        private static void PatchPostFix()
        {
            MasterKey.Start();
        }
    }
}