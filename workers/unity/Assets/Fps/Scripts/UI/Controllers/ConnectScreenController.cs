﻿using UnityEngine;
using UnityEngine.UI;

namespace Fps
{
    public class ConnectScreenController : MonoBehaviour
    {
        public Button ConnectButton;

        public void Awake()
        {
            ConnectButton.onClick.AddListener(ConnectClicked);
        }

        public void ConnectClicked()
        {
            if (ConnectionStateReporter.IsConnected)
            {
                ConnectionStateReporter.TrySpawn();
            }
            else
            {
                ConnectionStateReporter.TryConnect();
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && ConnectButton.enabled)
            {
                ConnectButton.onClick.Invoke();
            }
        }
    }
}