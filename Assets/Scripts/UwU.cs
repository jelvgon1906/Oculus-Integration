using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UwU : MonoBehaviour
{
    public TMP_Text uwu;

    // Update is called once per frame
    public void SayUwU()
    {
        uwu.text += "uwu";
    }
}
