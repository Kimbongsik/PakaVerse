using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManage : MonoBehaviour
{
    public Text message;
    public Text result1;
    public Text result2;
    public Text result3;
    public Text result4;
    public InputField inputField;
    public Button button;

    public string ttext;

    GameObject obj2;

    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
        SetFunction_UI();

        obj2 = GameObject.Find("bl0");

        result1 = GameObject.Find("Text1").GetComponent<Text>();
        result2 = GameObject.Find("Text2").GetComponent<Text>();
        result3 = GameObject.Find("Text3").GetComponent<Text>();
        result4 = GameObject.Find("Text4").GetComponent<Text>();
        button = GameObject.Find("Button").GetComponent<Button>();

        StartCoroutine(Function_Button());
    }


    void SetFunction_UI()
    {
        button.onClick.AddListener(SetButton);
        inputField.onEndEdit.AddListener(Function_InputField_EndEdit);
    }

    void SetButton()
    {
        StartCoroutine(Function_Button());
    }


    IEnumerator Function_Button()
    {
        string txt = inputField.text;
     
        if (obj2.GetComponent<Enter1>().timeNum % 4 == 0)
        {
            result1.text = "";
            yield return new WaitForSeconds(0.8f);
            result1.text = ttext;
            inputField.text = "";
        }
        else if (obj2.GetComponent<Enter1>().timeNum % 4 == 1)
        {
            result2.text = "";
            yield return new WaitForSeconds(0.8f);
            result2.text = ttext;
            inputField.text = "";
        }

        else if (obj2.GetComponent<Enter1>().timeNum % 4 == 2)
        {
            result3.text = "";
            yield return new WaitForSeconds(0.8f);
            result3.text = ttext;
            inputField.text = "";
        }
        else if (obj2.GetComponent<Enter1>().timeNum % 4 == 3)
        {
            result4.text = "";
            yield return new WaitForSeconds(0.8f);
            result4.text = ttext;
            inputField.text = "";
        }

    }

    private void Function_InputField_EndEdit(string _data)
    {
        ttext = inputField.text;
    }

}