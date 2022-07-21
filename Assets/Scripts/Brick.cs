using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hits = 1;
    public int points = 1;
    public Vector3 rotator;
    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(rotator * (transform.position.x + transform.position.y) * 2);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(rotator * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        hits--;
        // Score Point
        if (hits <= 0) {
            Destroy(gameObject);
        }
    }
}
