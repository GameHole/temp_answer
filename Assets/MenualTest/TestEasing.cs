using Ans;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEasing : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        new Tween().EaseInOut(game, Vector3.zero, Vector3.one, 1, false);
    }

}
