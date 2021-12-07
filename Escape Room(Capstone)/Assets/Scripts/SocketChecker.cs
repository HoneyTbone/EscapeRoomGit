using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketChecker : XRSocketInteractor
{
    public string targetTag = string.Empty;

    public bool trophy = false;
    public bool completed = false;

    public bool chest = false;
    public bool key = false;

    public bool coffee = false;
    public bool done = false;


   public override bool CanHover(XRBaseInteractable interactble)
    {
        return base.CanHover(interactble) && MatchUsingTag(interactble);
    }

    public override bool CanSelect(XRBaseInteractable interactble)
    {
        if (trophy == true)
        {
            if (base.CanSelect(interactble) && MatchUsingTag(interactble))
            {
                completed = true;
            }
        }
        if (chest == true)
        {
            if (base.CanSelect(interactble) && MatchUsingTag(interactble))
            {
                key = true;
            }
        }
        if (coffee == true)
        {
            if (base.CanSelect(interactble) && MatchUsingTag(interactble))
            {
                done = true;
            }
        }
        return base.CanSelect(interactble) && MatchUsingTag(interactble);

    }

    private bool MatchUsingTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);
    }
}
