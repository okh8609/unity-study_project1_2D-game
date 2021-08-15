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
        btn.onClick.AddListener(() => print("大家好~ " + Time.time.ToString()));
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            print("你好! " + Time.time.ToString());

        // output.text = Time.time.ToString() + " ; " + Time.realtimeSinceStartup.ToString(); // 使用者有在玩的時間；啟動程式至今
    }

    public void BtnClick()
    {
        output.text = input.text;
    }
}
