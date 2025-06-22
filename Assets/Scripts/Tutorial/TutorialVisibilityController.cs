using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialVisibilityController : MonoBehaviour
{
    public GameObject tutorialRoot;
    public GameObject Quad;
    public GameObject yuay;

    void Start()
    {
        if (!TutorialSessionFlag.HasSeenTutorial)
        {
            tutorialRoot.SetActive(true);
            Quad.SetActive(true);
            TutorialSessionFlag.HasSeenTutorial = true;
        }
        else
        {
            tutorialRoot.SetActive(false);
            Quad.SetActive(false);
            yuay.SetActive(true);
        }
    }
}
