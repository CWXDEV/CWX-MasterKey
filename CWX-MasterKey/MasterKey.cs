using EFT.Interactive;
using System.Linq;
using UnityEngine;
using Aki.Common.Utils;

namespace CWX_MasterKey
{
    public class MasterKey
    {
        public static void Start()
        {
            Log.Info("MASTERKEY HAS CHANGED ALL DOORS TO WORK WITH YELLOW LABS KEYCARD!");

            var allDoors = GameObject.FindObjectsOfType<Door>().ToList(); // mechanical doors
            var allKeyCardDoors = GameObject.FindObjectsOfType<KeycardDoor>().ToList(); // keycard doors
            var allKeyContainers = GameObject.FindObjectsOfType<LootableContainer>().ToList(); // locked loot containers
            var allTrunks = GameObject.FindObjectsOfType<Trunk>().ToList(); // locked car trunks

            foreach (var door in allDoors)  // mechanical doors
            {
                if (!door.KeyId.IsNullOrEmpty())
                {
                    door.KeyId = "5c1d0d6d86f7744bb2683e1f";
                }
            }
            
            foreach (var door in allKeyCardDoors) // keycard doors
            {
                if (!door.KeyId.IsNullOrEmpty())
                {
                    door.KeyId = "5c1d0d6d86f7744bb2683e1f";
                }
            }
            
            foreach (var door in allKeyContainers) // locked loot containers
            {
                if (!door.KeyId.IsNullOrEmpty())
                {
                    door.KeyId = "5c1d0d6d86f7744bb2683e1f";
                }
            }
            
            foreach (var door in allTrunks) // locked car trunks
            {
                if (!door.KeyId.IsNullOrEmpty())
                {
                    door.KeyId = "5c1d0d6d86f7744bb2683e1f";
                }
            }
        }
    }
}