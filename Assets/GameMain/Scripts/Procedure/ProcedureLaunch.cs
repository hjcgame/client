using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework;
using GameFramework.Localization;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace CustomFramework
{
	public class ProcedureLaunch : ProcedureBase {

		public override bool UseNativeDialog
        {
            get
            {
                return true;
            }
        }

        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
        	base.OnEnter(procedureOwner);
        	//画质设置，等等
        	InitQualitySettings();
        	Log.Info("OnEnterxxxxxxxxxxx");
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
        	base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        	// Log.Info("OnUpdatexxxxxxxxxxx");
        }

        //设置画质
        private void InitQualitySettings()
        {
            // QualityLevelType defaultQuality = GameEntry.BuiltinData.DeviceModelConfig.GetDefaultQualityLevel();
            // int qualityLevel = GameEntry.Setting.GetInt(Constant.Setting.QualityLevel, (int)defaultQuality);
            // QualitySettings.SetQualityLevel(qualityLevel, true);
            Log.Info("Init quality settings complete.");
        }

        //设置
        
	}
}


