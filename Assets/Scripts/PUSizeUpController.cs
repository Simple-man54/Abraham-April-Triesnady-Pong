using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSizeUpController : MonoBehaviour
{
    public PowerUpSize manager;
    public Collider2D ball;
    public Collider2D paddlekiri;
    public Collider2D paddlekanan;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddlekiri.GetComponent<PaddleController>().ActivatePaddleSize(magnitude);
            manager.RemovePowerUp(gameObject);
        }
        else if (collision == ball)
        {
            paddlekanan.GetComponent<PaddleController>().ActivatePaddleSize(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
