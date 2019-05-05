using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;
using UnityEngine.SceneManagement;

public class LoginUIFrom : BaseUIForms
{
    void Start()
    {
        //设置窗体默认性质
        base.CurrentUIType.UIForms_Type = UIFormsType.Normal;
        base.CurrentUIType.UIForms_ShowMode = UIFormsShowMode.Normal;
        base.CurrentUIType.UIForms_LucencyType = UIFormsLucencyType.Lucency;
        RigisteButtonObjectEvent("Btn_Loging", p =>
        {
            ShowUIForms("Loading");

        });
    }

}
