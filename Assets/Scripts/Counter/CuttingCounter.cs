using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;
    public override void Interact(Player player)
    {
        if (!HasKitchenObject()) {
            // There no kitchen object on the counter
            if (player.HasKitchenObject()) {
                // player is carrying a kitchen object
                player.GetKitchenObject().SetKitchenObjectParent(this);
            } else {
                // player is not carrying a kitchen object
            }
        } else {
            // There is a kitchen object on the counter
            if (player.HasKitchenObject()) {
                // player is carrying a kitchen object

            } else {
                // player is not carrying a kitchen object
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

    public override void InteractAlternate(Player player)
    {
        if (HasKitchenObject()) {
            GetKitchenObject().DestroySelf();
            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);
        }
    }
}
