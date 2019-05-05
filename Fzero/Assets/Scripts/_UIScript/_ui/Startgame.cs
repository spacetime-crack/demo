using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    void Start()
    {
        Log.Write(GetType() + "/Start()/");
        //加载登陆窗体
        UIManager.GetInstance().ShowUIForms(ProCanst.LOGON_FROMS);

    }

}
