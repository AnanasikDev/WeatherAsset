using UnityEngine;

//[ExecuteInEditMode]
public class DateTime : MonoBehaviour
{
    [SerializeField] Light dirLight;
    [SerializeField, Tooltip("Length of the day in seconds")] short dayLength;
    [SerializeField, Range(0f, 1f)] float timeProgress = 0;
    public float timeSpeed = 1f;

    [SerializeField] Gradient dirLightGradient;
    [SerializeField] Gradient ambLightGradient;

    void Update()
    {
        /*iter = (int)Mathf.Repeat(++iter, dayLength);
        float x = dirLight.transform.localEulerAngles.x + (360 / dayLength * Time.deltaTime * timeSpeed + iter);
        dirLight.transform.localEulerAngles = Vector3.right * x;*/
        /*iter++;
        if (iter > dayLength) iter = 0;
        dirLight.transform.localEulerAngles = new Vector3(360 * iter, 0, 0);*/
        if (Application.isPlaying)
            timeProgress += Time.deltaTime / dayLength * timeSpeed;
        if (timeProgress > 1f)
            timeProgress = 0;

        dirLight.color = dirLightGradient.Evaluate(timeProgress);
        RenderSettings.ambientLight = ambLightGradient.Evaluate(timeProgress);

        dirLight.transform.localEulerAngles = new Vector3(360f * timeProgress - 90, -30, 0);
    }
}
