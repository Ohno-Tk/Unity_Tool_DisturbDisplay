using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]
    private KeyCode KeyPause = KeyCode.F1;
    [SerializeField]
    private GameObject PauseUIObject;
    private bool PauseFlag = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyPause))
        {
            PauseFlag = !PauseFlag;
            PauseUIObject.SetActive(PauseFlag);
            Debug.Log("ポーズフラグ：" + PauseFlag);

        }

        if(PauseFlag == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
