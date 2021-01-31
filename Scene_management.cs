using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_management : MonoBehaviour
{
    public void anySceneLoad(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
