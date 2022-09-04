using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ans;
public class TreeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeHelper.LogLeft(QuestionTree.Build());
    }

}
