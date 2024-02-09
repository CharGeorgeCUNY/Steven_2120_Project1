using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float XMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float YMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector2 move = new Vector2(XMove, YMove);
        transform.Translate(move);

    }
    
}
