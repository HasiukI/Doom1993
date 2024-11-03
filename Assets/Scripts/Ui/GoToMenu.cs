using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GoToMenu : MonoBehaviour
{
    [SerializeField] private UIDocument _uIDocument;
    [SerializeField] private int _sceneIndex;


    private VisualElement _root;
    private Button _goToMenuButton;

    private void Start()
    {
        _root = _uIDocument.rootVisualElement;
        _goToMenuButton = _root.Q<Button>("MenuBT");


        _goToMenuButton.RegisterCallback<ClickEvent>(OnMenuBuuttonClick);
    }

    private void OnMenuBuuttonClick(ClickEvent evt)
    {
        SceneManager.LoadScene(_sceneIndex);
    }
}
