using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using GB;
using UnityEngine.Tilemaps;

public class WorldMap : AutoSingleton<WorldMap>
{

    public Tilemap worldMap;
    // Start is called before the first frame update
    void Start()
    {
        UIManager.I.Init();
        GameStart();
    }

    private void GameStart()
    {
        // UIManager.ShowPopup("PausePopup");
        // Debug.Log("?");
        Debug.Log(worldMap);
        
    }

    void Update()
    {
        //  if(Input.GetKeyDown(KeyCode.Q))
        //  {
        //     Debug.Log("123123");
        //  }
    }
}
