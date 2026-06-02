using System;
using UnityEngine;





public static class PlayerModel
{
    #region - Player - 


    public enum PlayerStance
    {
        Standing,
        Crouching,
        Prone
    }


    


    [Serializable]
    public class PlayerSettingsModel
    {
        [Header("화면 설정")]
        public float ViewXSensitivity;
        public float ViewYSensitivity;



        [Header("이동 설정")]
        public bool SprintingHold;
        public float MovementSmoothing;

        [Header("이동 설정 - 뛰기")]
        public float RunningFowardSpeed;
        public float RunningStrafeSpeed;



        [Header("이동 설정 - 걷기")]
        public float WalkingFowardSpeed;
        public float WalkingBackwardSpeed;
        public float WalkingStrafeSpeed;


        [Header("점프 설정")]
        public float JumpingHeight;
        public float JumpingFalloff;
        public float FallingSmoothing;


        [Header("속도 배율 설정")]
        public float SpeedEffector = 1;
        public float CrouchSpeedEffector;
        public float ProneSpeedEffector;
        public float FallingSpeedEffector;
    }

    [Serializable]
    public class CharacterStance
    {
        public float CameraHeight;
        public CapsuleCollider StanceCollider;
    }

    #endregion


    #region - Weapons -

    [Serializable]
    public class WeaponSettingsModel
    {
        [Header("무기 움직임")]
        public float SwayAmount;
        public float SwaySmoothing;

        public float SwayResetSmoothing;
        public float SwayClampX;
        public float SwayClampY;

    }



    #endregion
}