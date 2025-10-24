using UnityEngine;

public class Rotator_2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(new Vector3(1, 0, 4) * Time.deltaTime);
    }
}
