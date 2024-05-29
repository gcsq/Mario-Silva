using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class montanha : MonoBehaviour
{
    public float montaSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MonMove();
    }

    void MonMove()
    {
        transform.position += Vector3.left * montaSpeed * Time.deltaTime;
    }
}
