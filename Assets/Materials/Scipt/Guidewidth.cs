using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guidewidth : MonoBehaviour
{
    public Text guideText;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guideText.text = "Pick Up";
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guideText.text = "Go Get Trash";
        }
    }
}