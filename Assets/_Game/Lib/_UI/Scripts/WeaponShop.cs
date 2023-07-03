using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShop : UICanvas
{
    [SerializeField] Player player;
    private void Start()
    {
        player = FindObjectOfType<Player>();
    }


    public void ExitBtn()
    {
        player.gameObject.SetActive(true);
        GameManagerr.Instance.ChangeState(EGameState.MainMenu);
        UIManager.Instance.OpenUI<MainMenu>();
        Close();
    }

}
