using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class GameManager : MonoBehaviour
{
    private static bool levelstart = false;
    public static bool LevelStart { get => levelstart; set => levelstart = value; }
    

    public static GameManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            levelstart = false;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && levelstart == false)
        {
            levelstart = true;
        }
    }

}
