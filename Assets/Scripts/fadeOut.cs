using UnityEngine;

public class fadeOut : MonoBehaviour
{
    public float fadeDuration = 3f; // Time in seconds to fade out the game object
    private float fadeProgress = 0f;
    public float fadeSpeed; // Speed at which the object fades out
    private Vector3 initialScale; // Store the initial scale of the object
    private bool isFadedOut = false;
    public bool faded_in = true;

    public bool mud = true;

    private void Start()
    {
        initialScale = transform.localScale;
        if (mud)
        {
            fadeDuration = player_stats.mud_fade_duration;
        }
        else
        {
            fadeDuration = player_stats.bubbles_fade_duration;
        }
        fadeSpeed = 1f / fadeDuration;
    }

    private void Update()
    {
        if (!isFadedOut)
        {
            if (fadeProgress < 1f)
            {
                fadeProgress += Time.deltaTime / fadeDuration;
                UpdateObjectAppearance();
            }
            else
            {
                // The object is fully faded out
                isFadedOut = true;
                faded_in = false;
            }
        }
        if (faded_in == true)
        {
            RestoreSize();
            faded_in = false;
        }
    }

    private void UpdateObjectAppearance()
    {
        // Calculate the vertical scale based on the fade progress
        float verticalScale = Mathf.Lerp(initialScale.y, 0f, Mathf.Pow(fadeProgress, fadeSpeed));
        transform.localScale = new Vector3(initialScale.x, verticalScale, initialScale.z);
    }

    public void RestoreSize()
    {
        fadeProgress = 0f;
        isFadedOut = false;
        transform.localScale = initialScale;
    }
}
