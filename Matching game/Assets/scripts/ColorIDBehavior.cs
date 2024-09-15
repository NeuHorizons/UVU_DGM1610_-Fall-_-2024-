
using UnityEngine;

public class ColorIDBehavior : IDContainersBehaviours
{
    public ColorIdDataList colorIDDataListObj;
    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }

   
}
