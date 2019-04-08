using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMain : MonoBehaviour
{
    public Player player = null;
    private void Awake()
    {
        try
        {
            player = FindObjectOfType<Player>();
            Destroy(player.gameObject);
        }
        catch { };
    }
    public void Play()
    {
        GameManager.instance.GUI_ACTIVE = true;
        GameManager.instance.Goto_Scene("Level1-1");
        GameManager.instance.currentHealth = GameManager.instance.maxHealth;
        GameManager.instance.healthUI.fillAmount = GameManager.instance.currentHealth / GameManager.instance.maxHealth;
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