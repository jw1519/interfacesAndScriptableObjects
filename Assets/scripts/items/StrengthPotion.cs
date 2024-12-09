using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StrengthPotion", menuName = "Collectables/StrengthPotion")]
public class StrengthPotion : ScriptableObject, ICollectable
{
    public int strengthIncrease = 2;
    public void ApplyEffect(PlayerController player)
    {
        player.strength += strengthIncrease;
    }
}
