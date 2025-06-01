using UnityEngine;

public class SwitchUI : MonoBehaviour
{
    [SerializeField] private GameObject currentUI;
    [SerializeField] private GameObject targetUI;
    public void SwitchInterface()
    {
        currentUI.SetActive(false);
        targetUI.SetActive(true);
    }
}
