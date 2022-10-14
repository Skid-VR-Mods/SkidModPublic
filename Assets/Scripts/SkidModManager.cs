//-----------------------------------------------------------------------
//     Author: CTO | Raxsam 
//     Copyright (c) Exeaio | Skid.
//     All rights reserved.
//-----------------------------------------------------------------------
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace Skid.Mods
{
    /// <summary>
    /// Main manager for whole map load and play
    /// </summary>
    public class SkidModManager : MonoBehaviour
    {
        #region Variables
        public static SkidModManager Instance = null;
        [System.Serializable]
        public class InitVariables
        {
            public Transform playerSpawnPos;
        }
        #endregion

        #region Functions
        public void Awake()
        {
            if (Instance) return; 
            else Instance = this;
        }

        /// <summary>
        /// Initialize player properties
        /// </summary>
        public void InitPlayer()
        {
            Debug.Log("Initialized Player");
        }
        /// <summary>
        /// Initialize AI player properties
        /// </summary>
        public void InitAIs()
        {
            Debug.Log("Initialized AIs");
        }

        public void InitOtherFuncions()
        {

        }

        #endregion

        #region Main

        void OnEnable()
        {
            Debug.Log("OnEnable called");
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        // called second
        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Debug.Log("OnSceneLoaded: " + scene.name);
            //Debug.Log(mode);
            InitPlayer();
            InitAIs();
        }

        // called third
        void Start()
        {
            Debug.Log("Start");
        }

        // called when the game is terminated
        void OnDisable()
        {
            Debug.Log("OnDisable");
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        #endregion
    }
}

