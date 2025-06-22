using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestroyOnSocketInsert : XRSocketInteractor
{
    public string destroyTag;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        GameObject target = args.interactableObject.transform.gameObject;

        if (target.CompareTag(destroyTag))
        {
            Destroy(target);
            Destroy(this.gameObject);
        }
    }
}