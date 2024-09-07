using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GB;

public class WorldMap : AutoSingleton<WorldMap>
{
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

        
    }

    void Update()
    {
        //  if(Input.GetKeyDown(KeyCode.Q))
        //  {
        //     Debug.Log("123123");
        //  }
    }
}
