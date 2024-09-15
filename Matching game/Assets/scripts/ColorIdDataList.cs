using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentColor;

    private int num;

    public void SetCurrentColorRandomly()
    {
        if (colorIDList.Count == 0)
        {
            Debug.LogWarning("The color list is empty!");
            return;
        }

        num = Random.Range(0, colorIDList.Count); 
        currentColor = colorIDList[num];           
    }
}