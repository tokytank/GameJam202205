using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Petri : MonoBehaviour
{
    public enum LogicState{
        occupation,
        free
    }
    public enum ViewState{
        none,
        selected,
        preSelected,
        
    }
    public int slimeNum;
    public Transform pivot;
    private void OnMouseOver() {
        PointerMgr.Instance.PreSelect(this);
    }
    private void OnMouseDown() {
        PointerMgr.Instance.EnterDrag(this);
    }
    private void OnMouseExit() {
        PointerMgr.Instance.ExitPreSelect(this);
    }

    #region view
    public void EnterSelected()
    {

    }
    public void ExitSelected()
    {

    }
    public void EnterTarget()
    {

    }
    public void ExitTarget()
    {

    }
    #endregion
}
