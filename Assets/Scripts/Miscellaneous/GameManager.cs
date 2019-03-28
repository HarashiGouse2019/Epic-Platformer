using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Start is called before the first frame update
    private void Awake()
    {
        //Singleton Implementation
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        } else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
