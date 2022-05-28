using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerMgr : Singleton<PointerMgr>
{
    private Petri currentPetri;
    private Petri overMouse;
    public void PreSelect(Petri petri)
    {
        if(currentPetri==null)
            return;
        overMouse = petri;
    }
    public void ExitPreSelect(Petri petri)
    {
        if(currentPetri==null)
            return;
        if(overMouse==petri)
            overMouse = null;
    }
    public void EnterDrag(Petri petri)
    {
        currentPetri = petri;
        ArrowMgr.Instance.GenerateArrow();
    }
    private void UpdateDrag() {
        if(currentPetri==null)
            return;
        if(!Input.GetMouseButton(0))
        {
            ExitDrag();
        }

    }
    private void ExitDrag()
    {
        currentPetri = null;
        overMouse = null;
        ArrowMgr.Instance.ExitArrow();
    }
}
