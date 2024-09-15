using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;

    // Event function
    private void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRendererColor(ColorIdDataList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }
}