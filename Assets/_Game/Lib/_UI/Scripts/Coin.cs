using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : UICanvas
{
    [SerializeField] Text coin;

    private void Start()
    {
        DataPlayerController.updateCoinEvent.AddListener(UpdateCoin);
        DataPlayerController.updateCoinEvent.Invoke();
    }

    public void UpdateCoin()
    {
        coin.text = DataPlayerController.GetCoin().ToString();
    }

}
