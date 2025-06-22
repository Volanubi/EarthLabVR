using UnityEngine;

public class TutorialDarken : MonoBehaviour
{
    public GameObject darkenPanel;

    public void ShowDarkenOverlay()
    {
        darkenPanel.SetActive(true);
    }

    public void HideDarkenOverlay()
    {
        darkenPanel.SetActive(false);
    }
}
