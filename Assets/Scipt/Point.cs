using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{

    public Text PointText;


    // Start is called before the first frame update
    void Start()
    {
        PointText.text = "Your Got " + Trash.Point.ToString() + " Point";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}