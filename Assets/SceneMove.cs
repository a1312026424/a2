using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMove : MonoBehaviour
{
    public void OnStartGame(string scenneName)
    {
        Application.LoadLevel(scenneName);
    }
}
