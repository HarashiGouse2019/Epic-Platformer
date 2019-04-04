using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject playerPrefab;
    private Player_Spawn player;

    [Header("Destination")]
    public string Scene_Name;

    [Header("Set Position")]
    public float posx, posy;

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

    public void Goto_Scene(string scene_name)
    {
        scene_name = Scene_Name;
        if (scene_name != null) SceneManager.LoadScene(scene_name);
    }
}
