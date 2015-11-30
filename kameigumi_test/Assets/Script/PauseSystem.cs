using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PauseSystem : MonoBehaviour {
	static List<PauseSystem> targets = new List<PauseSystem>();	// ポーズ対象のスクリプト
	Behaviour[] pauseBehavs = null;	// ポーズ対象のコンポーネント
	ParticleSystem[] pauseParticle = null;
	static bool isPause;
	public static bool IsPause{
		get{return isPause;}
	}
	// 初期化
	void Start() {
		// ポーズ対象に追加する
		targets.Add(this);
	}
	
	// 破棄されるとき
	void OnDestory() {
		// ポーズ対象から除外する
		targets.Remove(this);
	}
	
	// ポーズされたとき
	void OnPause() {
		if ( pauseBehavs != null ) {
			return;
		}
		isPause = true;
		// 有効なBehaviourを取得
		Debug.Log(this.gameObject.name);
		pauseBehavs = Array.FindAll(GetComponentsInChildren<Behaviour>(), (obj) => { return obj.enabled; });
		
		foreach ( var com in pauseBehavs ) {
			com.enabled = false;
		}

		pauseParticle = Array.FindAll(GetComponentsInChildren<ParticleSystem>(), (obj) => {return obj.isPlaying;});
		foreach(var par in pauseParticle){
			par.Pause();
		}
	}
	
	// ポーズ解除されたとき
	void OnResume() {
		if ( pauseBehavs == null ) {
			return;
		}
		isPause = false;
		// ポーズ前の状態にBehaviourの有効状態を復元
		foreach ( var com in pauseBehavs ) {
			com.enabled = true;
		}
		pauseParticle = Array.FindAll(GetComponentsInChildren<ParticleSystem>(), (obj) => {return obj.isPaused;});
		foreach(var par in pauseParticle){
			par.Play();
		}
		pauseBehavs = null;
	}
	
	// ポーズ
	public static void Pause() {
		foreach ( var obj in targets ) {
			obj.OnPause();
		}
	}
	
	// ポーズ解除
	public static void Resume() {
		foreach ( var obj in targets ) {
			obj.OnResume();
		}
	}


	public static void Clear(){
		targets.Clear();
	}
}