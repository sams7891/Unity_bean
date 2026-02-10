using UnityEngine;

public class animatorWalkingScript : MonoBehaviour
{
    public Animator anim;
    public RectTransform rect;

    public float animationSpeed = 1f;

    float time = 0f;
    int direction = 1;

    void Start()
    {
        anim.speed = 0f; // we control time manually
    }

    void Update()
    {
        

        time += Time.deltaTime * animationSpeed * direction;

        // Clamp between 0 and 1
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

        // Flip UI horizontally
        Vector3 scale = rect.localScale;
        scale.x *= -1f;
        rect.localScale = scale;
    }
    void OnEnable()
    {
        anim.speed = 0f;
    }

    void OnDisable()
    {
        if (anim != null)
            anim.Rebind();
    }

}
