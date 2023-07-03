using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUI : UICanvas
{
 
    [SerializeField] GameObject settingBtn;
    [SerializeField] Text Alive;
 
    void Update()
    {
        Alive.text = "Alive: "+ LevelManager.Instance.currentLevel.totalAmount;
    }
    public void SettingBtn()
    {
        GameManagerr.Instance.ChangeState(EGameState.Pause);
        UIManager.Instance.OpenUI<Setting>();
        Close();   
    }

}
