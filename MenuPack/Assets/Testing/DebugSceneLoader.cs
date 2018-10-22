using UnityEngine;
using DB.MenuPack;

public class DebugSceneLoader : MonoBehaviour 
{

    [SerializeField] private int sceneIndexToLoad;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.instance.LoadScene(sceneIndexToLoad, false);
        }
    }
}
