using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoread : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.scoreValue++;
    }
}
