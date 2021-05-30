using UnityEngine;

public class Weather : MonoBehaviour
{
    //[SerializeField] ParticleSystem rainSystem;
    [SerializeField] Material mat;
    [SerializeField] short density;
    [SerializeField] float speed;
    private void Update()
    {
        //rainSystem.emission.rateOverTime = new ParticleSystem.MinMaxCurve(density);

        //if (!rainSystem.isPlaying) rainSystem.Play();

        mat.SetTextureOffset(Shader.PropertyToID("_MainTex"), new Vector2(0, mat.mainTextureOffset.y + Time.deltaTime));
    }
}
