using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpInvincible : PowerUpBase
{

    protected override void StartPowerUp()
    {
        base.StartPowerUp();
        PlayerController.instance.SetInvincible(true);
    }

    protected override void EndPowerUp()
    {
        base.EndPowerUp();
        PlayerController.instance.SetInvincible(false);
    }
    
}
