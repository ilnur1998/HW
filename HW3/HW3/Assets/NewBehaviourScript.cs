using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Test;

    public void Disapp()
    {
        Test.SetActive(false);
    }
}
