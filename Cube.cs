using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private float startDelay = 2.0f;
    private float interval = 2.0f;
    private float speed = 2.0f;

    void Start()
    {
        InvokeRepeating("ChangeCubeColor", startDelay, interval);
        InvokeRepeating("ChangeCubeSize", startDelay, interval);
    }

    void Update()
    {
        int positionIndexX = Random.Range(0, 3);
        int positionIndexY = Random.Range(0, 3);
        int positionIndexZ = Random.Range(0, 3);

        transform.position = new Vector3(positionIndexX * Time.deltaTime, positionIndexY * Time.deltaTime, positionIndexZ * Time.deltaTime);

        transform.Translate(Vector3.forward * speed);

        float cubeIndexX = Random.Range(1.0f, 10.0f);
        transform.Rotate(cubeIndexX * Time.deltaTime, 0.2f, 0.2f);
    }

    void ChangeCubeColor()
    {
        int colorIndexR = Random.Range(0, 2);
        int colorIndexG = Random.Range(0, 2);
        int colorIndexB = Random.Range(0, 2);

        Material material = Renderer.material;

        material.color = new Color(colorIndexR, colorIndexG, colorIndexB, 0.5f);

        Debug.Log(material.color);
    }

    void ChangeCubeSize()
    {
        float cubeScaleIndex = Random.Range(2.0f, 5.0f);
        transform.localScale = Vector3.one * cubeScaleIndex;
    }
}
