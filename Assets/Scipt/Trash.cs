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
    public int[] itemNumbers;
    public Text[] itemTextList;





    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        PointText.text = Point.ToString();
        itemTextList[0].text = itemNumbers[0].ToString();
        itemTextList[1].text = itemNumbers[1].ToString();
        itemTextList[2].text = itemNumbers[2].ToString();

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Can" && itemNum < 3)

        {

            item = "Can";
            Destroy(collision.gameObject, 0.1f);
            guideText.text = "Go trash can to throw away";
            itemNumbers[0] += 1;


        }
        if (collision.gameObject.tag == "Paper" && itemNum < 3)
        {
            item = "Paper";
            Destroy(collision.gameObject, 0.1f);
            guideText.text = "Go trash can to throw away";
            itemNumbers[1] += 1;


        }
        if (collision.gameObject.tag == "Hamburger" && itemNum < 3)
        {
            item = "Hamburger";
            Destroy(collision.gameObject, 0.1f);
            guideText.text = "Go trash can to throw away";
            itemNumbers[2] += 1;


        }






        if (collision.gameObject.tag == "CanTrash")
        {

            Point += itemNumbers[0] ;
            itemNumbers[0] = 0;
            Point += itemNumbers[1] ;
            itemNumbers[1] = 0;
            Point += itemNumbers[2] * 2;
            itemNumbers[2] = 0;
            guideText.text = "Go Get Trash";

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