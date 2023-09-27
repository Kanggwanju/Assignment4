using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContact : MonoBehaviour
{
    public float damage;

    private void OnTriggerEnter(Collider other)
    {
        Life life = other.GetComponent<Life>();

        if (life != null)
        {
            Destroy(gameObject);
            life.amount -= damage;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
