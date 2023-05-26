using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordeScript : MonoBehaviour
{
    public GameObject thisthing;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(1000f, 1000f);
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyTrigger.TriggerEnemy)
        {
            transform.position = new Vector2(-90f, -37.87f);
        }
    }
}
