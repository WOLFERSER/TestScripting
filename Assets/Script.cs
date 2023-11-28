using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
    public Text Answer;
{   public InputField InputAnswer;
    int num;
    void Start()
    {
        num = Random.range(0, 101);
    }
}
