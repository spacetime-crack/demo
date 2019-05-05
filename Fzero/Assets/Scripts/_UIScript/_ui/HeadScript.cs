using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;
public class HeadScript : BaseUIForms
{

    void Start()
    {
        //设置窗体默认性质
        base.CurrentUIType.UIForms_Type = UIFormsType.Normal;
        base.CurrentUIType.UIForms_ShowMode = UIFormsShowMode.HideOther;
        base.CurrentUIType.UIForms_LucencyType = UIFormsLucencyType.Lucency;

    }


}
