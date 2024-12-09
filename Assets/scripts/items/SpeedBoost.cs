using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpeedBoost", menuName = "Collectables/SpeedBoost")]
public class SpeedBoost : ScriptableObject, ICollectable
{
    public float speedIncrease = 2;
    public void ApplyEffect(PlayerController player)
    {
        player.speed += speedIncrease;
    }
}
