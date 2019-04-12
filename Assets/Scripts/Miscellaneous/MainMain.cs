using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMain : MonoBehaviour
{
    public Player_Spawn player_spawn;
    public void Play()
    {
        //Set starting position!!!
        GameManager.instance.Scene_Name = "Level1-1";
        GameManager.instance.posx = -9.079158f;
        GameManager.instance.posy = -3.08148f;
        
        //player = FindObjectOfType<Player>();
        player_spawn.gameObject.SetActive(true);
        GameManager.instance.GUI_ACTIVE = true;
        GameManager.instance.Goto_Scene(GameManager.instance.Scene_Name);
        GameManager.instance.currentHealth = GameManager.instance.maxHealth;
        GameManager.instance.healthUI.fillAmount = GameManager.instance.currentHealth / GameManager.instance.maxHealth;
        Instantiate(GameManager.instance.playerPrefab);
    }

    public void ReturnToTitleScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}