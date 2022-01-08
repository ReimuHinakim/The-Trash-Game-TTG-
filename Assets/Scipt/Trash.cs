using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trash : MonoBehaviour
{
    public Text guideText;
    public Text PointText;
    public static int Point;
    public string item;
    public int itemNum;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        PointText.text = Point.ToString();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Can"&& itemNum<3)
        {

            item = "Can";
            Destroy(collision.gameObject, 0.1f);
            guideText.text = "Go trash can to throw away";
            itemNum += 1;


        }



        if (collision.gameObject.tag == "CanTrash")
        {
            if (item == "Can")
            {
                Point += itemNum;
                item = "";
                itemNum = 0;
                guideText.text = "Go Get Trash";
            }


        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            guideText.text = "Pick Up";
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            guideText.text = "Go Get Trash";
        }
    }

}