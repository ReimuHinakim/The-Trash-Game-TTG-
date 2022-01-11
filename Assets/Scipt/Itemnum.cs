using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Itemnum : MonoBehaviour
{
    GameObject Standing;
    Trash TrashScript;
    public Text HoldText;

    // Start is called before the first frame update
    void Start()
    {
        Standing = GameObject.Find("Standing");
        TrashScript = Standing.GetComponent<Trash>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(TrashScript.item);
        HoldText.text = "You Have " + TrashScript.itemNum.ToString() + TrashScript.item.ToString() + " Now";
    } 
}
