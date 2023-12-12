using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;


[InitializeAtRuntime]
public class Minigame_custom_service : IEngineService
{
    private readonly InputManager inputManager;
    private readonly ScriptPlayer scriptPlayer;

    bool is_start = true;

    public Minigame_custom_service(InputManager inputManager, ScriptPlayer scriptPlayer)
    {
        this.inputManager = inputManager;
        this.scriptPlayer = scriptPlayer;
    }

    public UniTask InitializeServiceAsync()
    {
        if (!is_start)
        {
            SceneManager.LoadSceneAsync("Demo", LoadSceneMode.Additive);
        }
        else
        {
            is_start = false;
        }
        
        return UniTask.CompletedTask;
    }

    public void ResetService()
    {

    }

    public void DestroyService()
    {

    }

    /*
    public async Task StartMemoryGameAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Demo", LoadSceneMode.Additive);
        while (!asyncLoad.isDone)
        {
            await Task.Yield();
        }
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Demo"));
    }
  */

}
