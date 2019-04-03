using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Spawn : MonoBehaviour
{
    private static Player_Spawn instance;

    Vector2 SPAWN_POINT_POSITION;
    Vector2 NEXT_ROOM_SPAWN_POSITION;
    public float posx = 0;
    public float posy = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SPAWN_POINT_POSITION = new Vector2(posx, posy);
        NEXT_ROOM_SPAWN_POSITION = new Vector2(posx, posy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
