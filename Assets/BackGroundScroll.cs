using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    private Material material;
    private Vector2 offset;
    public int xVelocity, yVelocity;
    void Awake()
    {
        material = GetComponent<Renderer>().material;
    }
    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(xVelocity, yVelocity);
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
