using UnityEngine;

public class ColorIDBehaviour : IDContainersBehaviours
{
    public ColorIDDataList colorIDDataListObj;
    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }

   
}
