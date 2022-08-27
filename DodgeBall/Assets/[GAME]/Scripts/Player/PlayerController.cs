using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum PlayerStates
    {
        Idle,
        Run,
        Dead,
        OnFinishWall,
        Finish
    }

    public static PlayerStates PlayerState;
    private PlayerMovementController _playerMovementController;

    private void Start()
    {
        _playerMovementController = GetComponent<PlayerMovementController>();
        PlayerState = PlayerStates.Idle;
    }

    private void OnEnable()
    {
        EventManager.GameStart += GameStart;
    }

    private void OnDisable()
    {
        EventManager.GameStart -= GameStart;
    }

    private void GameStart()
    {
        PlayerState = PlayerStates.Run;
    }
}