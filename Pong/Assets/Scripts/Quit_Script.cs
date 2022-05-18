using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit_Script : MonoBehaviour
{
    public void doquit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
