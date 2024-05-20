using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateKitchenObject : KitchenObject
{
    [SerializeField] private List<KitchenObjectSO> validKitchenObjectSOlist;
    private List<KitchenObjectSO> kitchenObjectSOlist;

    private void Awake()
    {
        kitchenObjectSOlist = new List<KitchenObjectSO>();
    }

    public bool TryAddIngredient(KitchenObjectSO kitchenObjectSO) 
    {
        if (!validKitchenObjectSOlist.Contains(kitchenObjectSO))
        {
            return false;
        }

        if (kitchenObjectSOlist.Contains(kitchenObjectSO)) {
            return false;
        } else { 
            kitchenObjectSOlist.Add(kitchenObjectSO);
            return true;
        }
    }
}
