using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCtrl : MonoBehaviour
{
    // public Text input;
    public InputField input;
    public Text output;
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(() => print("�j�a�n~ " + Time.time.ToString()));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            print("�A�n! " + Time.time.ToString());

        // output.text = Time.time.ToString() + " ; " + Time.realtimeSinceStartup.ToString(); // �ϥΪ̦��b�����ɶ��F�Ұʵ{���ܤ�
    }

    public void BtnClick()
    {
        output.text = input.text;
    }
}
