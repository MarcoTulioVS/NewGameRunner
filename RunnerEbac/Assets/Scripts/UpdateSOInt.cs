using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateSOInt : MonoBehaviour
{
    public SOInt coin;
    public TextMeshProUGUI textCoin;
    void Start()
    {
        coin.value = 0;
        UpdateCoins();
    }

    
    void Update()
    {
        UpdateCoins();
    }

    public void UpdateCoins()
    {
        textCoin.text = coin.value.ToString();
    }
}
