using BepInEx;
using UnityEngine;

namespace CWX_MasterKey
{
    [BepInPlugin("com.CWX.MasterKey", "CWX-MasterKey", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new Patch().Enable();
        }
    }
}
