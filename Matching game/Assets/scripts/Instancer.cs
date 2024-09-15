using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;


[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject Prefab;
    private int num;
    public void CreateInstance()
    {
        Instantiate(Prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(Prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        for (int i = 0; i < obj.vector3DList.Count; i++)
        {
            Instantiate(Prefab, obj.vector3DList[i].value, Quaternion.identity);
        }
      
    }
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(Prefab, obj.vector3DList[num].value, Quaternion.identity);
        num++;
        if(num == obj. vector3DList.Count)
        {
            num = 0;
        }
      
    }
    public void CreateInstanceListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3DList.Count);
        Instantiate(Prefab, obj.vector3DList[num].value, Quaternion.identity);
    }

}