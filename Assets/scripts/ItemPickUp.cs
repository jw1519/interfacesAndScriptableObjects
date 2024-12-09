using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public ScriptableObject itemData;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            ICollectable item = itemData as ICollectable;
            player.CollectItem(item);
            Destroy(gameObject);
        }
    }
}
