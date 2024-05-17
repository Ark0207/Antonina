using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynight : MonoBehaviour
{
    public Light myLight;
    public Material night;
    public Material day;



    public void Night()
    {
        myLight.intensity = 0.00f;
        RenderSettings.skybox = night;
    }
    public void Day()
    {
        myLight.intensity = 0.7f;
        RenderSettings.skybox = day;
    }
}
