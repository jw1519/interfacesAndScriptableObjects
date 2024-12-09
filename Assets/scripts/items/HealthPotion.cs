using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HealthPotion", menuName = "Collectables/HealthPotion")]
public class HealthPotion : ScriptableObject, ICollectable
{
    public int healthIncrease = 10;
    public void ApplyEffect(PlayerController player)
    {
        player.health += healthIncrease;
    }
}
