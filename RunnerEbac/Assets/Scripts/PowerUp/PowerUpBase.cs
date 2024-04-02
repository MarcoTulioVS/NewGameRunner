using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : ItemCollectableBase
{
    [Header("Power up")]
    public float duration;

    protected virtual void EndPowerUp()
    {
        Debug.Log("End power up");
    }

    protected virtual void StartPowerUp()
    {
        Invoke("EndPowerUp",duration);
    }

    protected override void OnCollect()
    {
        StartPowerUp();
        base.OnCollect();
    }
    
}
