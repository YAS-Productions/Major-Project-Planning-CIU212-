using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickerSpark : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem m_particleSystem;
    [SerializeField]
    private Light[] m_light;
    [SerializeField]
    private Material m_emissiveMaterial;
    [SerializeField]
    private float m_normalFliclerTime = .5f;
    [SerializeField]
    private bool m_isFlickering = false;
    [SerializeField]
    private float m_flickerDuration;
    private AudioSource m_audioSource;
    public float intensity;

    private Color m_originalEmmisionColor;
    private float currentTimer;
    private float durationTimer;
    private Color m_offColor = new Color(0, 0, 0, 0);
    private bool m_isLightOn = true;

    private void Start()
    {
        currentTimer = m_normalFliclerTime;
        m_originalEmmisionColor = m_emissiveMaterial.GetColor("_EmissionColor");
        m_audioSource = this.GetComponent<AudioSource>();
        
    }

    private void Update()
    {
        if (m_isFlickering)
        {
            if (durationTimer > 0)
            {
                durationTimer -= Time.deltaTime;
            }
            else
            {
                m_emissiveMaterial.SetColor("_EmissionColor", m_originalEmmisionColor);

                for (int i = 0; i < m_light.Length; i++)
                {
                    m_light[i].GetComponent<Light>().intensity = intensity;
                }
                //m_light[0].GetComponent<Light>().intensity = intensity;
                //m_light[1].GetComponent<Light>().intensity = intensity;
                //m_light.intensity = intensity;
                m_isLightOn = true;
                m_isFlickering = false;
                currentTimer = Random.Range(4f, 7f);
                m_particleSystem.gameObject.SetActive(false);
            }
        }

        if (currentTimer > 0)
        {
            currentTimer -= Time.deltaTime;
        }
        else
        {
            if (!m_isFlickering)
            {
                m_isFlickering = true;
                currentTimer = Random.Range(0.005f, 0.12f);
                durationTimer = m_flickerDuration;
                m_particleSystem.gameObject.SetActive(true);
                m_audioSource.Play();

            }
            else
            {

                if (m_isLightOn)
                {
                    m_emissiveMaterial.SetColor("_EmissionColor", m_offColor);
                    currentTimer = Random.Range(0.005f, 0.12f);
                    //m_light.intensity = 0;
                    for (int i = 0; i < m_light.Length; i++)
                    {
                        m_light[i].GetComponent<Light>().intensity = 0;
                    }
                    //m_light[0].GetComponent<Light>().intensity = 0;
                    //m_light[1].GetComponent<Light>().intensity = 0;
                    m_isLightOn = false;
                }
                else
                {
                    m_emissiveMaterial.SetColor("_EmissionColor", m_originalEmmisionColor);
                    currentTimer = Random.Range(0.005f, 0.12f);
                    //m_light.intensity = intensity;
                    for (int i = 0; i < m_light.Length; i++)
                    {
                        m_light[i].GetComponent<Light>().intensity = intensity;
                    }
                    //m_light[0].GetComponent<Light>().intensity = intensity;
                    //m_light[1].GetComponent<Light>().intensity = intensity;
                    m_isLightOn = true;
                }
            }
        }
    }

    private void OnApplicationQuit()
    {
        m_emissiveMaterial.SetColor("_EmissionColor", m_originalEmmisionColor);

    }
}