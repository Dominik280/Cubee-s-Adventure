using UnityEngine;

public class Color_switch : MonoBehaviour
{
    
    public GameObject swb;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(swb);
        }
    }
}
