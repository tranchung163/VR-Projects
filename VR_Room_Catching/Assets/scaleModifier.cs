using UnityEngine;

public class ScaleModifier : MonoBehaviour
{
    public float scaleMultiplier = 1f;

    private void Start()
    {
        ApplyUniformScale(transform, scaleMultiplier);
    }

    private void ApplyUniformScale(Transform transform, float scaleMultiplier)
    {
        transform.localScale *= scaleMultiplier;

        if (transform.parent != null)
        {
            ApplyUniformScale(transform.parent, scaleMultiplier);
        }
    }
}
