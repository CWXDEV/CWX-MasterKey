using BepInEx;
using EFT.Interactive;
using System.Linq;
using UnityEngine;

namespace CWX_MasterKey
{
    public class MasterKey
    {
        public static void Start()
        {
            var allDoors = GameObject.FindObjectsOfType<Door>().ToList(); // mechanical doors
            var allKeyCardDoors = GameObject.FindObjectsOfType<KeycardDoor>().ToList(); // keycard doors
            var allKeyContainers = GameObject.FindObjectsOfType<LootableContainer>().ToList(); // locked loot containers
            var allTrunks = GameObject.FindObjectsOfType<Trunk>().ToList(); // locked car trunks

            foreach (var door in allDoors)  // mechanical doors
            {
                if (!door.KeyId.IsNullOrWhiteSpace() || !door.KeyId.IsNullOrEmpty())
                {
                    door.KeyId = "5c1d0d6d86f7744bb2683e1f";
                }
            }
            
            foreach (var door in allKeyCardDoors) // keycard doors
            {
                if (!door.KeyId.IsNullOrWhiteSpace() || !door.KeyId.IsNullOrEmpty())
                {
                    door.KeyId = "5c1d0d6d86f7744bb2683e1f";
                }
            }
            
            foreach (var door in allKeyContainers) // locked loot containers
            {
                if (!door.KeyId.IsNullOrWhiteSpace() || !door.KeyId.IsNullOrEmpty())
                {
                    door.KeyId = "5c1d0d6d86f7744bb2683e1f";
                }
            }
            
            foreach (var door in allTrunks) // locked car trunks
            {
                if (!door.KeyId.IsNullOrWhiteSpace() || !door.KeyId.IsNullOrEmpty())
                {
                    door.KeyId = "5c1d0d6d86f7744bb2683e1f";
                }
            }
        }
    }
}