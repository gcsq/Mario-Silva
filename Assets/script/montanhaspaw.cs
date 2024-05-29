using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class montanhaspaw : MonoBehaviour
{
    public float maxTime;
    private float time;
    public GameObject montanha;
    GameObject montanhaclone;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        montanhaSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if(time > maxTime)
        {
            montanhaSpawner();
            time = 0;
        }

        time += Time.deltaTime;
    }

    void montanhaSpawner()
    {
        montanhaclone = Instantiate(montanha);
        montanhaclone.transform.position = transform.position + new Vector3(0, Random.Range(dist, -dist), 0);
    }
}
