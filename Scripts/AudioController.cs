using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public GameObject audioController;

    private void Start()
    {
        DontDestroyOnLoad(audioController);
    }

}
