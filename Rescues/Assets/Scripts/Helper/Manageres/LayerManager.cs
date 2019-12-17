﻿using UnityEngine;


namespace Rescues
{ 
    public static class LayerManager
    {
        #region Fields

        private const string IGNORERAYCAST = "Ignore Raycast";
        private const string WATER = "Water";
        private const string ENVIRONMENT = "Environment";
        private const string DEFAULT = "Default";
        private const string NONCOLLIDABLE = "Non-Collidable";
        private const string GROUND = "Ground";
        private const string UI = "UI";

        public const int DEFAULTLAYER = 0;

        #endregion

    

        #region Proeprties

        public static int IgnoreRaycastLayer { get; }
        public static int EnvironmentLayer { get; }
        public static int DefaultLayer { get; }
        public static int GroundLayer { get; }
        public static int UiLayer { get; }
        public static int NonCollidableLayer { get; }

        #endregion

    

        #region Class lifecycle

        static LayerManager()
        {
            IgnoreRaycastLayer = LayerMask.GetMask(IGNORERAYCAST, WATER, NONCOLLIDABLE);
            EnvironmentLayer = LayerMask.GetMask(ENVIRONMENT, GROUND);
            DefaultLayer = LayerMask.GetMask(DEFAULT);
            GroundLayer = LayerMask.GetMask(GROUND);
            UiLayer = LayerMask.GetMask(UI);
            NonCollidableLayer = LayerMask.NameToLayer(NONCOLLIDABLE);
        }

        #endregion
    }
}
