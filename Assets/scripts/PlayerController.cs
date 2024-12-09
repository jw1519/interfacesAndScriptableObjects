using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 100;
    public float speed = 5f;
    public int strength = 5;

    public void CollectItem(ICollectable item)
    {
        item.ApplyEffect(this);
    }
}
