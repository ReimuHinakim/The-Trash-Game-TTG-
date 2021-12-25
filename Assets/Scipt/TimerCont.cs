using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCont : MonoBehaviour
{
    public float timeCount;
    public Text countDownText;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Hidetext", 3);
    }

    // Update is called once per frame
    void Update()
    {
        timeCount -= Time.deltaTime;
        

        if (timeCount <= 0)
        {
            SceneManager.LoadScene("Point time");
        }
    }

    void Hidetext()
    {
        countDownText.text = "";
    }
}
