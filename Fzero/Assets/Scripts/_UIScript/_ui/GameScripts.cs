using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUIFW;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScripts : BaseUIForms
{
    private Slider Slider;
    private Text l_progress;
    private AsyncOperation async = null;
    private bool isGameStart = false;
    void Awake()
    {
        //设置窗体默认性质
        base.CurrentUIType.UIForms_Type = UIFormsType.PopUp;
        base.CurrentUIType.UIForms_ShowMode = UIFormsShowMode.HideOther;
        base.CurrentUIType.UIForms_LucencyType = UIFormsLucencyType.Lucency;
        Slider = UnityHelper.FindTheChild(this.gameObject, "Slider").GetComponent<Slider>();
        l_progress = UnityHelper.FindTheChild(this.gameObject, "l_progress").GetComponent<Text>();


    }
    private void Start()
    {
        StartCoroutine("LoadScene");
    }
    private void Update()
    {
        if (async.allowSceneActivation)
        {
            isGameStart = true;
        }
        if (isGameStart)
        {
            ShowUIForms("heroHead");
            UnityHelper.ClearMemory();
            isGameStart = false;
            this.Hiding();
            async.allowSceneActivation = false;
        }
    }

    IEnumerator LoadScene()
    {
        async = SceneManager.LoadSceneAsync("Game");
        async.allowSceneActivation = false;
        while (!async.isDone)
        {
            if (async.progress < 0.9f)
                Slider.value = async.progress;
            else
                async.allowSceneActivation = true;


            yield return null;
        }

    }
}
