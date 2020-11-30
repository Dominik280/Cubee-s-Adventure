using UnityEngine;

public class Add_coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Shop.money += 1;
        Destroy(gameObject);
    }
}
