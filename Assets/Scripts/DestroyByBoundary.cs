using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

 	void OnTriggerExit2D(Collider2D other)
    {
       Destroy(other.gameObject);
        // if(other.tag == "Bolt") {
        //     other.gameObject.transform.Translate(0.0f, -18.0f, 0.0f);
        // }
        // if(other.tag == "EnemyBolt") {
        //     other.gameObject.transform.Translate(0.0f, 20.0f, 0.0f);
        // }
    }
}
