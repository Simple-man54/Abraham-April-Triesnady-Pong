using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    public GameObject Padlekiri;
    public GameObject Padlekanan;
 


    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        // get input
        Vector3 movement = GetInput();

        // move object
        MoveObject(movement);

    }



    private Vector2 GetInput()
    {
        
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    

     private void MoveObject(Vector2 movement)
    {
        Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }

    public void ActivatePaddleSize(float magnitude)
    {
       
        Padlekiri.transform.localScale = new Vector2(0.3162f, 1.7782f * magnitude);
        Padlekanan.transform.localScale = new Vector2(0.3162f, 1.7782f * magnitude);
    }
    public void ActivatePaddleSpeed(float magnitude)
    {
        speed *= magnitude;
    }

}

