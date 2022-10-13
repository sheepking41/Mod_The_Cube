using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;


    void Start()
    {
        
        transform.position = new Vector3(Random.Range(1,11), Random.Range(1, 11), Random.Range(1, 11));
        transform.localScale = Vector3.one * 3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

        InvokeRepeating("changeColor", 2.0f, 2.0f);


    }
    
    void Update()
    {
        Material material = Renderer.material;
        transform.Rotate(10.0f * Time.deltaTime, 50.0f * Time.deltaTime, 10.0f * Time.deltaTime);
        



    }
    void changeColor()
    {
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.1f, 2.0f), Random.Range(0.1f, 2.0f), Random.Range(0.1f, 2.0f), Random.Range(0.1f, 2.0f));
    }


}
