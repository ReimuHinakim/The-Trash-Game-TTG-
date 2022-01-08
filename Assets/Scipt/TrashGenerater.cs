using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGenerater : MonoBehaviour

{   
    public GameObject Ham;
    public float Lenth;
    public float Width;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate", 1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generate()
    {
        float x = Random.Range(-450, 500);
        float z = Random.Range(0, 600);
        Instantiate(Ham, transform.position + new Vector3(x, 0, z), Quaternion.identity);
    }
}
