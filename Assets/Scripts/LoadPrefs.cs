using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class LoadPrefs : MonoBehaviour
{
    [Header("General Setting")]
    [SerializeField] private bool canUse = false;
    [SerializeField] private MainMenu menuController;



    [Header("Volume Setting")]
    [SerializeField] private TMP_Text volumeTextValue = null;
    [SerializeField] private Slider volumeSlider = null;



    [SerializeField] private Volume globalVolume;
    private ColorAdjustments colorAdjustments;


    [Header("Brightness Setting")]
    [SerializeField] private Slider brightnessSlider = null;
    [SerializeField] private TMP_Text brightnessTextValue = null;




    [Header("Quality Level Setting")]
    [SerializeField] private TMP_Dropdown qualityDropdown;
    [Header("Fullscreen Setting")]
    [SerializeField] private Toggle fullScreenToggle;




    [Header("Sensitivty Setting")]
    [SerializeField] private TMP_Text controllerSenTextValue = null;
    [SerializeField] private Slider controllerSenSlider = null;

    [Header("Invert Y Setting")]
    [SerializeField] private Toggle invertYToggle = null;




    private void Awake()
    {
        if (canUse)
        {
            if(PlayerPrefs.HasKey("masterVolume"))
            {
                float localVolume = PlayerPrefs.GetFloat("masterVolume");

                volumeTextValue.text = localVolume.ToString("0.0");
                volumeSlider.value = localVolume;
                AudioListener.volume = localVolume;
            }
            else
            {
                menuController.ResetButton("Audio");
            }

            if (PlayerPrefs.HasKey("masterQuality"))
            {
                int localQuality = PlayerPrefs.GetInt("masterQuality");
                qualityDropdown.value = localQuality;
                QualitySettings.SetQualityLevel(localQuality);
            }


            if (PlayerPrefs.HasKey("masterFullScreen"))
            {
                int localFullscreen = PlayerPrefs.GetInt("masterFullScreen");

                if (localFullscreen == 1)
                {
                    Screen.fullScreen = true;
                    fullScreenToggle.isOn = true;
                }
                else
                {
                    Screen.fullScreen = false;
                    fullScreenToggle.isOn = false;
                }
            }


            if (PlayerPrefs.HasKey("masterBrightness"))
            {
                float localBrightness = PlayerPrefs.GetFloat("masterBrightness");

                brightnessTextValue.text = localBrightness.ToString("0.0");
                brightnessSlider.value = localBrightness;
                //Change the brightness of the game here

                if (colorAdjustments != null)
                {
                    colorAdjustments.postExposure.value = localBrightness;
                }


            }


            if(PlayerPrefs.HasKey("masterSen"))
            {
                float localSenensitivity = PlayerPrefs.GetFloat("masterSen");

                controllerSenTextValue.text = localSenensitivity.ToString("0");
                controllerSenSlider.value = localSenensitivity;
                menuController.mainControllerSen = Mathf.RoundToInt(localSenensitivity);
            }


            if(PlayerPrefs.HasKey("masterInvertY"))
            {
                if(PlayerPrefs.GetInt("masterInvertY") == 1)
                {
                    invertYToggle.isOn = true;
                }

                else
                {
                    invertYToggle.isOn = false;
                }
            }


        }
    }

}
