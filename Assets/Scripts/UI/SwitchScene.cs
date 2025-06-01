using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] private short sceneId;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneId);
    }
}
