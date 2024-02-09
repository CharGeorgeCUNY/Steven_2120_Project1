using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFunction : MonoBehaviour
{
    public Vector3 ScaleInitial;
    public Vector3 ScaleOver;
    public Vector3 ScaleCurrent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, ScaleCurrent, .01f);
    }
    void OnMouseOver()
    {

        Debug.Log("Over");
    }
    void OnMouseEnter()
    {
        ScaleCurrent = ScaleOver;
        Debug.Log("Enter");
    }
    void OnMouseExit()
    {
        ScaleCurrent = ScaleInitial;
        Debug.Log("Exit");
    }
}