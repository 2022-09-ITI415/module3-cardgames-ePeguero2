using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicContol : MonoBehaviour
{
    public static MusicContol instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
