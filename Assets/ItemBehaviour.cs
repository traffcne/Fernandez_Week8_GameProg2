using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public Inventory inv;
    private void OnMouseDown()
    {
        inv.playerInventory.Add(gameObject);
        gameObject.SetActive(false);
    }
}
