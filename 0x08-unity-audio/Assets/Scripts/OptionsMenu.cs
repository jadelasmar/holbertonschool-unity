using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    private Toggle invertYToggle;
    private Slider bgm;
    private Slider sfx;

    private void Start()
    {
        // Initialize any unset PlayerPref settings.
        InitializeSettings();

        // Get reference to UI toggle.
        invertYToggle = GameObject.Find("InvertYToggle").GetComponent<Toggle>();
        bgm =GameObject.Find("BGMSlider").GetComponent<Slider>();
        sfx =GameObject.Find("SFXSlider").GetComponent<Slider>();

        // Retrieve inversion setting from disk to set toggle starting state.
        // (0 = not inverted, 1 = inverted).
        invertYToggle.isOn = PlayerPrefs.GetInt(PlayerPrefKeys.invertY) == 1 ? true : false;
        bgm.value = PlayerPrefs.GetFloat(PlayerPrefKeys.bgmVolume);
        sfx.value = PlayerPrefs.GetFloat(PlayerPrefKeys.sfxVolume);

        // Show cursor.
        Cursor.visible = true;
    }

    public void Back()
    {
        // For dynamic back maybe...
        var previousScene = PlayerPrefs.GetInt(PlayerPrefKeys.previousScene);
        SceneManager.LoadScene(previousScene);
    }

    public void Apply()
    {
        // Update PlayerPrefs with current settings.
        PlayerPrefs.SetInt(PlayerPrefKeys.invertY, invertYToggle.isOn ? 1 : 0);
        PlayerPrefs.SetFloat(PlayerPrefKeys.bgmVolume,bgm.value);
        PlayerPrefs.SetFloat(PlayerPrefKeys.sfxVolume,sfx.value);
    }

    private void InitializeSettings()
    {
        // Check to see if PlayerPrefs are initialized and, if not, initialize.
        if (!PlayerPrefs.HasKey(PlayerPrefKeys.invertY))
            PlayerPrefs.SetInt(PlayerPrefKeys.invertY, 0);

        if (!PlayerPrefs.HasKey(PlayerPrefKeys.previousScene))
            PlayerPrefs.SetInt(PlayerPrefKeys.previousScene, 0);
        
        if (!PlayerPrefs.HasKey(PlayerPrefKeys.bgmVolume))
            PlayerPrefs.SetFloat(PlayerPrefKeys.bgmVolume, 0.2f);
        
        if (!PlayerPrefs.HasKey(PlayerPrefKeys.sfxVolume))
            PlayerPrefs.SetFloat(PlayerPrefKeys.sfxVolume, 0.6f);
    }
}