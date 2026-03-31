using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private Button playButton;

    private void Start()
    {
        pauseButton.onClick.AddListener(PauseButton);
        playButton.onClick.AddListener(PlayButton);
        playButton.gameObject.SetActive(false);
    }
    
    private void PlayButton()
    {
        Time.timeScale = 1;
        playButton.gameObject.SetActive(false);
    }

    private void PauseButton()
    {
        Time.timeScale = 0;
        playButton.gameObject.SetActive(true);
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveListener(PlayButton);
        pauseButton.onClick.RemoveListener(PauseButton);
    }
}
