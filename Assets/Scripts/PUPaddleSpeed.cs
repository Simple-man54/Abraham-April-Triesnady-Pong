using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeed : MonoBehaviour
{
    public PowerUpPaddleSpeed manager;
    public Collider2D ball;
    public Collider2D paddlekiri;
    public Collider2D paddlekanan;
    public float magnitude;

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddlekiri.GetComponent<PaddleController>().ActivatePaddleSpeed(magnitude);
            paddlekanan.GetComponent<PaddleController>().ActivatePaddleSpeed(magnitude);
            manager.RemovePowerUp(gameObject);

        }
        
    }
}