using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpDestroy : PowerUpBase
{
    protected override void StartPowerUp()
    {
        PlayerController.instance.SetDestroyEnemy(true);
        base.StartPowerUp();
    }

    protected override void EndPowerUp()
    {
        PlayerController.instance.SetDestroyEnemy(false);
        base.EndPowerUp();
    }
}
