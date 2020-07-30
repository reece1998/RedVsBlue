using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Gm Gm;

    void OnTriggerEnter (){
        Gm.levelComplete();
    }
}
