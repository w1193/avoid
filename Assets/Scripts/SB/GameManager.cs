﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
namespace SB
{
    public class GameManager : MonoBehaviour
    {




        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void RestartGame()
        {

            SceneManager.LoadScene("test");

        }
    }
}