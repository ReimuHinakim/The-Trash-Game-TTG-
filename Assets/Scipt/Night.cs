using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Night : MonoBehaviour
{
    

    public Material Nights;    
    public Material Moring;
    public Material Rainy;
    public Material Sun;
    public Material Flask;


    [Range(0.01f,0.1f)]
    public float rotateSpeed;

    float rotationRepeatValue;

    

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Q))
        {
            RenderSettings.skybox = Nights;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            RenderSettings.skybox = Moring;
        }


        if (Input.GetKeyDown(KeyCode.Z))
        {
            RenderSettings.skybox = Rainy;
        }


        if (Input.GetKeyDown(KeyCode.X))
        {
            RenderSettings.skybox = Sun;
        }


        if (Input.GetKeyDown(KeyCode.C))
        {
            RenderSettings.skybox = Flask;
        }

        rotationRepeatValue = Mathf.Repeat(Nights.GetFloat("_Rotation") + rotateSpeed , 360f);
            Nights.SetFloat("_Rotation", rotationRepeatValue);
    }
}
