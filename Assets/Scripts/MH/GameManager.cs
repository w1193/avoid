﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
namespace MH
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
