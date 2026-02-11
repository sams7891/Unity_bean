using UnityEngine;

public class animatorWalkingScript : MonoBehaviour
{
    public Animator anim;
    public RectTransform rect;
    public float animationSpeed = 1f;

    float time = 0f;
    int direction = 1;

    void OnEnable()
    {
        if (anim == null) return;

        anim.speed = 0f;
        time = 0f;
        direction = 1;
    }

    void Update()
    {
        if (!enabled || anim == null)
            return;

        time += Time.deltaTime * animationSpeed * direction;

        if (time >= 1f)
        {
            time = 1f;
            Reverse();
        }
        else if (time <= 0f)
        {
            time = 0f;
            Reverse();
        }

        anim.Play(0, 0, time);
    }

    void Reverse()
    {
        direction *= -1;

        if (rect != null)
        {
            Vector3 scale = rect.localScale;
            scale.x *= -1f;
            rect.localScale = scale;
        }
    }

    void OnDisable()
    {
        if (anim != null)
            anim.Rebind();
    }
}
