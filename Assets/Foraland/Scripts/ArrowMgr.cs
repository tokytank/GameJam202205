using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMgr: Singleton<ArrowMgr>
{
    private Transform currentArrow;
    public GameObject arrowPrefab;
    public void GenerateArrow()
    {
        currentArrow = GameObject.Instantiate(arrowPrefab).transform;

    }
    public void UpdateArrow(Vector2 pos,Petri petri)
    {
        if(currentArrow==null)
            return;
    }
    public void ExitArrow()
    {
        if(currentArrow==null)
            return;
        Destroy(currentArrow.gameObject);
        currentArrow = null;
    }
}
