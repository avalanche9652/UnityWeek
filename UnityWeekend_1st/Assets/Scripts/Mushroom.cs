using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public float speed = 5.0f;
    public int direction = 1; // 1: right, -1: left

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int rand = UnityEngine.Random.Range(0, 2); //0 or 1
        if (rand == 0)
        {
            direction = -1; // Move left
        }
        else
        {
            direction = 1; // Move right
        }   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;
    }
}
