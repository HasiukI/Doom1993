using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIDocument _uIDocument;
    [SerializeField] private int _sceneIndex;

    private VisualElement _root;
    private Button _play1Button;
    private Button _play2Button;
    private Button _play3Button;
    private Button _exitButton;
   

    private void Start()
    {
        _root = _uIDocument.rootVisualElement;
        _play1Button = _root.Q<Button>("Play1BT");
        _play2Button = _root.Q<Button>("Play2BT");
        _play3Button = _root.Q<Button>("Play3BT");
        _exitButton = _root.Q<Button>("ExitBT");

        _play1Button.RegisterCallback<ClickEvent>(OnPlay1BuuttonClick);
        _play2Button.RegisterCallback<ClickEvent>(OnPlay2BuuttonClick);
        _play3Button.RegisterCallback<ClickEvent>(OnPlay3BuuttonClick);


        _exitButton.RegisterCallback<ClickEvent>(OnExitBuuttonClick);
    }

    private void OnExitBuuttonClick(ClickEvent evt)
    {
        Application.Quit();
    }

    private void OnPlay1BuuttonClick(ClickEvent evt)
    {
        SceneManager.LoadScene(1);
    }
    private void OnPlay2BuuttonClick(ClickEvent evt)
    {
        SceneManager.LoadScene(2);
    }
    private void OnPlay3BuuttonClick(ClickEvent evt)
    {
        SceneManager.LoadScene(3);
    }
}
