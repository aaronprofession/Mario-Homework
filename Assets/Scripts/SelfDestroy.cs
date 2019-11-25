using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    
    public void Destroy()
    {
        Debug.Log("Brick Destroyed");
        Destroy(this.gameObject);
    }

}
