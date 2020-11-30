using UnityEngine;

public class Level_movement : MonoBehaviour
{
    public int levelSpeed = 5;
    public void FixedUpdate()
    {
        transform.Translate(Vector2.left * levelSpeed * Time.deltaTime);
        
    }
}
