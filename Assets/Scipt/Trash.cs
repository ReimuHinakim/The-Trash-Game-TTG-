using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{

    public string item;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trash")
        {
            item = "Trash";
            Destroy(collision.gameObject, 0.1f);
        }

       

        if (collision.gameObject.tag == "CanTrash")
        {
            item = "";
        }





    }

}