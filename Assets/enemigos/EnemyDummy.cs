using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int HP = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "daño")
        {
            HP--;
            if(HP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
